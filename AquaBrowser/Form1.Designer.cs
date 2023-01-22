namespace AquaBrowser
{
    partial class window
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(window));
            this.URLBox = new System.Windows.Forms.TextBox();
            this.browser = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.移動ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uRLUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ホームHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.履歴HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.アクションAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.更新RToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.終了XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.バージョン情報VToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.設定SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.オンYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オフNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // URLBox
            // 
            this.URLBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.URLBox.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.URLBox.Location = new System.Drawing.Point(12, 33);
            this.URLBox.Name = "URLBox";
            this.URLBox.Size = new System.Drawing.Size(1579, 35);
            this.URLBox.TabIndex = 0;
            // 
            // browser
            // 
            this.browser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.browser.Location = new System.Drawing.Point(12, 74);
            this.browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(1438, 766);
            this.browser.TabIndex = 1;
            this.browser.Url = new System.Uri("https://www.google.com", System.UriKind.Absolute);
            this.browser.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.browser_Navigated);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.移動ToolStripMenuItem1,
            this.履歴HToolStripMenuItem,
            this.アクションAToolStripMenuItem,
            this.設定SToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1595, 38);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 移動ToolStripMenuItem1
            // 
            this.移動ToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.uRLUToolStripMenuItem,
            this.ホームHToolStripMenuItem});
            this.移動ToolStripMenuItem1.Name = "移動ToolStripMenuItem1";
            this.移動ToolStripMenuItem1.Size = new System.Drawing.Size(104, 34);
            this.移動ToolStripMenuItem1.Text = "移動(&M)";
            // 
            // uRLUToolStripMenuItem
            // 
            this.uRLUToolStripMenuItem.Name = "uRLUToolStripMenuItem";
            this.uRLUToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.uRLUToolStripMenuItem.Text = "URL(&U)";
            this.uRLUToolStripMenuItem.Click += new System.EventHandler(this.uRLUToolStripMenuItem_Click);
            // 
            // ホームHToolStripMenuItem
            // 
            this.ホームHToolStripMenuItem.Name = "ホームHToolStripMenuItem";
            this.ホームHToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.ホームHToolStripMenuItem.Text = "ホーム(&H)";
            this.ホームHToolStripMenuItem.Click += new System.EventHandler(this.ホームHToolStripMenuItem_Click);
            // 
            // 履歴HToolStripMenuItem
            // 
            this.履歴HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2});
            this.履歴HToolStripMenuItem.Name = "履歴HToolStripMenuItem";
            this.履歴HToolStripMenuItem.Size = new System.Drawing.Size(100, 34);
            this.履歴HToolStripMenuItem.Text = "履歴(&H)";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem1.Text = "戻る";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem2.Text = "進む";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // アクションAToolStripMenuItem
            // 
            this.アクションAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.更新RToolStripMenuItem,
            this.toolStripSeparator1,
            this.終了XToolStripMenuItem,
            this.バージョン情報VToolStripMenuItem});
            this.アクションAToolStripMenuItem.Name = "アクションAToolStripMenuItem";
            this.アクションAToolStripMenuItem.Size = new System.Drawing.Size(135, 34);
            this.アクションAToolStripMenuItem.Text = "アクション(&A)";
            // 
            // 更新RToolStripMenuItem
            // 
            this.更新RToolStripMenuItem.Name = "更新RToolStripMenuItem";
            this.更新RToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.更新RToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.更新RToolStripMenuItem.Text = "更新(&R)";
            this.更新RToolStripMenuItem.Click += new System.EventHandler(this.更新RToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(312, 6);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem3.Text = "終了(&X)";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem4.Text = "バージョン情報(&V)";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 終了XToolStripMenuItem
            // 
            this.終了XToolStripMenuItem.Name = "終了XToolStripMenuItem";
            this.終了XToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.終了XToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.終了XToolStripMenuItem.Text = "終了(&X)";
            this.終了XToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
            // 
            // バージョン情報VToolStripMenuItem
            // 
            this.バージョン情報VToolStripMenuItem.Name = "バージョン情報VToolStripMenuItem";
            this.バージョン情報VToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.バージョン情報VToolStripMenuItem.Text = "バージョン情報(&V)";
            this.バージョン情報VToolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 設定SToolStripMenuItem
            // 
            this.設定SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem5});
            this.設定SToolStripMenuItem.Name = "設定SToolStripMenuItem";
            this.設定SToolStripMenuItem.Size = new System.Drawing.Size(96, 34);
            this.設定SToolStripMenuItem.Text = "設定(&S)";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オンYToolStripMenuItem,
            this.オフNToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(315, 40);
            this.toolStripMenuItem5.Text = "タイトルの自動更新";
            // 
            // オンYToolStripMenuItem
            // 
            this.オンYToolStripMenuItem.Name = "オンYToolStripMenuItem";
            this.オンYToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.オンYToolStripMenuItem.Text = "オン(&Y)";
            this.オンYToolStripMenuItem.Click += new System.EventHandler(this.オンYToolStripMenuItem_Click);
            // 
            // オフNToolStripMenuItem
            // 
            this.オフNToolStripMenuItem.Name = "オフNToolStripMenuItem";
            this.オフNToolStripMenuItem.Size = new System.Drawing.Size(315, 40);
            this.オフNToolStripMenuItem.Text = "オフ(&N)";
            this.オフNToolStripMenuItem.Click += new System.EventHandler(this.オフNToolStripMenuItem_Click);
            // 
            // window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1595, 852);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.URLBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "window";
            this.Text = "Aquarium";
            this.TextChanged += new System.EventHandler(this.Form1_TextChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox URLBox;
        public System.Windows.Forms.WebBrowser browser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 移動ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem uRLUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ホームHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 履歴HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem アクションAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 更新RToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 終了XToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem バージョン情報VToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 設定SToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem オンYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オフNToolStripMenuItem;
    }
}

