using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // validation 
            if (string.IsNullOrEmpty(textBoxId.Text.Trim()) || string.IsNullOrEmpty(textBoxName.Text.Trim()))
            {
                return;
            }

            ListViewItem Item = new ListViewItem(textBoxId.Text.Trim());
            Item.SubItems.Add(textBoxName.Text.Trim());
            listView1.Items.Add(Item);

            textBoxId.Clear();
            textBoxName.Clear();
            textBoxId.Focus();

        }

        private void rbSmall_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSmall.Checked)
                listView1.View = View.SmallIcon;
        }

        private void rbLarg_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLarg.Checked)
                listView1.View = View.LargeIcon;
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDetails.Checked)
                listView1.View = View.Details;
        }

        private void rbTitle_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTitle.Checked)
                listView1.View = View.Tile;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            if (rbList.Checked) 
                listView1.View = View.List;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (listView1.Items.Count > 0)
                listView1.Items.Remove(listView1.SelectedItems[0]);
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (Convert.ToInt32(textBox1.Text) < 10 || Convert.ToInt32(textBox1.Text) > 120)
            { 
                e.Cancel = true;
                errorProvider1.SetError(textBox1, "your age must be > 10 and < 120");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(textBox2, "you must enter you name");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox2, "");
            }
        }

        private string mode = "start";
        private void button1_Click(object sender, EventArgs e)
        {

            if(mode == "start")
            {
                for (int i=1; i<=100;i++)
                {
                    Thread.Sleep(100);
                    progressBar1.Value = i;
                    label5.Text = i.ToString() + " %";
                progressBar1.Refresh();
                label5.Refresh();
                button1.Refresh();
                }
                mode = "reset";
                button1.Text = "reset";
            }
            else
            {
                mode = "start";
                button1.Text= "start";
                progressBar1.Value = 0;
                label5.Text = "0 %";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = trackBar1.Value.ToString() + " %";
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label6.Text = trackBar1.Value.ToString() + " %";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = numericUpDown1.Value.ToString();
        }
    }
}
