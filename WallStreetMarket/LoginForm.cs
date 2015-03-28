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
    public partial class LoginForm : Form
    {
        List<Player> existingPlayers = new List<Player>();
        FileManager controler = new FileManager();
        bool isRegistered = true;
        public static string loggedPlayer;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            controler.ReadFromFile("Users.txt", existingPlayers);
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool isFound = true; //check for correct username and password
            if (tbUsername.Text != "" && tbPassword.Text != "")
            {
                for (int i = 0; i < existingPlayers.Count; i++)
                {
                    if (existingPlayers[i].Username == tbUsername.Text && existingPlayers[i].Password == tbPassword.Text)
                    {
                        loggedPlayer = tbUsername.Text;
                        MessageBox.Show("Login succesfull. Welcome, " + tbUsername.Text);
                        isRegistered = true; //player have registration
                        isFound = true; //correct username and password
                        this.DialogResult = DialogResult.OK;
                        break;
                    }

                    else if (existingPlayers[i].Username != tbUsername.Text && existingPlayers[i].Password != tbPassword.Text)
                    {
                        isRegistered = false; //player don't have registration
                    }

                    else if (existingPlayers[i].Username == tbUsername.Text && existingPlayers[i].Password != tbPassword.Text)
                    {
                        //continue;
                        isRegistered = true; //there is player with this username or password
                        isFound = false; //username or password is wrong
                        
                    }
                }

                if (isRegistered == false)
                {
                    MessageBox.Show("No such player. Please register!");
                    isRegistered = true;
                }

                if (isFound == false)
                {
                    MessageBox.Show("Wrong username or password!");
                }

                tbUsername.Clear();
                tbPassword.Clear();
            }
            else
            {
                MessageBox.Show("All fields are required!", "Error");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterForm reg = new RegisterForm();
            if (reg.ShowDialog() == DialogResult.OK)
            {
                existingPlayers.Clear();
                controler.ReadFromFile("Users.txt", existingPlayers);
            }
        }

        private void tbPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLogin_Click(sender, e);
            }
        }
    }
}
