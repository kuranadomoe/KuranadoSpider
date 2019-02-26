using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Text.RegularExpressions;
using HtmlAgilityPack;
using System.Threading;

namespace kuranado.moe.Spider.WallpaperAbyss
{
    public partial class MainForm : Form
    {
        //  DefaultDir为默认保存目录,其余对应五个控件代表的值,值的更新通过控件事件完成
        private static string DefaultDir => Path.Combine(Environment.CurrentDirectory, "WallpaperAbyssImgs");
        private int MaxDownloadThread { get; set; } = 2;
        private int MaxRetry { get; set; } = 4;
        private int MinDownloadTime { get; set; } = 4;
        private string ImgSaveDir { get; set; } = DefaultDir;
        private string ImgLinksSavePath { get; set; } = Path.Combine(DefaultDir, "links.txt");

        public MainForm()
        {
            InitializeComponent();

            //  初始化控件
            btnStartDownload.Click += BtnStartDownloadAsync_Click;
            tbImgSaveDir.Click += TbImgSaveDir_Click;
            tbImgLinksSavePath.Click += TbImgLinksSavePath_Click;
            dudMaxDownloadThread.SelectedItemChanged += (x, y) => MaxDownloadThread = int.Parse((x as DomainUpDown).SelectedItem as string);
            dudMaxRetry.SelectedItemChanged += (x, y) => MaxRetry = int.Parse((x as DomainUpDown).SelectedItem as string);
            pbCurDownload.CursorChanged += (x, y) =>
              {
                  if ((x as ProgressBar).Value == 100)
                      (x as ProgressBar).Value = 0;
              };
            tbMinDownloadTime.Leave += (x, y) =>
                {
                    var text = (x as TextBox).Text;
                    if (!int.TryParse(text, out int num))
                    {
                        MessageBox.Show("输入无效!");
                        (x as TextBox).Text = "4";
                    }
                    else
                    {
                        MinDownloadTime = num;
                    }
                };
        }


        private void TbImgSaveDir_Click(object sender, EventArgs e)
        {
            var dialog = new FolderBrowserDialog();
            dialog.ShowNewFolderButton = true;
            dialog.SelectedPath = DefaultDir;
            dialog.Description = "选择或新建一个文件夹";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                ImgSaveDir = dialog.SelectedPath;
            }
        }


        private void TbImgLinksSavePath_Click(object sender, EventArgs e)
        {
            var dialog = new SaveFileDialog();
            dialog.AddExtension = true;
            dialog.CheckPathExists = true;
            dialog.CreatePrompt = true;
            dialog.OverwritePrompt = true;
            dialog.DefaultExt = ".txt";
            dialog.InitialDirectory = DefaultDir;
            dialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            var result = dialog.ShowDialog();
            if (result == DialogResult.OK || result == DialogResult.Yes)
            {
                ImgSaveDir = dialog.FileName;
            }
        }


        private async void BtnStartDownloadAsync_Click(object sender, EventArgs e)
        {
            var urls = rtbTargetLinks.Text.Split('\r', '\n');
            btnStartDownload.Enabled = false;
            foreach (var item in urls)
            {
                if (UriCheck(item))
                {
                    await Task.Run(() => Crawl(item));
                }
                else
                {
                    MessageBox.Show($"链接格式错误:\n{item}");
                }
            }
            btnStartDownload.Enabled = true;
        }


        /// <summary>
        /// 检验给定uri是否有效,是则返回true,否则返回false
        /// </summary>
        /// <param name="uriName"></param>
        /// <returns></returns>
        private static bool UriCheck(string uriName)
        {
            return Uri.TryCreate(uriName, UriKind.Absolute, out Uri uriResult)
                && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps);
        }


        /// <summary>
        /// 下载队列
        /// </summary>
        private SortedSet<(string imgName, string imgLink)> DownloadList
        {
            get
            {
                lock (locker)
                {
                    return downloadList;
                }
            }
        }
        private object locker = new object();
        private SortedSet<(string imgName, string imgLink)> downloadList = new SortedSet<(string imgName, string imgLink)>();

        /// <summary>
        /// 抓取网页链接并存放于SortedSet
        /// </summary>
        /// <param name="uri"></param>
        private void Crawl(string uri)
        {
            this.Invoke(new Action(() => rtbDisplay.Text += $"\r\n\r\n\r\n开始爬取: {uri}\r\n\r\n"));

            DownloadList.Clear();
            DownloadList.Add(("", ""));

            Thread download = new Thread(DownloadImg);
            download.Name = "下载线程";
            download.Start();


            var html = new HtmlWeb();
            var htmlDoc = html.Load(uri);

            //  进度条
            var title = htmlDoc.DocumentNode.SelectNodes(@"/html/head/title")[0].InnerText;
            var imgTotal = int.Parse(Regex.Match(title, @"\d+").Value);
            this.Invoke(new Action(() => pbTotalDownload.Maximum = imgTotal));

            var nextPageLink = uri;
            for (; nextPageLink != "#";)
            {
                var curPage = html.Load(nextPageLink).DocumentNode;
                var imgNodes = curPage.SelectNodes(@"//*[@id=""page_container""]/div[6]//*/div[1]/div[2]/div[1]/div[3]/span");
                foreach (var span in imgNodes)
                {
                    var dataId = span.Attributes["data-id"].Value;
                    var dataServer = span.Attributes["data-server"].Value;
                    var dataType = span.Attributes["data-type"].Value;
                    var link = $"https://initiate.alphacoders.com/download/wallpaper/{dataId}/{dataServer}/{dataType}";

                    DownloadList.Add(($"{dataId}.{dataType}", link));
                    File.AppendAllLines(ImgLinksSavePath, new string[] { link });
                }
                nextPageLink = curPage.SelectNodes(@"//*[@id=""next_page""]")[0].Attributes["href"].Value;
            }


            //  wait download complete
            for (; DownloadList.Count > 1;)
                ;
            DownloadList.Clear();
        }


        /// <summary>
        /// 下载抓取的图片,直至所有图片均已下载完毕
        /// </summary>
        private void DownloadImg()
        {
            var curDownloadingCount = 0;
            for (; DownloadList.Count > 0;)
            {
                if (curDownloadingCount < MaxDownloadThread && DownloadList.Count > 1)
                {
                    var imgInfo = DownloadList.Last();
                    this.Invoke(new Action(() => rtbDisplay.Text += $"正在下载: {imgInfo.imgLink}\r\n"));
                    var webClient = new WebClient();
                    webClient.DownloadFileAsync(new Uri(imgInfo.imgLink), imgInfo.imgName);
                    webClient.DownloadProgressChanged += (x, y) =>
                    {
                        pbCurDownload.Value += (y.ProgressPercentage / MaxDownloadThread);
                    };
                    webClient.DownloadFileCompleted += (x, y) =>
                     {
                         --curDownloadingCount;
                         DownloadList.Remove(imgInfo);
                         this.Invoke(new Action(() => pbTotalDownload.Value += 1));
                         this.Invoke(new Action(() => rtbDisplay.Text += $"下载完成: {imgInfo.imgLink}\r\n"));
                     };
                    ++curDownloadingCount;
                }
            }
        }
    }
}
