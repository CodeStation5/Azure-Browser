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
    public partial class ExBrowser : Form
    {
        public ExBrowser()
        {
            InitializeComponent();
        }

        protected TitleBarTabs TabParent
        {
            get
            {
                return (TabParent as TitleBarTabs);
            }
        }
    }
}
