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
    public partial class frm1 : Form
    {
        public frm1()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            Form frm2 = new frm2();
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frm3 = new frm3();
            frm3.Show();
        }
    }
}
