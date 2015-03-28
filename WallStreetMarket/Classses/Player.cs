using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallStreetMarket
{
    class Player
    {
        private string username;
        private string password;
        private string name;        
        private decimal euro;
        private decimal dollar;
        private decimal lev;
        private decimal loan;
        private decimal deposit;
        private string picture;
        private decimal gold;
        private decimal silver;
        private decimal assets;
        private decimal petrol;
        private decimal grain;
        private decimal tech;
        private int warehouseCapacity;

        public Player()
        {

        }
        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        public string Password 
        {
            get { return password; }
            set { password=value; } 
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Dollar
        {
            get { return dollar; }
            set { dollar = value; }
        }
        public decimal Euro
        {
            get { return euro; }
            set { euro = value; }
        }
        
        public decimal Lev
        {
            get { return lev; }
            set { lev = value; }
        }
        public decimal Loan
        {
            get { return loan; }
            set { loan = value; }
        }
        public decimal Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        public string Picture
        {
            get { return picture; }
            set { picture = value; }
        }
        public decimal Gold
        {
            get { return gold; }
            set { gold = value; }
        }
        public decimal Silver
        {
            get { return silver; }
            set { silver = value; }
        }
        public decimal Assets
        {
            get { return assets; }
            set { assets = value; }
        }
        public decimal Petrol
        {
            get { return petrol; }
            set { petrol = value; }
        }
        public decimal Technology
        {
            get { return tech; }
            set { tech = value; }
        }
        public decimal Grain
        {
            get { return grain; }
            set { grain = value; }
        }
        public int WarehouseCapacity
        {
            get { return warehouseCapacity; }
            set { warehouseCapacity = value; }
        }
    }
}
