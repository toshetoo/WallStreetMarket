using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using NAudio;
using NAudio.Wave;
using WallStreetMarket.Classses;

namespace WallStreetMarket
{
    public partial class ProfileForm : Form
    {
        BankForm bank;
        FileManager controler = new FileManager();
        List<Player> existingPlayers = new List<Player>();
        Player currentPlayer = new Player();
        Dictionary<string, string> playerPasswords = new Dictionary<string, string>();
       
        #region Audio
        IWavePlayer waveOutDevice;
        AudioFileReader audioFileReader;
        List<Song> existingSongs = new List<Song>();
        Random rnd = new Random();

        public static float currentVolume;
        #endregion

        int index;
        int currentStock;

        public static string CurrentPassword;
        public static int timerTicks;
        public ProfileForm()
        {
            InitializeComponent();
        }
        private void InitializeMusic(List<Song> existingSongs)
        {
            
            //checks if the reader has been started. If its not, then in takes a random song and starts the playing
            if (audioFileReader == null)
            {
                int index = rnd.Next(0, existingSongs.Count);
                waveOutDevice = new WaveOut();
                //plays the current song from the music directory, no full path needed
                audioFileReader = new AudioFileReader("Music\\"+existingSongs[index].Name); 
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }
            //if the reader has been started, checks the current time. If its on the end, takes another song on random again
            else if (audioFileReader.CurrentTime == audioFileReader.TotalTime)
            {
                int index = rnd.Next(0, existingSongs.Count);
                waveOutDevice = new WaveOut();
                audioFileReader = new AudioFileReader(existingSongs[index].Path);
                waveOutDevice.Init(audioFileReader);
                waveOutDevice.Play();
            }            
        }
        private void CloseWaveOut()
        {
            //releases all resources
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
            }
            if (audioFileReader != null)
            {
                audioFileReader.Dispose();
                audioFileReader = null;
            }
            if (waveOutDevice != null)
            {
                waveOutDevice.Dispose();
                waveOutDevice = null;
            }
        }
        public void ReloadContent()
        {
            lblAssetsContent.Text = currentPlayer.Assets.ToString();
            lblCapacity.Text = currentPlayer.WarehouseCapacity.ToString();
            lblGoldContent.Text = currentPlayer.Gold.ToString();
            lblGrainContent.Text = currentPlayer.Grain.ToString();
            lblMoney.Text = string.Format("{0:0.00} $", currentPlayer.Dollar);
            lblPetrolContent.Text = currentPlayer.Petrol.ToString();
            lblSilverContent.Text = currentPlayer.Silver.ToString();
            lblTechContent.Text = currentPlayer.Technology.ToString();
            lblLoan.Text = string.Format("{0:0.00} $", currentPlayer.Loan);
            lblDebit.Text = string.Format("{0:0.00} $", currentPlayer.Deposit);
        }
        private void RecalculateStock()
        {
            currentStock = (int)(currentPlayer.Gold + currentPlayer.Assets + currentPlayer.Grain + currentPlayer.Petrol + currentPlayer.Silver + currentPlayer.Technology);
            lblFreeSpace.Text = (currentPlayer.WarehouseCapacity - currentStock).ToString();
            lblUsedSpace.Text = currentStock.ToString();
        }

