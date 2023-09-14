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
    public partial class Browser : Form
    {
        public Browser()
        {
            InitializeComponent();
        }

        // Function to perform website navigation based on text entry in 'searchBar'
        private void Navigation()
        {
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
    }
}
