using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;

namespace CromSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ChromiumWebBrowser chromiumWebBrowser;
        private void Form1_Load(object sender, EventArgs e)
        {
            urlText.Text = "https://google.com";
            chromiumWebBrowser = new ChromiumWebBrowser(urlText.Text);
            this.browserPanel.Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;
            chromiumWebBrowser.AddressChanged += AddressChanged;
            chromiumWebBrowser.TitleChanged += TitleChanged;
        }
        private void AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() => { urlText.Text = e.Address; favicon(); }));
        }
        private void TitleChanged(object sender, TitleChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() => { this.Text = e.Title; }));
        }
        public void favicon()
        {
            Uri url = new Uri("https://" + new Uri(chromiumWebBrowser.Address).Host + "/favicon.ico");
            try
            {
                Icon img = new Icon(new System.IO.MemoryStream(new
                WebClient().DownloadData(url)));
                this.Icon = img;
            }
            catch (Exception)
            {
                this.Icon = Properties.Resources.icon;
            }
        }

        private void urlText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                chromiumWebBrowser.Load(urlText.Text);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser.Reload();
        }

        private void forward_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser.CanGoForward)
            {
                chromiumWebBrowser.Forward();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if (chromiumWebBrowser.CanGoBack)
            {
                chromiumWebBrowser.Back();
            }
        }
    }
}
