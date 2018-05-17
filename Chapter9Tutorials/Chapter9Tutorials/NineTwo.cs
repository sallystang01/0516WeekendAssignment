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
    public partial class NineTwo : Form
    {
        public NineTwo()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a CellPhone object as an arguement
        // It assigns the data entered vby the user's to the object's properties.

        private void GetPhoneData(CellPhone phone)
        {
            // Temporary variable t ohold the price.
            decimal price;

            // Get the phone's brand

            phone.Brand = tbBrand.Text;

            // Get the phone's model.
            phone.Model = tbModel.Text;

            // Get the phone's price
            if (decimal.TryParse(tbPrice.Text, out price))
            {
                phone.Price = price;
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid price");
            }

        }
        private void tutorialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NineOne nineOne = new NineOne();

            this.Close();
            nineOne.Show();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // Create a CellPhone object
            CellPhone phone = new CellPhone();

            // Get the phone data.
            GetPhoneData(phone);

            // Display the phone data.
            tbBrandProp.Text = phone.Brand;
            tbModelProp.Text = phone.Model;
            tbPriceProp.Text = phone.Price.ToString();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NineTwo_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Takes the user back to the navigation form
            Navigation nav = new Navigation();

            nav.Show();
        }
    }
}
