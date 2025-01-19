using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EasyTabs;
using CefSharp.WinForms;
using CefSharp;

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
            CefSettings settings = new CefSettings();
            Cef.Initialize(settings);
            urlText.Text = "https://google.com";
            chromiumWebBrowser = new ChromiumWebBrowser(urlText.Text);
            this.browserPanel.Controls.Add(chromiumWebBrowser);
            chromiumWebBrowser.Dock = DockStyle.Fill;
            chromiumWebBrowser.AddressChanged += AddressChanged;
        }
        private void AddressChanged(object sender, AddressChangedEventArgs e)
        {
            this.Invoke(new MethodInvoker(() => { urlText.Text = e.Address; }));
        }

        private void urlText_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                chromiumWebBrowser.Load(urlText.Text);
            }
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            chromiumWebBrowser.Refresh();
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
            if(chromiumWebBrowser.CanGoBack)
            {
                chromiumWebBrowser.Back();
            }
        }
    }
}
