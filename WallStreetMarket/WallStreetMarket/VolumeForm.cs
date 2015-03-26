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
    public partial class VolumeForm : Form
    {
        public VolumeForm()
        {
            InitializeComponent();
        }

        private void VolumeForm_Load(object sender, EventArgs e)
        {
            trackBar1.Value = (int)(ProfileForm.currentVolume * 10);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProfileForm.currentVolume >=0.09f)
            {
                ProfileForm.currentVolume -= 0.1f;
                trackBar1.Value--;
            }
            else
            {
                MessageBox.Show("Volume at minimum!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ProfileForm.currentVolume <=1f)
            {
                ProfileForm.currentVolume += 0.1f;
                trackBar1.Value++;
            }
            else
            {
                MessageBox.Show("Volume at maximum!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
