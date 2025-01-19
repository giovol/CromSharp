using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using EasyTabs;

namespace CromSharp
{
    internal static class Program
    {
        /// <summary>
        /// Punto di ingresso principale dell'applicazione.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            AppContainer container = new AppContainer();
            container.Tabs.Add(new TitleBarTab(container)
            {
                Content = new Form1()
                {
                    Text = "New Tab"
                }
            });
            container.SelectedTabIndex = 0;
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
