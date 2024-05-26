using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Lab4
{
    public partial class Lab4_Bai04 : Form
    {
        public Lab4_Bai04()
        {
            InitializeComponent();
        }

        private void WebBrower1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl.SelectedTab.Text = webBrowser1.DocumentTitle;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            WebBrowser webTab = sender as WebBrowser;
            if (webTab != null)
            {
                tabControl.SelectedTab.Text = webTab.DocumentTitle;
            }
        }

        private void tb_url_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            ViewCode form = new ViewCode();
            form.MyProperty = client.DownloadString(tb_url.Text);
            form.Show();
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            Download form = new Download();
            form.MyProperty = tb_url.Text;
            form.Show();
        }

        private void btnTab_Click(object sender, EventArgs e)
        {
            TabPage tab = new TabPage();
            tab.Text = "New Tab";
            tabControl.Controls.Add(tab);
            tabControl.SelectTab(tabControl.TabCount - 1);

            WebBrowser webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate("http://www.google.com");
            tb_url.Text = "http://www.google.com";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void btnGo_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate(tb_url.Text);
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            webBrowser1.Navigate(tb_url.Text);
            webBrowser1.DocumentCompleted += WebBrower1_DocumentCompleted;
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void Lab4_Bai04_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("http://www.google.com");
            tb_url.Text = "http://www.google.com";
            webBrowser1.DocumentCompleted += WebBrower1_DocumentCompleted;
            webBrowser1.ScriptErrorsSuppressed = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }
    }
}
