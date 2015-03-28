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
    public partial class LoanForm : Form
    {
        public static decimal loanTaken;
        public LoanForm()
        {
            InitializeComponent();
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            switch (BankForm.Loan)
            {
                case "Get Loan":
                    lblText.Text = "Get a loan";
                    btnPayGet.Text = "Get loan";
                    break;
                case "Pay Loan":
                    lblText.Text = "Pay your loan";
                    btnPayGet.Text = "Pay";
                    break;
                
            }
        }

        private void btnPayGet_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnPayGet.Text == "Get loan")
                {
                    loanTaken = Convert.ToDecimal(tbLoan.Text);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    if (BankForm.loanTaken <= decimal.Parse(tbLoan.Text))
                    {
                        loanTaken = decimal.Parse(tbLoan.Text);
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("You cant pay more than you have taken!");
                    }
                }
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number you have entered it too long!");
                tbLoan.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("You can input only digits!");
                tbLoan.Clear();
            }

        }
    }
}
