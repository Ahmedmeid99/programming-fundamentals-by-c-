using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _05_ComboBox_CheckedList_Link_MaskedTxtBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form frm2 = new frm2();
            frm2.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form frm3 = new frm3();
            frm3.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form frm4 = new frm4();
            frm4.Show();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Form frm5 = new frm5();
            frm5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form frm6 = new frm6();
            frm6.Show();

        }

    }
}