        private void btnMarket_Click(object sender, EventArgs e)
        {
            MarketForm market = new MarketForm();
            if (market.ShowDialog() == DialogResult.OK)
            {
                //when the market form is closed, clear the players and reads them again, then creates new current player and refreshes the stock
                existingPlayers.Clear();
                controler.ReadFromFile("Users.txt", existingPlayers);
                controler.CreateCurrentPlayer(currentPlayer, existingPlayers, index);
                ReloadContent();
                RecalculateStock();
            }
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
            songChecker.Start(); // timer that checks the song at every 500 miliseconds
            controler.LoadSongs(existingSongs); // loads all avaliable songs in a list
            
            this.Text = "Profile - Hello, " + LoginForm.loggedPlayer;
            controler.ReadFromFile("Users.txt", existingPlayers);
            for (int i = 0; i < existingPlayers.Count; i++)
            {
                if (existingPlayers[i].Username == LoginForm.loggedPlayer)
                {
                    index = i;
                    controler.CreateCurrentPlayer(currentPlayer, existingPlayers, i);

                    
                    pbPhoto.ImageLocation = "Pictures\\" + currentPlayer.Picture; ;
                    lblFullName.Text = currentPlayer.Name;
                    lblUsername.Text = currentPlayer.Username;

                    ReloadContent();
                    RecalculateStock();

                }
            }
            songChecker_Tick(sender, e);//launches the music
        }

        private void changeProfilePictureToolStripMenuItem_Click(object sender, EventArgs e)
        {
            File.Delete(pbPhoto.ImageLocation); // deletes the old profile picture from the /pictures directory
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG files|*.jpg|PNG files|*.png|BMP files|*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                //creates a copy of the profile picture into the /bin directory for an easy access
                Bitmap bmp = new Bitmap(open.FileName);
                bmp.Save(open.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                //moves the new picture into the Pictures\ directory
                File.Move(open.SafeFileName, "Pictures\\" + open.SafeFileName);

                pbPhoto.Image = null;
                pbPhoto.ImageLocation = "Pictures\\"+open.SafeFileName;
                
                currentPlayer.Picture = open.SafeFileName;
                controler.PrepareToSave(currentPlayer, existingPlayers, index); // puts the stats of the current player into the list
                controler.SaveGame(existingPlayers); // writes the info into the file              
                
            }
            //clears the used resources of OpenFileDialog, so it can be used again after that
            open.Dispose();
            
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentPassword = currentPlayer.Password;
            PasswordForm pass = new PasswordForm();
            if (pass.ShowDialog() == DialogResult.OK)
            {
                currentPlayer.Password = PasswordForm.NewPassword;
                controler.PrepareToSave(currentPlayer, existingPlayers, index);
                controler.SaveGame(existingPlayers);
            }
        }

        private void rankingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HighScoreForm score = new HighScoreForm();
            score.ShowDialog();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bank = new BankForm();
            if (bank.ShowDialog() == DialogResult.OK)
            {
                existingPlayers.Clear();
                controler.ReadFromFile("Users.txt", existingPlayers);
                controler.CreateCurrentPlayer(currentPlayer, existingPlayers, index);
                timerTicks = 0; // when the bank form is closed, we null the ticks 
                ReloadContent();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timerTicks++;
        }

        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to delete your account?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                for (int i = 0; i < existingPlayers.Count; i++)
                {
                    if (existingPlayers[i].Username == currentPlayer.Username)
                    {
                        File.Delete(existingPlayers[i].Picture);//deletes the picture of the player
                        existingPlayers.RemoveAt(i);
                        break;
                    }
                }
                controler.SaveGame(existingPlayers);
                MessageBox.Show("Your account has been deleted! You will now be logged of the game!", "Account deleted!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }
        }

        private void ProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            CloseWaveOut();
        }

        private void btnMute_Click(object sender, EventArgs e)
        {
            if (audioFileReader.Volume !=0)
            {
                audioFileReader.Volume = 0f;
            }
            else
            {
                audioFileReader.Volume = 0.5f;
            }
        }

        private void volumeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentVolume = audioFileReader.Volume;
            VolumeForm volume = new VolumeForm();
            if (volume.ShowDialog() == DialogResult.OK)
            {
                audioFileReader.Volume = currentVolume;
            }
        }

        private void selectMusicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusicForm music = new MusicForm();
            if (music.ShowDialog()==DialogResult.OK)
            {
                existingSongs.Clear();
                controler.LoadSongs(existingSongs);
            }
        }

        private void songChecker_Tick(object sender, EventArgs e)
        {
            InitializeMusic(existingSongs);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
