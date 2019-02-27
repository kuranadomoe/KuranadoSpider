namespace kuranado.moe.Spider.WallpaperAbyss
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpDownload = new System.Windows.Forms.TabPage();
            this.btnStartDownload = new System.Windows.Forms.Button();
            this.rtbTargetLinks = new System.Windows.Forms.RichTextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.pbTotalDownload = new System.Windows.Forms.ProgressBar();
            this.pbCurDownload = new System.Windows.Forms.ProgressBar();
            this.tpSetting = new System.Windows.Forms.TabPage();
            this.gbLinkType = new System.Windows.Forms.GroupBox();
            this.rbResourceType = new System.Windows.Forms.RadioButton();
            this.rbWebType = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.dudMaxRetry = new System.Windows.Forms.DomainUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbImgLinksSavePath = new System.Windows.Forms.TextBox();
            this.tbImgSaveDir = new System.Windows.Forms.TextBox();
            this.tbMinDownloadTime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dudMaxDownloadThread = new System.Windows.Forms.DomainUpDown();
            this.tcMain.SuspendLayout();
            this.tpDownload.SuspendLayout();
            this.tpSetting.SuspendLayout();
            this.gbLinkType.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "请将目标链接填入下方,每行一条:\r\n";
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpDownload);
            this.tcMain.Controls.Add(this.tpSetting);
            this.tcMain.Location = new System.Drawing.Point(12, 12);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(472, 449);
            this.tcMain.TabIndex = 2;
            // 
            // tpDownload
            // 
            this.tpDownload.Controls.Add(this.btnStartDownload);
            this.tpDownload.Controls.Add(this.rtbTargetLinks);
            this.tpDownload.Controls.Add(this.rtbDisplay);
            this.tpDownload.Controls.Add(this.pbTotalDownload);
            this.tpDownload.Controls.Add(this.pbCurDownload);
            this.tpDownload.Controls.Add(this.label1);
            this.tpDownload.Location = new System.Drawing.Point(4, 22);
            this.tpDownload.Name = "tpDownload";
            this.tpDownload.Padding = new System.Windows.Forms.Padding(3);
            this.tpDownload.Size = new System.Drawing.Size(464, 423);
            this.tpDownload.TabIndex = 0;
            this.tpDownload.Text = "下载";
            this.tpDownload.UseVisualStyleBackColor = true;
            // 
            // btnStartDownload
            // 
            this.btnStartDownload.Location = new System.Drawing.Point(8, 336);
            this.btnStartDownload.Name = "btnStartDownload";
            this.btnStartDownload.Size = new System.Drawing.Size(450, 23);
            this.btnStartDownload.TabIndex = 9;
            this.btnStartDownload.Text = "Start Download";
            this.btnStartDownload.UseVisualStyleBackColor = true;
            // 
            // rtbTargetLinks
            // 
            this.rtbTargetLinks.Location = new System.Drawing.Point(8, 38);
            this.rtbTargetLinks.Name = "rtbTargetLinks";
            this.rtbTargetLinks.Size = new System.Drawing.Size(450, 123);
            this.rtbTargetLinks.TabIndex = 8;
            this.rtbTargetLinks.Text = "";
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbDisplay.Location = new System.Drawing.Point(8, 167);
            this.rtbDisplay.Name = "rtbDisplay";
            this.rtbDisplay.ReadOnly = true;
            this.rtbDisplay.Size = new System.Drawing.Size(450, 163);
            this.rtbDisplay.TabIndex = 7;
            this.rtbDisplay.Text = "";
            // 
            // pbTotalDownload
            // 
            this.pbTotalDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbTotalDownload.Location = new System.Drawing.Point(8, 394);
            this.pbTotalDownload.Name = "pbTotalDownload";
            this.pbTotalDownload.Size = new System.Drawing.Size(450, 23);
            this.pbTotalDownload.TabIndex = 6;
            // 
            // pbCurDownload
            // 
            this.pbCurDownload.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbCurDownload.Location = new System.Drawing.Point(8, 365);
            this.pbCurDownload.Name = "pbCurDownload";
            this.pbCurDownload.Size = new System.Drawing.Size(450, 23);
            this.pbCurDownload.TabIndex = 5;
            // 
            // tpSetting
            // 
            this.tpSetting.Controls.Add(this.gbLinkType);
            this.tpSetting.Controls.Add(this.label6);
            this.tpSetting.Controls.Add(this.dudMaxRetry);
            this.tpSetting.Controls.Add(this.label5);
            this.tpSetting.Controls.Add(this.label4);
            this.tpSetting.Controls.Add(this.tbImgLinksSavePath);
            this.tpSetting.Controls.Add(this.tbImgSaveDir);
            this.tpSetting.Controls.Add(this.tbMinDownloadTime);
            this.tpSetting.Controls.Add(this.label3);
            this.tpSetting.Controls.Add(this.label2);
            this.tpSetting.Controls.Add(this.dudMaxDownloadThread);
            this.tpSetting.Location = new System.Drawing.Point(4, 22);
            this.tpSetting.Name = "tpSetting";
            this.tpSetting.Padding = new System.Windows.Forms.Padding(3);
            this.tpSetting.Size = new System.Drawing.Size(464, 423);
            this.tpSetting.TabIndex = 1;
            this.tpSetting.Text = "设置";
            this.tpSetting.UseVisualStyleBackColor = true;
            // 
            // gbLinkType
            // 
            this.gbLinkType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLinkType.Controls.Add(this.rbResourceType);
            this.gbLinkType.Controls.Add(this.rbWebType);
            this.gbLinkType.Location = new System.Drawing.Point(28, 232);
            this.gbLinkType.Name = "gbLinkType";
            this.gbLinkType.Size = new System.Drawing.Size(372, 68);
            this.gbLinkType.TabIndex = 0;
            this.gbLinkType.TabStop = false;
            this.gbLinkType.Text = "给定链接类型";
            // 
            // rbResourceType
            // 
            this.rbResourceType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbResourceType.AutoSize = true;
            this.rbResourceType.Location = new System.Drawing.Point(222, 29);
            this.rbResourceType.Name = "rbResourceType";
            this.rbResourceType.Size = new System.Drawing.Size(83, 16);
            this.rbResourceType.TabIndex = 1;
            this.rbResourceType.TabStop = true;
            this.rbResourceType.Text = "待下载图片";
            this.rbResourceType.UseVisualStyleBackColor = true;
            // 
            // rbWebType
            // 
            this.rbWebType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.rbWebType.AutoSize = true;
            this.rbWebType.Checked = true;
            this.rbWebType.Location = new System.Drawing.Point(71, 29);
            this.rbWebType.Name = "rbWebType";
            this.rbWebType.Size = new System.Drawing.Size(83, 16);
            this.rbWebType.TabIndex = 0;
            this.rbWebType.TabStop = true;
            this.rbWebType.Text = "待爬取网页";
            this.rbWebType.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 76);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "失败重试次数          :";
            // 
            // dudMaxRetry
            // 
            this.dudMaxRetry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dudMaxRetry.Enabled = false;
            this.dudMaxRetry.Items.Add("0");
            this.dudMaxRetry.Items.Add("1");
            this.dudMaxRetry.Items.Add("2");
            this.dudMaxRetry.Items.Add("3");
            this.dudMaxRetry.Items.Add("4");
            this.dudMaxRetry.Items.Add("5");
            this.dudMaxRetry.Items.Add("6");
            this.dudMaxRetry.Items.Add("7");
            this.dudMaxRetry.Items.Add("8");
            this.dudMaxRetry.Location = new System.Drawing.Point(175, 74);
            this.dudMaxRetry.Name = "dudMaxRetry";
            this.dudMaxRetry.ReadOnly = true;
            this.dudMaxRetry.Size = new System.Drawing.Size(225, 21);
            this.dudMaxRetry.Sorted = true;
            this.dudMaxRetry.TabIndex = 8;
            this.dudMaxRetry.Text = "4";
            this.dudMaxRetry.Wrap = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "图片链接保存路径      :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "图片保存路径          :";
            // 
            // tbImgLinksSavePath
            // 
            this.tbImgLinksSavePath.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImgLinksSavePath.Location = new System.Drawing.Point(175, 187);
            this.tbImgLinksSavePath.Name = "tbImgLinksSavePath";
            this.tbImgLinksSavePath.Size = new System.Drawing.Size(225, 21);
            this.tbImgLinksSavePath.TabIndex = 5;
            this.tbImgLinksSavePath.Text = "./WallpaperAbyssImgs/links.txt";
            // 
            // tbImgSaveDir
            // 
            this.tbImgSaveDir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImgSaveDir.Location = new System.Drawing.Point(175, 148);
            this.tbImgSaveDir.Name = "tbImgSaveDir";
            this.tbImgSaveDir.Size = new System.Drawing.Size(225, 21);
            this.tbImgSaveDir.TabIndex = 4;
            this.tbImgSaveDir.Text = "./WallpaperAbyssImgs";
            // 
            // tbMinDownloadTime
            // 
            this.tbMinDownloadTime.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMinDownloadTime.Enabled = false;
            this.tbMinDownloadTime.Location = new System.Drawing.Point(175, 112);
            this.tbMinDownloadTime.Name = "tbMinDownloadTime";
            this.tbMinDownloadTime.Size = new System.Drawing.Size(225, 21);
            this.tbMinDownloadTime.TabIndex = 3;
            this.tbMinDownloadTime.Text = "4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "每次下载最小耗时(秒)  :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "最大下载线程数        :";
            // 
            // dudMaxDownloadThread
            // 
            this.dudMaxDownloadThread.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dudMaxDownloadThread.Items.Add("0");
            this.dudMaxDownloadThread.Items.Add("1");
            this.dudMaxDownloadThread.Items.Add("2");
            this.dudMaxDownloadThread.Items.Add("3");
            this.dudMaxDownloadThread.Items.Add("4");
            this.dudMaxDownloadThread.Items.Add("5");
            this.dudMaxDownloadThread.Items.Add("6");
            this.dudMaxDownloadThread.Items.Add("7");
            this.dudMaxDownloadThread.Items.Add("8");
            this.dudMaxDownloadThread.Location = new System.Drawing.Point(175, 36);
            this.dudMaxDownloadThread.Name = "dudMaxDownloadThread";
            this.dudMaxDownloadThread.ReadOnly = true;
            this.dudMaxDownloadThread.Size = new System.Drawing.Size(225, 21);
            this.dudMaxDownloadThread.Sorted = true;
            this.dudMaxDownloadThread.TabIndex = 0;
            this.dudMaxDownloadThread.Text = "4";
            this.dudMaxDownloadThread.Wrap = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 473);
            this.Controls.Add(this.tcMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wallpaper Abyss Spider by kuranadomoe";
            this.tcMain.ResumeLayout(false);
            this.tpDownload.ResumeLayout(false);
            this.tpDownload.PerformLayout();
            this.tpSetting.ResumeLayout(false);
            this.tpSetting.PerformLayout();
            this.gbLinkType.ResumeLayout(false);
            this.gbLinkType.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpDownload;
        private System.Windows.Forms.TabPage tpSetting;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.ProgressBar pbTotalDownload;
        private System.Windows.Forms.ProgressBar pbCurDownload;
        private System.Windows.Forms.TextBox tbImgLinksSavePath;
        private System.Windows.Forms.TextBox tbImgSaveDir;
        private System.Windows.Forms.TextBox tbMinDownloadTime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DomainUpDown dudMaxDownloadThread;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox rtbTargetLinks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DomainUpDown dudMaxRetry;
        private System.Windows.Forms.Button btnStartDownload;
        private System.Windows.Forms.GroupBox gbLinkType;
        private System.Windows.Forms.RadioButton rbResourceType;
        private System.Windows.Forms.RadioButton rbWebType;
    }
}

