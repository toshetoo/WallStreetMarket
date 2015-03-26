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
    public partial class HighScoreForm : Form
    {
        //Creates a dictionary which contains the money of the player and the player name
        SortedDictionary<decimal, string> highScore = new SortedDictionary<decimal, string>();
        int counter = 1;
        public HighScoreForm()
        {
            InitializeComponent();
        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
            lblHighScore.BackColor = Color.Transparent;
            using (StreamReader sr = new StreamReader("Users.txt"))
            {
                string line;
                while ((line=sr.ReadLine()) != null)
                {
                    string[] splitted = line.Split(';');
                    Player player = new Player();

                    player.Name = splitted[2];
                    player.Dollar = decimal.Parse(splitted[3]);

                    //adds the player money and player name into a sorted dictionary
                    try
                    {
                        highScore.Add(player.Dollar, player.Name);
                    }
                    catch (ArgumentException)
                    {

                        do
                        {
                            //while the key exists, adds a very minimal sum to the money of the player
                            //so it wont recognize the same key
                            player.Dollar += 0.0000000001m;

                        } while (highScore.ContainsKey(player.Dollar));

                        highScore.Add(player.Dollar, player.Name);
                    }

                }
                
            }
            foreach (KeyValuePair<decimal, string> score in highScore.Reverse())
            {
                
                //This loop checks every pair money/name in the dictionary and prints it in a reversed order
                //because the sorted dictionary usually works from the smallest to the biggest
                if (counter == 10) //if 10 players are displayed, the loop will stop
                {
                    break;
                }
                else
                {
                    lblHighScore.Text += string.Format("\r\n \r\n{0}. {1:0.00}$ -> {2}", counter, score.Key, score.Value);
                    counter++;
                }
            }            
        }
    }
}
