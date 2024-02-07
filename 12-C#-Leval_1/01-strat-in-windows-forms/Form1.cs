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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox2.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox2.Visible = false;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            this.Text = textBox3.Text;
            label1.Text = textBox3.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
