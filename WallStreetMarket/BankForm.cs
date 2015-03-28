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
    public partial class BankForm : Form
    {
        Player currentPlayer = new Player();
        FileManager controler = new FileManager();
        List<Player> existingPlayers = new List<Player>();
        Random rand = new Random();
        int index;  

        public static string Loan;
        public static string Deposit;
        public static decimal loanTaken;
        public static decimal depositMade;
        public static decimal playerDollars;
        public static decimal playerEuro;
        public static decimal PlayerLeva;
        
        #region Buying Currency Prices
       public static double buyingEuro,
            buyingDollars,
            buyingLev;
        #endregion
        #region Selling Currency Prices
        public static double sellingEuro,
            sellingDollar,
            sellingLev;
        #endregion
        private void RecalculatePrices()
        {
            
            

            lblEuro.Text = string.Format("{0:0.00} {1}", currentPlayer.Euro, (char)128);
            lblDollar.Text = string.Format("{0:0.00} $", currentPlayer.Dollar);
            lblLev.Text = string.Format("{0:0.00} лв", currentPlayer.Lev);

            lblSellDollar.Text = string.Format("{0:0.00} $", sellingDollar);
            lblSellEuro.Text = string.Format("{0:0.00} {1}", sellingEuro,(char)128);
            lblSellLEv.Text = string.Format("{0:0.00} лв", sellingLev);

            lblBuyDollar.Text = string.Format("{0:0.00} $", buyingDollars);
            lblBuyEuro.Text = string.Format("{0:0.00} {1}", buyingEuro, (char)128);
            lblBuyLev.Text = string.Format("{0:0.00} лв", buyingLev);

            lblLoan.Text = string.Format("{0:0.00} $", currentPlayer.Loan);
            lblDeposit.Text = string.Format("{0:0.00} $", currentPlayer.Deposit);
        }
        public BankForm()
        {
            InitializeComponent();
        }

        private void BankForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            
            controler.ReadFromFile("Users.txt", existingPlayers);
            for (int i = 0; i < existingPlayers.Count; i++)
            {
                if (existingPlayers[i].Username == LoginForm.loggedPlayer)
                {
                    index = i;
                    controler.CreateCurrentPlayer(currentPlayer, existingPlayers, i); // creates the current player

                    if (ProfileForm.timerTicks != 0)
                    {
                        currentPlayer.Deposit = (currentPlayer.Deposit + (currentPlayer.Deposit * (1 / 100))) * ProfileForm.timerTicks;
                        currentPlayer.Loan = (currentPlayer.Loan + (currentPlayer.Loan * (3 / 100))) * ProfileForm.timerTicks;
                    }
                    
                    timer1_Tick(sender, e);
                    RecalculatePrices();//assign labels
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //gives the buying and selling variables some prices
            buyingDollars = rand.NextDouble() * (2.30 - 1.60) + 1.60;
            buyingEuro = rand.NextDouble() * (2.30 - 1.60) + 1.60;
            buyingLev = rand.NextDouble() * (2.30 - 1.60) + 1.60;

            sellingDollar = rand.NextDouble() * (2.30 - 1.60) + 1.60;
            sellingEuro = rand.NextDouble() * (2.30 - 1.60) + 1.60;
            sellingLev = rand.NextDouble() * (2.30 - 1.60) + 1.60;
            RecalculatePrices(); // assign labels again
        }

        private void BankForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            controler.PrepareToSave(currentPlayer, existingPlayers, index);
            controler.SaveGame(existingPlayers);
            this.DialogResult = DialogResult.OK;
        }

        private void btnExchange_Click(object sender, EventArgs e)
        {
            playerDollars = currentPlayer.Dollar;
            playerEuro = currentPlayer.Euro;
            PlayerLeva = currentPlayer.Lev;
            ExchangeForm exchange = new ExchangeForm();
            if (exchange.ShowDialog()==DialogResult.OK)
            {
                currentPlayer.Dollar = ExchangeForm.newDollars;
                currentPlayer.Euro = ExchangeForm.newEuro;
                currentPlayer.Lev = ExchangeForm.newLeva;
                controler.PrepareToSave(currentPlayer, existingPlayers, index);
                controler.SaveGame(existingPlayers);
            }
            
        }

        private void btnGetLoan_Click(object sender, EventArgs e)
        {
            Loan = "Get Loan";
            LoanForm loan = new LoanForm();
            if (loan.ShowDialog() == DialogResult.OK)
            {
                currentPlayer.Loan += LoanForm.loanTaken; //gives the player the current loan
                currentPlayer.Dollar += LoanForm.loanTaken;
                RecalculatePrices();
            }
        }

        private void btnPayLoan_Click(object sender, EventArgs e)
        {
            Loan = "Pay Loan";
            loanTaken = currentPlayer.Loan;
            LoanForm loan = new LoanForm();
            if (loan.ShowDialog() == DialogResult.OK)
            {
                currentPlayer.Loan -= LoanForm.loanTaken;//current player pays the price he entered from the loan
                currentPlayer.Dollar -= LoanForm.loanTaken;
                RecalculatePrices();
            }
        }

        private void btnGetDeposit_Click(object sender, EventArgs e)
        {
            Deposit = "Make";
            DepositForm deposit = new DepositForm();
            playerDollars = currentPlayer.Dollar;
            if (deposit.ShowDialog()==DialogResult.OK)
            {
                currentPlayer.Deposit += DepositForm.DepositMade;
                currentPlayer.Dollar -= DepositForm.DepositMade;
                RecalculatePrices();
            }
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            Deposit = "Withdraw";
            depositMade = currentPlayer.Deposit;
            DepositForm deposit = new DepositForm();
            if (deposit.ShowDialog()==DialogResult.OK)
            {
                currentPlayer.Deposit -= DepositForm.DepositMade;
                currentPlayer.Dollar += DepositForm.DepositMade;
                RecalculatePrices();
            }
        }

        
    }
}
