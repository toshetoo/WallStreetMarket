using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallStreetMarket
{
    public partial class DepositForm : Form
    {
        public static decimal DepositMade;
        public DepositForm()
        {
            InitializeComponent();
        }

        private void DepositForm_Load(object sender, EventArgs e)
        {
            switch (BankForm.Deposit)
            {
                case "Make":
                    lblText.Text = "Make a deposit";
                    btnPayGet.Text = " Save money";
                    break;
                case "Withdraw":
                    lblText.Text = "Withdraw money";
                    btnPayGet.Text = "Withdraw";
                    break;
            }
        }

        private void btnPayGet_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnPayGet.Text == "Withdraw")
                {
                    if (decimal.Parse(tbDeposit.Text) <= BankForm.depositMade)
                    {
                        DepositMade = decimal.Parse(tbDeposit.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("You dont have enough money in the bank!");
                    }
                }
                else
                {
                    if (BankForm.playerDollars >= decimal.Parse(tbDeposit.Text))
                    {
                        DepositMade = decimal.Parse(tbDeposit.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("You dont have enough money!");
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number you have entered is too long!");
                tbDeposit.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("You can input only digits!");
                tbDeposit.Clear();
            }

        }
    }
}
