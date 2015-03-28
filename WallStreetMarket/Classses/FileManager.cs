using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallStreetMarket.Classses;

namespace WallStreetMarket
{
    class FileManager
    {
        
        public void ReadFromFile(string fileName, List<Player> list)
        {
            try
            {
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        Player player = new Player();
                        string[] splitted = line.Split(';');
                        player.Username = splitted[0];
                        player.Password = splitted[1];
                        player.Name = splitted[2];
                        player.Dollar = decimal.Parse(splitted[3]);
                        player.Euro = decimal.Parse(splitted[4]);
                        player.Lev = decimal.Parse(splitted[5]);
                        player.Loan = decimal.Parse(splitted[6]);
                        player.Deposit = decimal.Parse(splitted[7]);
                        player.Picture = splitted[8];
                        player.Gold = decimal.Parse(splitted[9]);
                        player.Silver = decimal.Parse(splitted[10]);
                        player.Assets = decimal.Parse(splitted[11]);
                        player.Petrol = decimal.Parse(splitted[12]);
                        player.Technology = decimal.Parse(splitted[13]);
                        player.Grain = decimal.Parse(splitted[14]);
                        player.WarehouseCapacity = int.Parse(splitted[15]);


                        list.Add(player);
                    }
                }
            }
            catch (FileNotFoundException)
            {
                System.Windows.Forms.MessageBox.Show("FileNotFound");
            }
            catch (IndexOutOfRangeException)
            {
                System.Windows.Forms.MessageBox.Show("Out of range");
            }
        }

        public void ReadUsernames(string fileName, List<string> usernames)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitted = line.Split(';');
                    usernames.Add(splitted[0]);
                }
            }
        }
        public void ReadPasswords(string fileName, Dictionary<string, string> playerPasswords)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] splitted = line.Split(';');
                    playerPasswords.Add(splitted[0], splitted[1]);
                }
            }
        }
        public void SaveGame(List<Player> existingPlayers)
        {
            using (StreamWriter sw = new StreamWriter("Users.txt"))
            {
                for (int i = 0; i < existingPlayers.Count; i++)
                {
                    sw.WriteLine(
                        existingPlayers[i].Username + ";" +
                        existingPlayers[i].Password + ";" +
                        existingPlayers[i].Name + ";" +
                        existingPlayers[i].Dollar + ";" +
                        existingPlayers[i].Euro + ";" +
                        existingPlayers[i].Lev + ";" +
                        existingPlayers[i].Loan + ";" +
                        existingPlayers[i].Deposit + ";" +
                        existingPlayers[i].Picture + ";" +
                        existingPlayers[i].Gold + ";" +
                        existingPlayers[i].Silver + ";" +
                        existingPlayers[i].Assets + ";" +
                        existingPlayers[i].Petrol + ";" +
                        existingPlayers[i].Technology + ";" +
                        existingPlayers[i].Grain + ";" +
                        existingPlayers[i].WarehouseCapacity
                        );
                }
            }
        }        

        public void CreateCurrentPlayer(Player currentPlayer,List<Player> existingPlayers, int index)
        {
            currentPlayer.Username = LoginForm.loggedPlayer;
            currentPlayer.Name = existingPlayers[index].Name;
            currentPlayer.Password = existingPlayers[index].Password;
            currentPlayer.Assets = existingPlayers[index].Assets;
            currentPlayer.WarehouseCapacity = existingPlayers[index].WarehouseCapacity;
            currentPlayer.Gold = existingPlayers[index].Gold;
            currentPlayer.Euro = existingPlayers[index].Euro;
            currentPlayer.Lev = existingPlayers[index].Lev;
            currentPlayer.Loan = existingPlayers[index].Loan;
            currentPlayer.Deposit = existingPlayers[index].Deposit;
            currentPlayer.Grain = existingPlayers[index].Grain;
            currentPlayer.Dollar = existingPlayers[index].Dollar;
            currentPlayer.Petrol = existingPlayers[index].Petrol;
            currentPlayer.Silver = existingPlayers[index].Silver;
            currentPlayer.Technology = existingPlayers[index].Technology;
            currentPlayer.Picture = existingPlayers[index].Picture;
        }
        public void PrepareToSave(Player currentPlayer, List<Player> existingPlayers, int index)
        {
            existingPlayers[index].Username = LoginForm.loggedPlayer;
            existingPlayers[index].Name = currentPlayer.Name;
            existingPlayers[index].Password = currentPlayer.Password;
            existingPlayers[index].Assets = currentPlayer.Assets;
            existingPlayers[index].WarehouseCapacity = currentPlayer.WarehouseCapacity;
            existingPlayers[index].Gold = currentPlayer.Gold;
            existingPlayers[index].Grain = currentPlayer.Grain;
            existingPlayers[index].Dollar = currentPlayer.Dollar;
            existingPlayers[index].Euro = currentPlayer.Euro;
            existingPlayers[index].Lev = currentPlayer.Lev;
            existingPlayers[index].Loan = currentPlayer.Loan;
            existingPlayers[index].Deposit = currentPlayer.Deposit;
            existingPlayers[index].Petrol = currentPlayer.Petrol;
            existingPlayers[index].Silver = currentPlayer.Silver;
            existingPlayers[index].Technology = currentPlayer.Technology;
            existingPlayers[index].Picture = currentPlayer.Picture;
        }
        public void GetLucks(List<string> lucks)
        {
            using (StreamReader sr = new StreamReader("lucks.txt"))
            {
                string line;
                while ((line=sr.ReadLine())!=null)
                {
                    lucks.Add(line);
                }
            }
        }
        public void LoadSongs(List<Song> existingSongs,ListBox lb)
        {
            using (StreamReader sr = new StreamReader("Songs.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Song song = new Song();
                    song.Path = line;

                    int index = line.LastIndexOf('\\');                    
                    string name = line.Substring(index+1);
                    song.Name = name;

                    existingSongs.Add(song);
                    lb.Items.Add(song.Name);
                }
            }
        }
        public void LoadSongs(List<Song> existingSongs)
        {
            using (StreamReader sr = new StreamReader("Songs.txt"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    Song song = new Song();
                    song.Path = line;

                    //takes the name of the song from the path
                    int index = line.LastIndexOf('\\');
                    string name = line.Substring(index+1);
                    song.Name = name;

                    existingSongs.Add(song);                    
                }
            }
        }
        public void SaveSongs(List<Song> existingSongs)
        {
            using (StreamWriter sw = new StreamWriter("Songs.txt"))
            {
                for (int i = 0; i < existingSongs.Count; i++)
                {
                    sw.WriteLine(existingSongs[i].Path);
                }
            }
        }
    }
}
