using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AquaBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.URLBox.Text = "https://www.google.com";
        }

        private void browser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            this.URLBox.Text = this.browser.Url.ToString();
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
            this.browser.Navigate(this.URLBox.Text);
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
    }
}
