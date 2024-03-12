using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace _01_before_Startting
{
    public partial class Login_SignUp : UserControl
    {
        // get and set property
        public string UserName { get; set; }
        public string Password { get; set; }

        public Login_SignUp()
        {
            InitializeComponent();
           
        }

       

        private void btnLogin_MouseHover(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.Black;
            btnLogin.ForeColor = Color.Gray;
        }

        private void btnLogin_MouseLeave(object sender, EventArgs e)
        {
            btnLogin.BackColor = Color.FromArgb(0,0,3,50);
            btnLogin.ForeColor = Color.Black;
        }

        private void btnSignUp_MouseHover(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.Black;
            btnSignUp.ForeColor = Color.Gray;
        }

        private void btnSignUp_MouseLeave(object sender, EventArgs e)
        {
            btnSignUp.BackColor = Color.FromArgb(0, 0, 3, 50);
            btnSignUp.ForeColor = Color.Black;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // Load data
            this.UserName = txtUserName.Text;
            this.Password = txtPassword.Text;

            // open information form
            Form InfoForm = new Form2(UserName, Password);
            InfoForm.Show();


        }

        private void Login_SignUp_Load(object sender, EventArgs e)
        {

        }
    }
}
