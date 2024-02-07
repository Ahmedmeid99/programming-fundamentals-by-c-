using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _08_Dialogs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                button4.BackColor = colorDialog1.Color;
                button4.ForeColor = Color.White;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fontDialog1.Font = button1.Font;
            fontDialog1.ShowApply = true;

            if(fontDialog1.ShowDialog() == DialogResult.OK )
            {
                button1.Font = fontDialog1.Font;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = @"E:\";
            saveFileDialog1.DefaultExt = ".txt";
            saveFileDialog1.Filter = "text file (*.txt)| *.txt | All files (*.*)| *.*";
            saveFileDialog1.FilterIndex = 2;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(saveFileDialog1.FileName);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory =  @"E:\";
            openFileDialog1.DefaultExt =".txt";
            openFileDialog1.Multiselect = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(openFileDialog1.FileName);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // folderBrowserDialog1.RootFolder =Environment.SpecialFolder.MyDocuments;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show(folderBrowserDialog1.SelectedPath);
            }
        }
    }
}
