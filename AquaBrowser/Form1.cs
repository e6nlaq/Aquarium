using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaBrowser
{
    public partial class window : Form
    {
        bool setting_autotitlereload = true;
        public window()
        {
            InitializeComponent();
            this.URLBox.Text = "https://www.google.com";
        }

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.URLBox.Text = this.browser.Url.ToString();
            if(setting_autotitlereload)
                this.Text = "Aquarium - " + this.browser.DocumentTitle;
        }

        private void Form1_TextChanged(object sender, EventArgs e)
        {
            this.browser.Navigate(this.URLBox.Text);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.browser.GoBack();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.browser.GoForward();
        }

        private void uRLUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.browser.Navigate(this.URLBox.Text);
            }
            catch { }
            
        }

        private void ホームHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.browser.Navigate("https://www.google.com");
        }

        private void 更新RToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.browser.Refresh();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquarium v1.0.1\n(C) e6nlaq 2023-","バージョン情報",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void オンYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting_autotitlereload = true;
            this.browser.Navigate(this.browser.Url);
        }

        private void オフNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setting_autotitlereload=false;
            this.Text = "Aquarium";
        }
    }
}
