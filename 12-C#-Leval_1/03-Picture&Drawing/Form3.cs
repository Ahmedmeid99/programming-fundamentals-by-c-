using _03_Picture_Drawing.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03_Picture_Drawing
{
    public partial class frm3 : Form
    {
        public frm3()
        {
            InitializeComponent();
        }

        void SetDefaultActivePhoto()
        {
            rbNon.Checked = true;
            lbTitle.Text = "Non";
        }

        void UpdatePhoto()
        {
            if(rbNon.Checked)
            {
                pictureBox1.Image = Resources.friend_05;
                lbTitle.Text = "Non";
            }
            else if(rbBoy.Checked)
            {
                pictureBox1.Image = Resources.team_01;
                lbTitle.Text = "Boy";
            }
            else if(rbGirl.Checked)
            {
                pictureBox1.Image = Resources.team_02;
                lbTitle.Text = "Girl";
            }
        }
        private void Frm3_Load(object sender, EventArgs e)
        {
            SetDefaultActivePhoto();
        }

        private void rbBoy_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePhoto();
        }

        private void rbNon_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePhoto();
        }

        private void rbGirl_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePhoto();
        }
    }
}
