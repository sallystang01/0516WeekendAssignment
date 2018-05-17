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
    public partial class NineThree : Form
    {
        public NineThree()
        {
            InitializeComponent();
        }

        // Bank account field with a $1000 starting balance
        private BankAccount account = new BankAccount(1000);

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NineThree_Load(object sender, EventArgs e)
        {
            // Display the starting balance.
            tbBalance.Text = account.Balance.ToString("c");
        }

        private void btnDeposit_Click(object sender, EventArgs e)
        {
            decimal amount; // To hold the amount of deposit

            // Convert the amount to a decimal.
            if (decimal.TryParse(tbDeposit.Text, out amount))
            {
                // Deposit the amount into the account.
                account.Deposit(amount);

                // Display the new balance.
                tbBalance.Text = account.Balance.ToString("c");

                // Clear the text box.
                tbDeposit.Clear();
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid amount");
            }
        }

        private void btnWithdrawal_Click(object sender, EventArgs e)
        {
            decimal amount; // To hold the amount of deposit

            // Convert the amount to a decimal.
            if (decimal.TryParse(tbWithdrawal.Text, out amount))
            {
                // Deposit the amount into the account.
                account.Withdraw(amount);

                // Display the new balance.
                tbBalance.Text = account.Balance.ToString("c");

                // Clear the text box.
                tbWithdrawal.Clear();
            }
            else
            {
                // Display an error message.
                MessageBox.Show("Invalid amount");
            }
        }

        private void NineThree_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Takes the user back to the navigation form
            Navigation nav = new Navigation();

            nav.Show();
        }
    }
}
