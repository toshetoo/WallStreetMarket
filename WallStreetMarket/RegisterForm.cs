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

namespace WallStreetMarket
{
    public partial class RegisterForm : Form
    {
        List<string> usernames = new List<string>();
        FileManager controler = new FileManager();

        string name;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Register_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            controler.ReadUsernames("Users.txt", usernames);
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "JPEG files|*.jpg|PNG files|*.png|BMP files|*.bmp";

            if (open.ShowDialog() == DialogResult.OK)
            {
                //so proud of this stuff ^_^ 
                
                //creates a copy of the profile picture into the /bin directory for an easy access
                Bitmap bmp = new Bitmap(open.FileName);
                bmp.Save(open.SafeFileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                //moves the new picture into the Pictures\ directory
                File.Move(open.SafeFileName, "Pictures\\" + open.SafeFileName);

                pbPhoto.ImageLocation = "Pictures\\" + open.SafeFileName;
                name = open.SafeFileName;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (tbFullName.Text!="" && tbPassword.Text!="" && tbUsername.Text!=""&& pbPhoto.ImageLocation != null)
            {              
                if (usernames.Contains(tbUsername.Text))
                {
                    MessageBox.Show("Username already taken");
                    tbUsername.Clear();
                }
                else
                {
                    using (StreamWriter sw = new StreamWriter("Users.txt", true))
                    {

                        sw.WriteLine(tbUsername.Text + ";" + tbPassword.Text + ";" + tbFullName.Text + ";10000;0;0;0;0;" + name + ";0;0;0;0;0;0;200");
                    }
                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {
                MessageBox.Show("All fields are required. You have to add picture!", "Error");
            }
        }
    }
}
