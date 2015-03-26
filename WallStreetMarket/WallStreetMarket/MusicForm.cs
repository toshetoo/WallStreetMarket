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
using WallStreetMarket.Classses;


namespace WallStreetMarket
{
    public partial class MusicForm : Form
    {
        List<Song> existingSongs = new List<Song>();
        FileManager controler = new FileManager();
        public MusicForm()
        {
            InitializeComponent();
        }

        private void MusicForm_Load(object sender, EventArgs e)
        {
            controler.LoadSongs(existingSongs, lbCurrentSongs);
        }

        private void btnAddSongs_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "MP3 files|*mp3";
            open.Multiselect = true;
            if (open.ShowDialog()==DialogResult.OK)
            {
                for (int i = 0; i < open.SafeFileNames.Length; i++)
                {
                    Song song = new Song();
                    song.Name = open.SafeFileNames[i];
                    song.Path = open.FileNames[i];

                    //copy the song that the user selected and places it in the \Music directory so
                    //it can be played after that
                    File.Copy(open.FileNames[i], "Music\\"+open.SafeFileNames[i]);
                    existingSongs.Add(song);
                    lbCurrentSongs.Items.Add(song.Name);

                }
                
            }
            controler.SaveSongs(existingSongs);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (existingSongs.Count != 1)
            {
                existingSongs.RemoveAt(lbCurrentSongs.SelectedIndex);
                lbCurrentSongs.Items.RemoveAt(lbCurrentSongs.SelectedIndex);
                controler.SaveSongs(existingSongs);
            }
            else
            {
                MessageBox.Show("You must have at least one song!");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }        
    }
}
