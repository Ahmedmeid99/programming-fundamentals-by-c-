using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DVLDBusinessLayer;
using DVLDBusinessLayer.Global;
using Microsoft.Win32;

namespace DVLD_WindowsForm
{
    public partial class LoginForm : Form
    {
        
        //private static string _Separator = "#||#";
        //private static string _FilePath = @"E:\programming fundamentals by c++\17-FullStack_DISKTOP_APP\04-DVLD_FullRealDisktopApp\DVLD_WindowsForm\Login\Users.txt";

        private static string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\DVLD_DISKTOP_APP";

        private  string _UserNameValue = "";
        private  string _PasswordValue = "";
        
        private  string _UserNameKey = "UserName";
        private  string _PasswordKey = "Password";
       
        public LoginForm()
        {
            InitializeComponent();
            _FillLoginFormWindowsRegisterater();
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

        //private string _UserRecord(string Separator)
        //{
        //    return (txtUserName.Text + Separator + txtPassword.Text);
        //}

        //private void _FillLoginFormFromFile(string FilePath)
        //{
        //    
        //    string Line = File.ReadLines(_FilePath).FirstOrDefault();
        //
        //    if (!File.Exists(_FilePath) || string.IsNullOrEmpty(Line))
        //        return;
        //    
        //    string[] UserLoginParts = Line.Split(new String[] { _Separator }, StringSplitOptions.None);
        //   
        //    _UserName = UserLoginParts[0];
        //    _Password = UserLoginParts[1];
        //
        //    _FillTxtBox(txtUserName, _UserName);
        //    _FillTxtBox(txtPassword, _Password);
        //
        //    ckbRememberMe.Checked = true;
        //
        //}


        //private void _RegesterLoginInFile(string FilePath,string UserRecord)
        //{
        //    try
        //    {
        // _UserRecord(_Separator)
        //      File.WriteAllText(_FilePath,UserRecord);
        //    }
        //    catch (Exception Ex)
        //    {
        //        MessageBox.Show(Ex.Message);
        //    }
        //
        //}

        private void _FillLoginFormWindowsRegisterater()
        {
            try
            {
                // Get UserName Password (WindowsRegisterater)
                string UserName = Registry.GetValue(KeyPath, _UserNameKey, null) as string;
                string Password = Registry.GetValue(KeyPath, _PasswordKey, null) as string;

                _FillTxtBox(txtUserName, UserName);
                _FillTxtBox(txtPassword, Password);

                ckbRememberMe.Checked = true;
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void _RegesterLoginInWindowsRegisterater()
        {
            
            try
            {
                // Set UserName Password (WindowsRegisterater)
                Registry.SetValue(KeyPath,_UserNameKey,_UserNameValue,RegistryValueKind.String);
                Registry.SetValue(KeyPath,_PasswordKey, _PasswordValue, RegistryValueKind.String);

            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        
        }  
        private void _RemoveLoginInWindowsRegisterater()
        {
            try
            {
                using(RegistryKey baseKey = RegistryKey.OpenBaseKey(RegistryHive.CurrentUser,RegistryView.Registry64))
                {
                    using(RegistryKey Key = baseKey.OpenSubKey(KeyPath,true))
                    {
                        if(Key != null)
                        {
                            // delete username and password
                            Key.DeleteValue(_UserNameKey);
                            Key.DeleteValue(_PasswordKey);
                        }

                    } 

                }

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
                Global.GlobalVars.CurrentUser  = User; // Set Current User
                
                Form MainFrm= new MainForm();                           
                MainFrm.Show();

                 // fill Vars
                _UserNameValue = txtUserName.Text;
                _PasswordValue = txtPassword.Text; 

                //  remember this login
                if (_IsRememberMeChecked())
                {
                    _RegesterLoginInWindowsRegisterater();
                    return;
                }

                // else (dont remember this login) if he is the same user
                if(txtUserName.Text == _UserNameValue && txtPassword.Text == _PasswordValue)
                {
                    // remove it from loging file if Exists (Clear)
                    _RemoveLoginInWindowsRegisterater();
                }


                //this.Hide(); // Close()
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
        }

        
    }
}
