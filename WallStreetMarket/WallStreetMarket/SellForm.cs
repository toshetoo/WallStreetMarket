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
    public partial class SellForm : Form
    {
        public static int quanty;
        public static decimal earnedMoney;
        public SellForm()
        {
            InitializeComponent();
        }

        private void SellForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            try
            {
                int toSell = int.Parse(tbSell.Text);
                if (MarketForm.avaliableStock >= toSell)
                {
                    quanty = toSell;
                    earnedMoney = (toSell * MarketForm.currentPrice);
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("You dont have enough " + MarketForm.StockName + " to sell!");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, insert only numbers!");
            }
            catch (OverflowException)
            {
                MessageBox.Show("Number too big!");
            }
            tbSell.Clear();
        }
    }
}
