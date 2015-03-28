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

    public partial class ExchangeForm : Form
    {
        public static decimal newDollars;
        public static decimal newLeva;
        public static decimal newEuro;

        decimal temp;
        public ExchangeForm()
        {
            InitializeComponent();
        }

        private void cbExchangeFrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbExchangeTo.Items.Clear();
            cbExchangeTo.Enabled = true;
            switch (cbExchangeFrom.SelectedIndex)
            {
                case 0:
                    cbExchangeTo.Items.Add("Dollar");
                    cbExchangeTo.Items.Add("Lev");
                    break;
                case 1:
                    cbExchangeTo.Items.Add("Euro");
                    cbExchangeTo.Items.Add("Lev");
                    break;
                case 2:
                    cbExchangeTo.Items.Add("Dollar");
                    cbExchangeTo.Items.Add("Euro");
                    break;
                default:
                    break;
            }
        }

        private void cbExchangeTo_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbQuantity.Enabled = true;
            switch (cbExchangeTo.SelectedItem.ToString())
            {
                case "Dollar":
                    lblPrice.Text = string.Format("{0:0.00} $", BankForm.buyingDollars);
                    break;
                case "Euro":
                    lblPrice.Text = string.Format("{0:0.00} $", BankForm.buyingEuro);
                    break;
                case "Lev":
                    lblPrice.Text = string.Format("{0:0.00} $", BankForm.buyingLev);
                    break;
                default:
                    break;
            }
        }

        private void cbExchangeTo_TextChanged(object sender, EventArgs e)
        {
            cbExchangeTo.ResetText();
        }

        private void cbExchangeFrom_TextChanged(object sender, EventArgs e)
        {
            cbExchangeFrom.ResetText();
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbExchangeFrom.Text != "" && cbExchangeTo.Text != "")
                {
                    if (cbExchangeFrom.SelectedItem.ToString() == "Euro" && cbExchangeTo.SelectedItem.ToString() == "Dollar")
                    {
                        if (BankForm.playerEuro > decimal.Parse(tbQuantity.Text))
                        {
                            BankForm.playerEuro -= decimal.Parse(tbQuantity.Text);
                            temp = decimal.Parse(tbQuantity.Text) * (decimal)BankForm.buyingDollars;
                            newDollars += temp;
                            MessageBox.Show(string.Format("You exchanged {0} euro and received {1:0.00} dollars!", tbQuantity.Text, temp));
                            btnExchange.Enabled = false;
                            tbQuantity.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("You dont have enough euro to trade!");
                        }
                    }
                    else if (cbExchangeFrom.SelectedItem.ToString() == "Euro" && cbExchangeTo.SelectedItem.ToString() == "Lev")
                    {
                        if (BankForm.playerEuro > decimal.Parse(tbQuantity.Text))
                        {
                            BankForm.playerEuro -= decimal.Parse(tbQuantity.Text);
                            temp += decimal.Parse(tbQuantity.Text) * (decimal)BankForm.buyingLev;
                            newLeva += temp;
                            MessageBox.Show(string.Format("You exchanged {0} euro and received {1:0.00} leva!", tbQuantity.Text, temp));
                            btnExchange.Enabled = false;
                            tbQuantity.Enabled = false;

                        }
                        else
                        {
                            MessageBox.Show("You dont have enough euro to trade!");
                        }
                    }
                    else if (cbExchangeFrom.SelectedItem.ToString() == "Dollar" && cbExchangeTo.SelectedItem.ToString() == "Lev")
                    {
                        if (BankForm.playerDollars > decimal.Parse(tbQuantity.Text))
                        {
                            BankForm.playerDollars -= decimal.Parse(tbQuantity.Text);
                            temp += decimal.Parse(tbQuantity.Text) * (decimal)BankForm.buyingLev;
                            newLeva += temp;
                            MessageBox.Show(string.Format("You exchanged {0} dollars and received {1:0.00} leva!", tbQuantity.Text, temp));
                            btnExchange.Enabled = false;
                            tbQuantity.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("You dont have enough dollars to trade!");
                        }
                    }
                    else if (cbExchangeFrom.SelectedItem.ToString() == "Dollar" && cbExchangeTo.SelectedItem.ToString() == "Euro")
                    {
                        if (BankForm.playerDollars > decimal.Parse(tbQuantity.Text))
                        {
                            BankForm.playerDollars -= decimal.Parse(tbQuantity.Text);
                            temp += decimal.Parse(tbQuantity.Text) * (decimal)BankForm.buyingEuro;
                            newEuro += temp;
                            MessageBox.Show(string.Format("You exchanged {0} dollars and received {1:0.00} euro!", tbQuantity.Text, temp));
                            btnExchange.Enabled = false;
                            tbQuantity.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("You dont have enough dollars to trade!");
                        }
                    }
                    else if (cbExchangeFrom.SelectedItem.ToString() == "Lev" && cbExchangeTo.SelectedItem.ToString() == "Dollar")
                    {
                        if (BankForm.PlayerLeva > decimal.Parse(tbQuantity.Text))
                        {
                            BankForm.PlayerLeva -= decimal.Parse(tbQuantity.Text);
                            temp += decimal.Parse(tbQuantity.Text) * (decimal)BankForm.buyingDollars;
                            newDollars += temp;
                            MessageBox.Show(string.Format("You exchanged {0} leva and received {1:0.00} dollars!", tbQuantity.Text, temp));
                            btnExchange.Enabled = false;
                            tbQuantity.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("You dont have enough leva to trade!");
                        }
                    }
                    else if (cbExchangeFrom.SelectedItem.ToString() == "Lev" && cbExchangeTo.SelectedItem.ToString() == "Euro")
                    {

                        if (BankForm.PlayerLeva > decimal.Parse(tbQuantity.Text))
                        {
                            BankForm.PlayerLeva -= decimal.Parse(tbQuantity.Text);
                            temp += decimal.Parse(tbQuantity.Text) * (decimal)BankForm.buyingEuro;
                            newEuro += temp;
                            MessageBox.Show(string.Format("You exchanged {0} leva and received {1:0.00} euro!", tbQuantity.Text, temp));
                            btnExchange.Enabled = false;
                            tbQuantity.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("You dont have enough leva to trade!");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Please, select currency from the combobox!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, insert only numbers!");
                tbQuantity.Clear();
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number you have entered is too big!");
                tbQuantity.Clear();
            }
        }

        private void ExchangeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            newEuro += BankForm.playerEuro;
            newDollars += BankForm.playerDollars;
            newLeva += BankForm.PlayerLeva;

            this.DialogResult = DialogResult.OK;
        }

        private void tbQuantity_TextChanged(object sender, EventArgs e)
        {
            btnExchange.Enabled = true;
        }
    }
}
