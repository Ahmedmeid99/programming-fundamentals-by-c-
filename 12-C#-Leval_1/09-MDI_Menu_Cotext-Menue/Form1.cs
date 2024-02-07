using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _09_MDI_Menu_Cotext_Menue
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void soultionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        Form frm2 = new Form2();
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You sure you want to close window ? ", "close window", MessageBoxButtons.OK) == DialogResult.OK)
            {
                frm2.Close();
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void daleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // linkLabel1.Enabled = false;
            linkLabel1.Visible = false;
        }
    }
}
