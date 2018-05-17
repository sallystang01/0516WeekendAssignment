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
    public partial class NineSix : Form
    {
        public NineSix()
        {
            InitializeComponent();
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            // Creates an instance of the NutritionForm class.
            NineSixSecond nutriForm = new NineSixSecond();

            // Find the selected radio button
            if (rbBan.Checked)
            {
                nutriForm.tbFood.Text = "1 banana";
                nutriForm.tbCal.Text = "100";
                nutriForm.tbFat.Text = "0.4";
                nutriForm.tbCarbs.Text = "27";

            }

            else if (rbPop.Checked)
            {
                nutriForm.tbFood.Text = "1 cup air-popped popcorn";
                nutriForm.tbCal.Text = "31";
                nutriForm.tbFat.Text = "0.4";
                nutriForm.tbCarbs.Text = "6";
            }

            else if (rbMuffin.Checked)
            {
                nutriForm.tbFood.Text = "1 large blueberry muffin";
                nutriForm.tbCal.Text = "385";
                nutriForm.tbFat.Text = "9";
                nutriForm.tbCarbs.Text = "67";
            }

            // Display the form
            nutriForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NineSix_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Takes the user back to the navigation form
            Navigation nav = new Navigation();

            nav.Show();
        }
    }
}
