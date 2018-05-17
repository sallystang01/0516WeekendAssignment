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
    public partial class NineFour : Form
    {
        // List to hold CellPhone objects
        List<CellPhone> phoneList = new List<CellPhone>();

        public NineFour()
        {
            InitializeComponent();
        }

        // The GetPhoneData method accepts a cellphone obejct
        // as an argument. It assigns the data entered by the
        // user to the object's properties.

            private void GetPhoneData(CellPhone phone)
        {
            // Temp variable to hold the price.
            decimal price;

            // Get the phone's brand.
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
                // Display an error message
                MessageBox.Show("Invalid price");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbPhone_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the index of the selected item.
            int index = lbPhone.SelectedIndex;

            // Display the selected item's price.
            MessageBox.Show(phoneList[index].Price.ToString("c"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create a cellphone object.
            CellPhone myPhone = new CellPhone();

            // Get the phone data.
            GetPhoneData(myPhone);

            // Add the CellPhone object to the list.
            phoneList.Add(myPhone);

            // Add an entry to the list box.
            lbPhone.Items.Add(myPhone.Brand + " " + myPhone.Model);

            // Clear the TextBox controls
            tbBrand.Clear();
            tbModel.Clear();
            tbPrice.Clear();

            // Reset the focus.
            tbBrand.Focus();

        }

        private void NineFour_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Takes the user back to the navigation form
            Navigation nav = new Navigation();

            nav.Show();
        }
    }
}
