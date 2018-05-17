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
    public partial class NineOne : Form
    {
        public NineOne()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }

        private void btnToss_Click(object sender, EventArgs e)
        {
            // Create a coin object
            Coin myCoin = new Coin();

            // Clear the listbox.
            lbOutput.Items.Clear();

            // Toss the coin five times
            for (int count = 0; count < 5; count++)
            {
                // Toss the coin.
                myCoin.Toss();

                // Display the side that is up.
                lbOutput.Items.Add(myCoin.GetSideUp());
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits application
            this.Close();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NineTwo nineTwo = new NineTwo();

            this.Close();
            nineTwo.Show();
        }

        private void NineOne_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Takes the user back to the navigation form
            Navigation nav = new Navigation();

            nav.Show();
        }
    }
}
