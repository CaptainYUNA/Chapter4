namespace Chapter4
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.chpater152 = new System.Windows.Forms.GroupBox();
            this.selectFileButton = new System.Windows.Forms.Button();
            this.myPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.chpater153 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.끝내기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.설정ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.폰트ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.배경색ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.chpater152.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.myPlayer)).BeginInit();
            this.chpater153.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chpater152
            // 
            this.chpater152.Controls.Add(this.selectFileButton);
            this.chpater152.Controls.Add(this.myPlayer);
            this.chpater152.Location = new System.Drawing.Point(12, 77);
            this.chpater152.Name = "chpater152";
            this.chpater152.Size = new System.Drawing.Size(444, 426);
            this.chpater152.TabIndex = 0;
            this.chpater152.TabStop = false;
            this.chpater152.Text = "Chapter 152";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(363, 389);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.Size = new System.Drawing.Size(75, 23);
            this.selectFileButton.TabIndex = 1;
            this.selectFileButton.Text = "파일 선택";
            this.selectFileButton.UseVisualStyleBackColor = true;
            this.selectFileButton.Click += new System.EventHandler(this.Handler_selectFileClick);
            // 
            // myPlayer
            // 
            this.myPlayer.Enabled = true;
            this.myPlayer.Location = new System.Drawing.Point(7, 21);
            this.myPlayer.Name = "myPlayer";
            this.myPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("myPlayer.OcxState")));
            this.myPlayer.Size = new System.Drawing.Size(431, 362);
            this.myPlayer.TabIndex = 0;
            // 
            // chpater153
            // 
            this.chpater153.Controls.Add(this.button1);
            this.chpater153.Location = new System.Drawing.Point(462, 77);
            this.chpater153.Name = "chpater153";
            this.chpater153.Size = new System.Drawing.Size(147, 56);
            this.chpater153.TabIndex = 2;
            this.chpater153.TabStop = false;
            this.chpater153.Text = "Chpater 153";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "텍스트 파일 선택";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Handler_Button1Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.설정ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.끝내기ToolStripMenuItem});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 끝내기ToolStripMenuItem
            // 
            this.끝내기ToolStripMenuItem.Name = "끝내기ToolStripMenuItem";
            this.끝내기ToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.끝내기ToolStripMenuItem.Text = "끝내기";
            this.끝내기ToolStripMenuItem.Click += new System.EventHandler(this.Handler_끝내기toolStripMenuItemClick);
            // 
            // 설정ToolStripMenuItem
            // 
            this.설정ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.폰트ToolStripMenuItem,
            this.배경색ToolStripMenuItem});
            this.설정ToolStripMenuItem.Name = "설정ToolStripMenuItem";
            this.설정ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.설정ToolStripMenuItem.Text = "설정";
            // 
            // 폰트ToolStripMenuItem
            // 
            this.폰트ToolStripMenuItem.Name = "폰트ToolStripMenuItem";
            this.폰트ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.폰트ToolStripMenuItem.Text = "폰트";
            this.폰트ToolStripMenuItem.Click += new System.EventHandler(this.Handler_폰트toolStripMenuItemClick);
            // 
            // 배경색ToolStripMenuItem
            // 
            this.배경색ToolStripMenuItem.Name = "배경색ToolStripMenuItem";
            this.배경색ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.배경색ToolStripMenuItem.Text = "배경색";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(666, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 4;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 515);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chpater153);
            this.Controls.Add(this.chpater152);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form5";
            this.Text = "Form5";
            this.chpater152.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.myPlayer)).EndInit();
            this.chpater153.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox chpater152;
        private AxWMPLib.AxWindowsMediaPlayer myPlayer;
        private System.Windows.Forms.Button selectFileButton;
        private System.Windows.Forms.GroupBox chpater153;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 끝내기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 설정ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 폰트ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 배경색ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}