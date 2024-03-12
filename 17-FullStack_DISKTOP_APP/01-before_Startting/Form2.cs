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
    public partial class Form2 : Form
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public Form2(string UserName, string Password)
        {
            InitializeComponent();

            this.UserName = UserName;
            this.Password = Password;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            lbUserName.Text = UserName;
            lbPassWord.Text = Password;
        }
    }
}
