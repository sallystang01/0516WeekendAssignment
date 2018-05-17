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
    public partial class Navigation : Form
    {
        public Navigation()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

            // Exits the application
            Application.Exit();
        }

        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {

           // Hides navigation and displays tutorial
            NineOne frm91 = new NineOne();

            this.Hide();
            frm91.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits the application
            Application.Exit();
        }

        private void tutorialToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            NineTwo nineTwo = new NineTwo();

            this.Hide();
            nineTwo.Show();
        }

        private void tutorialToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            NineThree nineThree = new NineThree();

            this.Hide();
            nineThree.Show();
        }

        private void tutorialToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            NineFour nineFour = new NineFour();

            this.Hide();
            nineFour.Show();
        }

        private void tutorialToolStripMenuItem4_Click(object sender, EventArgs e)
        {

            // Displays form
            NineFiveFirst nine = new NineFiveFirst();

            this.Hide();
            nine.Show();
        }

        private void tutorialToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            NineSix nineSix = new NineSix();

            this.Hide();
            nineSix.Show();
        }
    }
}
