using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azure_Browsers
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            BrowserMain container = new BrowserMain();

            container.Tabs.Add(
                new TitleBarTab(container)
                {
                    Content = new ExBrowser
                    {
                        Text = "New Tab"
                    }
                }
            );

            // Initial tab is set
            container.SelectedTabIndex = 0;

            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
            //Application.Run(new BrowserMain());
        }
    }
}
