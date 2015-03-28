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
    public partial class PasswordForm : Form
    {
        public static string NewPassword;
        public PasswordForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbRepeat.Text==""||tbOldPass.Text==""||tbNewPass.Text=="")
            {
                MessageBox.Show("Please, fill all fields!");
            }
            else
            {
                if (tbOldPass.Text ==ProfileForm.CurrentPassword)
                {
                    if (tbNewPass.Text == tbRepeat.Text)
                    {
                        NewPassword = tbNewPass.Text;
                        MessageBox.Show("Password successfuly changed!");
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Passwords doesnt match!");
                    }
                }
                else
                {
                    MessageBox.Show("Current password doesnt match!");
                }
            }
        }
    }
}
