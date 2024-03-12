using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_before_Startting
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        // Create Delegate to send data back to form1
        public delegate void DataBackEventHandler(object sender, string Address);
        public event DataBackEventHandler DataBack;

        

        private void Form3_Load(object sender, EventArgs e)
        {
            cmbAddress.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // convert parameter if you need

            string Address = "";
            //if (cmbAddress.SelectedValue != null)
            Address = cmbAddress.Text;

            DataBack?.Invoke(this, Address);
            this.Close();
        }
    }
}
