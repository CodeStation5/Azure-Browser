using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Azure_Browsers
{
    public partial class BrowserMain : TitleBarTabs //Form
    {
        public BrowserMain()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        // Creates a new tab on click
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new ExBrowser
                {
                    Text = "New Tab"
                }
            };
        }
    }
}
        