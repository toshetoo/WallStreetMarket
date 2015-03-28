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
    
    public partial class BuyForm : Form
    {
        public static int quanty;
        public static decimal spentMoney;
        public BuyForm()
        {
            InitializeComponent();
        }

        private void BuyForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                int toBuy = int.Parse(tbQuanty.Text);
                if (tbQuanty.Text != "")
                {
                    if (MarketForm.freeCapacity >= toBuy)
                    {
                        if ((toBuy * MarketForm.currentPrice) < MarketForm.playerMoney)
                        {
                            quanty = toBuy;
                            spentMoney = (quanty * MarketForm.currentPrice);
                            this.DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show("Not enough money!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Not enough space in warehouse!");
                    }
                }
                else
                {
                    MessageBox.Show("Insert quanty!");
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
            tbQuanty.Clear();
        }
    }
}
