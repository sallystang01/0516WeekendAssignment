using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9Tutorials
{
    public partial class NineFiveFirst : Form
    {
        public NineFiveFirst()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            NineFive nineFive = new NineFive();

            
            nineFive.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NineFiveFirst_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Takes the user back to the navigation form
            Navigation nav = new Navigation();

            nav.Show();
        }
    }
}
