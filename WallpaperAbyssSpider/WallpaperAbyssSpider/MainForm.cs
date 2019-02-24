using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallpaperAbyssSpider
{
    public partial class MainForm : Form
    {
        private string ImgSaveDir { get; set; }
        private string ImgLinksSavePath { get; set; }
        private string DefaultDir => Path.Combine(Environment.CurrentDirectory, "WallpaperAbyssImgs");

        public MainForm()
        {
            InitializeComponent();


            btnStartDownload.Click += BtnStartDownload_Click;
            tbImgSaveDir.Click += TbImgSaveDir_Click;
            tbImgLinksSavePath.Click += TbImgLinksSavePath_Click;
            tbMinDownloadTime.Leave += (x, y) =>
                {
                    var text = (x as TextBox).Text;
                    if (!int.TryParse(text, out int num))
                    {
                        MessageBox.Show("输入无效!");
                        (x as TextBox).Text = "4";
                    }
                };
        }


        private void BtnStartDownload_Click(object sender, EventArgs e)
        {

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
    }
}
