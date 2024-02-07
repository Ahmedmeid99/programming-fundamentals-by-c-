using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace strat_in_windows_forms
{
    public partial class frmMessageWindow : Form
    {
        public frmMessageWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hi This is a Message !", "this is the title", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.OK)
            {
                // do something
                MessageBox.Show("Deleted Succefuly");

            }
        }

        private void frmMessageWindow_Load(object sender, EventArgs e)
        {

        }

        private void checkReact_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnCheckReactOption_Click(object sender, EventArgs e)
        {
            if (checkReact.Checked)
            {
                MessageBox.Show("react Checked");

            }
            else
            {
                MessageBox.Show("react not Checked");
            }

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked)
            {
                txtboxTotalPoints.Text = radioButton1.Tag.ToString();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                txtboxTotalPoints.Text = radioButton3.Tag.ToString();
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                txtboxTotalPoints.Text = radioButton2.Tag.ToString();
            }
        }
    }
}
