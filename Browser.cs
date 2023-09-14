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
    public partial class Browser : TitleBarTabs //Form
    {
        public Browser()
        {
            InitializeComponent();

            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
            Icon = mBible.Properties.Resources.appico;
        }

        // Creates a new tab on click
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new Form1
                {
                    Text = "New Tab"
                }
            };
        }
        





        // Function to perform website navigation based on text entry in 'searchBar'
        private void Navigation()
        {
            searchBar.Enabled = false;
            button1.Enabled = false;
            progessBarLabel1.Text = "Navigating...";
            webBrowser1.Navigate(searchBar.Text);
        }

        // Closes program from toolbar (File>Exit)
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // When search button clicked, web browser will navigate to the website entered
        private void button1_Click(object sender, EventArgs e)
        {
            Navigation();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        // Functions runs to activate navigation on search bar when 'enter' pressed
        private void searchBar_KeyPress(object sender, KeyPressEventArgs e)
        {
            // If 'enter' key pressed, continue
            if (e.KeyChar == (char)ConsoleKey.Enter) 
            {
                Navigation();
            }
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            searchBar.Enabled = true;
            button1.Enabled = true;
            progessBarLabel1.Text = "Navigation Complete";
        }

        private void webBrowser1_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            if (e.CurrentProgress > 0 && e.MaximumProgress > 0)
            {
                progressBar.ProgressBar.Value = (int)(e.CurrentProgress * 100 / e.MaximumProgress);
            }
        }

        private void progessBarLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}
