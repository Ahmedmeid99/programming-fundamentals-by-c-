using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_WindowsForm
{
    public partial class LoginForm : Form
    {
        
        private static string _Separator = "#||#";
        private static string _FilePath = @"E:\programming fundamentals by c++\17-FullStack_DISKTOP_APP\04-DVLD_FullRealDisktopApp\DVLD_WindowsForm\Login\Users.txt";

        private  string _UserName = "";
        private  string _Password = "";
       
        public LoginForm()
        {
            InitializeComponent();
            _FillLoginForm(_FilePath);
        }
       
        private bool _IsRememberMeChecked()
        {
            bool RememberOption = false;

            if (ckbRememberMe.Checked)
                RememberOption = true;
            else
                RememberOption = false;

            return RememberOption;
        }

        private string _UserRecord(string Separator)
        {
            return (txtUserName.Text + Separator + txtPassword.Text);
        }

        private void _FillLoginForm(string FilePath)
        {
            
            string Line = File.ReadLines(_FilePath).FirstOrDefault();

            if (!File.Exists(_FilePath) || string.IsNullOrEmpty(Line))
                return;
            
            string[] UserLoginParts = Line.Split(new String[] { _Separator }, StringSplitOptions.None);
           
            _UserName = UserLoginParts[0];
            _Password = UserLoginParts[1];

            _FillTxtBox(txtUserName, _UserName);
            _FillTxtBox(txtPassword, _Password);

            ckbRememberMe.Checked = true;


        }


        private void _RegesterLogin(string FilePath)
        {
            try
            {
              File.WriteAllText(_FilePath,_UserRecord(_Separator));
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void _FillTxtBox(TextBox txtbox,string Value)
        {
            txtbox.Text = Value;
        }
        
        private void btnLogin_Click(object sender, EventArgs e)
        {

            clsUser User = clsUser.Find(txtUserName.Text, txtPassword.Text);


            if (User == null )
                MessageBox.Show("Ther are No Account With this UserName and Password");

            else if(!User.Active)
                MessageBox.Show("Your Account Is Unactive");

            else if(User != null && User.Active)
            {
                Form MainFrm= new MainForm();                           
                MainFrm.Show();

                Global.GlobalVars.CurrentUser  = User; // Set Current User

                //  remember this login
                if (_IsRememberMeChecked())
                {
                    _RegesterLogin(_FilePath);
                    return;
                }

                // else (dont remember this login)
                if(txtUserName.Text == _UserName && txtPassword.Text == _Password)
                {
                    // remove it from loging file if Exists (Clear)
                    try
                    {
                        File.WriteAllText(_FilePath, String.Empty);
                    }
                    catch (Exception Ex)
                    {
                        MessageBox.Show(Ex.Message);
                    }
                }
                

                //this.Hide(); // Close()
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

      
    }
}
