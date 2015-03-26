using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallStreetMarket
{
    public partial class MarketForm : Form
    {
        FileManager controler = new FileManager();
        Player currentPlayer = new Player();
        List<Player> existingPlayers = new List<Player>();
        Random rand = new Random();

        int ticks;
        int index;

        #region Warehouse
        public static int freeCapacity;
        public static int avaliableStock;
        int currentStock;
        int warehouseLevel = 0;
        #endregion
        #region GeneratePrices
        double goldPrice,
            silverPrice,
            grainPrice,
            petrolPrice,
            assetsPrice,
            technologyPrice;
        #endregion
        #region BuyingPrices
        double buyingGoldPrice,
            buyingSilverPrice,
            buyingAssetsPrice,
            buyingGrainPrice,
            buyingPetrolPrice,
            buyingTechPrice;
        #endregion

        public static decimal playerMoney;
        public static string StockName;
        public static decimal currentPrice;

        public MarketForm()
        {
            InitializeComponent();
        }

        public void InitializeGame(int i)
        {
            controler.CreateCurrentPlayer(currentPlayer, existingPlayers, i);

            CalculateCurrentStock(); //calculates the warehouse stock
            CheckWarehouseLevel(); // checks the warehouse level of the player by its capacity
            ReloadContent(); //refreshes labels
            CalculatePlayerMoney();//checks the player "level" and decides which stocks can be traded

            lblUsedSpace.Text = currentStock.ToString();
            lblFreeSpace.Text = freeCapacity.ToString();
        }
        public void CalculatePlayerMoney()
        {
            if (currentPlayer.Dollar<50000m)
            {
                if (currentPlayer.Technology == 0 && currentPlayer.Petrol == 0 && currentPlayer.Assets == 0 && currentPlayer.Gold == 0 && currentPlayer.Silver == 0)
                {
                    //allow only grain
                    btnBuyGold.Visible = false;
                    btnSellGold.Visible = false;
                    btnBuyPetrol.Visible = false;
                    btnSellPetrol.Visible = false;
                    btnBuySilver.Visible = false;
                    btnSellSilver.Visible = false;
                    btnBuyTech.Visible = false;
                    btnSellTech.Visible = false;
                    button4.Visible = false;
                    btnSellAssets.Visible = false;
                }
            }
            else if (currentPlayer.Dollar >=50000m && currentPlayer.Dollar<150000m)
            {
                if (currentPlayer.Technology == 0 && currentPlayer.Petrol == 0 && currentPlayer.Assets == 0 && currentPlayer.Gold == 0)
                {
                    //grain and silver
                    btnBuySilver.Visible = true;
                    btnSellSilver.Visible = true;

                    btnBuyGold.Visible = false;
                    btnSellGold.Visible = false;
                    btnBuyPetrol.Visible = false;
                    btnSellPetrol.Visible = false;
                    btnBuyTech.Visible = false;
                    btnSellTech.Visible = false;
                    button4.Visible = false;
                    btnSellAssets.Visible = false;
                }
            }
            else if (currentPlayer.Dollar>=150000m && currentPlayer.Dollar <250000m)
            {
                if (currentPlayer.Technology == 0 && currentPlayer.Petrol == 0 && currentPlayer.Assets == 0)
                {
                    //grain, silver, gold
                    btnBuyGold.Visible = true;
                    btnSellGold.Visible = true;

                    btnBuyPetrol.Visible = false;
                    btnSellPetrol.Visible = false;
                    btnBuyTech.Visible = false;
                    btnSellTech.Visible = false;
                    button4.Visible = false;
                    btnSellAssets.Visible = false;
                }
            }
            else if (currentPlayer.Dollar>=250000m && currentPlayer.Dollar <350000m)
            {
                if (currentPlayer.Technology == 0 && currentPlayer.Petrol == 0)
                {
                    //grain,silver,gold, assets
                    button4.Visible = true;
                    btnSellAssets.Visible = true;

                    btnBuyPetrol.Visible = false;
                    btnSellPetrol.Visible = false;
                    btnBuyTech.Visible = false;
                    btnSellTech.Visible = false;
                }
            }
            else if (currentPlayer.Dollar >=350000m && currentPlayer.Dollar<500000m)
            {
                if (currentPlayer.Technology==0)
                {
                    //grain, silver, gold, assets, petrol
                    btnBuyPetrol.Visible = true;
                    btnSellPetrol.Visible = true;

                    btnBuyTech.Visible = false;
                    btnSellTech.Visible = false; 
                }
                
            }
            else
            {
                //all allowed
                btnBuyTech.Visible = true;
                btnSellTech.Visible = true; 
            }
        }
        private void Sell(double price, decimal stock, Label lbl)
        {
            timer1.Stop();
            timer2.Stop();

            CalculateCurrentStock();
            playerMoney = currentPlayer.Dollar;
            currentPrice = (decimal)price;
            avaliableStock = (int)stock;

            SellForm sellForm = new SellForm();
            if (sellForm.ShowDialog() == DialogResult.OK)
            {
                stock -= (decimal)SellForm.quanty;
                avaliableStock = (int)stock;
                currentPlayer.Dollar += SellForm.earnedMoney;
                lblMoney.Text = string.Format("{0:0.00} $", currentPlayer.Dollar);
                lbl.Text = stock.ToString();

                timer2.Start();
                timer1.Start();
            }
            timer2.Start();
            timer1.Start();
        }
        private void Buy(double price, decimal stock, Label lbl)
        {
            timer1.Stop();
            timer2.Stop();

            CalculateCurrentStock(); // recalculates all the stock in the warehouse

            playerMoney = currentPlayer.Dollar; //passing variable to check if the player has enough money
            currentPrice = (decimal)price; //passing variable to calculate the total amount of money needed for the new stock
            avaliableStock = (int)stock; // passing variable to check if the player has enough space in warehouse

            BuyForm buyForm = new BuyForm();
            if (buyForm.ShowDialog() == DialogResult.OK)
            {
                stock += BuyForm.quanty;//quanty is the count of items the player bought
                avaliableStock = (int)stock;
                currentPlayer.Dollar -= BuyForm.spentMoney;
                lbl.Text = stock.ToString();
                CalculateCurrentStock();

            }
            timer2.Start();
            timer1.Start();
        }

        private void CalculateCurrentStock()
        {
            currentStock = (int)(currentPlayer.Gold + currentPlayer.Assets + currentPlayer.Grain + currentPlayer.Petrol + currentPlayer.Silver + currentPlayer.Technology);
            freeCapacity = currentPlayer.WarehouseCapacity - currentStock;
            lblFreeSpace.Text = freeCapacity.ToString();
            lblUsedSpace.Text = currentStock.ToString();
            lblCapacity.Text = currentPlayer.WarehouseCapacity.ToString();
            lblMoney.Text = string.Format("{0:0.00} $", currentPlayer.Dollar);
        }

        public void ReloadContent()
        {
            //refreshes the labels
            lblAssetsContent.Text = currentPlayer.Assets.ToString();
            lblCapacity.Text = currentPlayer.WarehouseCapacity.ToString();
            lblGoldContent.Text = currentPlayer.Gold.ToString();
            lblGrainContent.Text = currentPlayer.Grain.ToString();
            lblMoney.Text = string.Format("{0:0.00} $", currentPlayer.Dollar);
            lblPetrolContent.Text = currentPlayer.Petrol.ToString();
            lblSilverContent.Text = currentPlayer.Silver.ToString();
            lblTechContent.Text = currentPlayer.Technology.ToString();
        }

        private void GeneratePrice(double stockPrice, double buyingPrice, Label lbl)
        {

            if (stockPrice <= buyingPrice)
            {
                lbl.ForeColor = Color.Red;
            }
            else
            {
                lbl.ForeColor = Color.Green;
            }

            lbl.Text = string.Format("{0:0.00} $", stockPrice);
        }

        private void CheckWarehouseLevel()
        {
            switch (currentPlayer.WarehouseCapacity)
            {
                case 200: warehouseLevel = 0; break;
                case 400: warehouseLevel = 1; break;
                case 800: warehouseLevel = 2; break;
                case 1600: warehouseLevel = 3; break;
                case 3000: warehouseLevel = 4; break;
                case 5000: warehouseLevel = 5; break;
                case 10000: warehouseLevel = 6; break;
            }
        }

        private void UpgradeWarehouse(int warehousePrice, int newCapacity)
        {
            if (MessageBox.Show("Level " + (warehouseLevel + 1) + " will cost " + warehousePrice + "$. Do you want to upgrade?", "Are you sure?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (currentPlayer.Dollar >= warehousePrice)
                {
                    currentPlayer.Dollar -= warehousePrice;
                    currentPlayer.WarehouseCapacity = newCapacity;
                    CalculateCurrentStock();
                    warehouseLevel++;
                }
                else
                {
                    MessageBox.Show("You dont have enough money!");
                }
            }
        }

        private void Market_Load(object sender, EventArgs e)
        {
            btn_getYourLuck.Visible = false;
            this.Text = "Market - Hello, " + LoginForm.loggedPlayer;
            controler.ReadFromFile("Users.txt", existingPlayers);
            for (int i = 0; i < existingPlayers.Count; i++)
            {
                if (existingPlayers[i].Username == LoginForm.loggedPlayer)
                {
                    //creates current player and gets his stats
                    InitializeGame(i);
                    index = i;
                }
            }
            timer1_Tick(sender, e);
            timer2_Tick(sender, e);
            timer1.Start();
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (ticks==15)
            {
                MessageBox.Show("Luck time! You can now test your luck!");
                btn_getYourLuck.Visible = true;
            }
            //NextDouble generates number between 0.0 and 1.0, so we multiply it with max and min price
            goldPrice = rand.NextDouble() * (81.0 - 30.0) + 30.0;
            GeneratePrice(goldPrice, buyingGoldPrice, lblGoldPrice);

            silverPrice = rand.NextDouble() * (51.0 - 30.0) + 30.0;
            GeneratePrice(silverPrice, buyingSilverPrice, lblSilverPrice);

            technologyPrice = rand.NextDouble() * (251.0 - 100.0) + 100.0;
            GeneratePrice(technologyPrice, buyingTechPrice, lblTechnologyPrice);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //NextDouble generates number between 0.0 and 1.0, so we multiply it with max and min price
            assetsPrice = rand.NextDouble() * (101.0 - 10.0) + 101.0;
            GeneratePrice(assetsPrice, buyingAssetsPrice, lblAssetsPrice);

            grainPrice = rand.NextDouble() * (21.0 - 5.0) + 5.0;
            GeneratePrice(grainPrice, buyingGrainPrice, lblGrainPrice);

            petrolPrice = rand.NextDouble() * (201.0 - 100.0) + 100.0;
            GeneratePrice(petrolPrice, buyingPetrolPrice, lblPetrolPrice);
        }   

        private void btnBuyGold_Click(object sender, EventArgs e)
        {
            Buy(goldPrice, currentPlayer.Gold, lblGoldContent);
            buyingGoldPrice = goldPrice;
            currentPlayer.Gold = avaliableStock;
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Buy(assetsPrice, currentPlayer.Assets, lblAssetsContent);
            buyingAssetsPrice = assetsPrice;
            currentPlayer.Assets = avaliableStock;
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnBuyPetrol_Click(object sender, EventArgs e)
        {
            Buy(petrolPrice, currentPlayer.Petrol, lblPetrolContent);
            buyingPetrolPrice = petrolPrice;
            currentPlayer.Petrol = avaliableStock;
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnBuySilver_Click(object sender, EventArgs e)
        {
            Buy(silverPrice, currentPlayer.Silver, lblSilverContent);
            buyingSilverPrice = silverPrice;
            currentPlayer.Silver = avaliableStock;
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnBuyGrain_Click(object sender, EventArgs e)
        {
            Buy(grainPrice, currentPlayer.Grain, lblGrainContent);
            buyingGrainPrice = grainPrice;
            currentPlayer.Grain = avaliableStock;
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnBuyTech_Click(object sender, EventArgs e)
        {
            Buy(technologyPrice, currentPlayer.Technology, lblTechContent);
            buyingTechPrice = technologyPrice;
            currentPlayer.Technology = avaliableStock;
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnSellGold_Click(object sender, EventArgs e)
        {
            Sell(goldPrice, currentPlayer.Gold, lblGoldContent);
            currentPlayer.Gold = avaliableStock;
            if (currentPlayer.Gold == 0)
            {
                buyingGoldPrice = 0;
            }
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnSellAssets_Click(object sender, EventArgs e)
        {
            Sell(assetsPrice, currentPlayer.Assets, lblAssetsContent);
            currentPlayer.Assets = avaliableStock;
            if (currentPlayer.Assets == 0)
            {
                buyingAssetsPrice = 0;
            }
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnSellPetrol_Click(object sender, EventArgs e)
        {
            Sell(petrolPrice, currentPlayer.Petrol, lblPetrolContent);
            currentPlayer.Petrol = avaliableStock;
            if (currentPlayer.Petrol == 0)
            {
                buyingPetrolPrice = 0;
            }
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnSellSilver_Click(object sender, EventArgs e)
        {
            Sell(silverPrice, currentPlayer.Silver, lblSilverContent);
            currentPlayer.Silver = avaliableStock;
            if (currentPlayer.Silver == 0)
            {
                buyingSilverPrice = 0;
            }
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnSellGrain_Click(object sender, EventArgs e)
        {
            Sell(grainPrice, currentPlayer.Grain, lblGrainContent);
            currentPlayer.Grain = avaliableStock;
            if (currentPlayer.Grain == 0)
            {
                buyingGrainPrice = 0;
            }
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnSellTech_Click(object sender, EventArgs e)
        {
            Sell(technologyPrice, currentPlayer.Technology, lblTechContent);
            currentPlayer.Technology = avaliableStock;

            //checks if there is any stock left, else turns the buying price to 0
            if (currentPlayer.Technology == 0) 
            {
                buyingTechPrice = 0;
            }
            CalculateCurrentStock();
            CalculatePlayerMoney();
        }

        private void btnUpgrade_Click(object sender, EventArgs e)
        {
            switch (warehouseLevel)
            {
                case 0:
                    UpgradeWarehouse(1500, 400);
                    break;
                case 1:
                    UpgradeWarehouse(5000, 800);
                    break;
                case 2:
                    UpgradeWarehouse(10000, 1600);
                    break;
                case 3:
                    UpgradeWarehouse(25000, 3000);
                    break;
                case 4:
                    UpgradeWarehouse(75000, 5000);
                    break;
                case 5:
                    UpgradeWarehouse(100000, 10000);
                    break;
                default:
                    warehouseLevel = 6;
                    MessageBox.Show("Maximum level of warehouse reached!");
                    break;
            }
        }

        private void MarketForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //updates the list of players with the current player stats
            controler.PrepareToSave(currentPlayer, existingPlayers, index);
            controler.SaveGame(existingPlayers);
            MessageBox.Show("Game saved!");
            this.DialogResult = DialogResult.OK;
            this.Dispose();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_getYourLuck_Click(object sender, EventArgs e)
        {
            List<string> lucks = new List<string>();
            controler.GetLucks(lucks);
            Random lucksRandom = new Random();
            int luckNumber = lucksRandom.Next(0, (lucks.Count + 1)); //use it as index in the list
            

            switch (luckNumber)
            {
                case 0:
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar += 10000;
                    ReloadContent();
                    break;
                case 1:
                case 6:
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar = 0;
                    ReloadContent();
                    break;
                case 2:
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar += 1000;
                    ReloadContent();
                    break;
                case 3:
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar -= 20000;
                    ReloadContent(); 
                    break;
                case 4:
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar += 25000;
                    ReloadContent();
                    break;
                case 5:
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar = currentPlayer.Dollar / 2;
                    ReloadContent();
                    break;
                case 7:
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar -= 37000;
                    ReloadContent();
                    break;
                case 8: 
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    break;
                case 9: 
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar -= 15000;
                    ReloadContent();
                    break;
                case 10:
                    MessageBox.Show(lucks[luckNumber], "Your luck");
                    currentPlayer.Dollar += 10000;
                    ReloadContent();
                    break;
            }
            ticks = 0;
            btn_getYourLuck.Visible = false;
        }
    }
}