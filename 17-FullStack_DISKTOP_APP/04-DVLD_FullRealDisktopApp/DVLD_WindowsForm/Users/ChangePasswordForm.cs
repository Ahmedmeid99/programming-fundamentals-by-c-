using System;
using DVLDBusinessLayer;
using System.Windows.Forms;
using System.Drawing;
using DVLDBusinessLayer.Global;

namespace DVLD_WindowsForm
{
    public partial class ChangePasswordForm : Form
    {
        private int _UserID;
        private clsUser _User;   
        private int _PersonID;
        private clsPerson _Person;
        // ----------------------------------- 
        // -----------[Delegations]-----------
        // -----------------------------------     
        public delegate void UserUpdatedEventHandler(object sender, EventArgs e);
        public event UserUpdatedEventHandler UserUpdated;

        public ChangePasswordForm(int UserID)
        {
            InitializeComponent();  
            
            if (UserID <= 0)
                return;
            _UserID = UserID;

            _FillControlsWithData();
            
            

        }

       
        private void _HandelImage(string ImagePath, string GendorChar)
        {
            try
            {
                if (ImagePath != "")
                    pbPersonImage.Load(ImagePath);

            }
            catch (Exception Ex)
            {
                if (GendorChar == "M")
                    pbPersonImage.Image = Properties.Resources.Male_512;
                else
                    pbPersonImage.Image = Properties.Resources.Female_512;
            }
        }

        private void _HandelGendor(string GendorChar)
        {
            if (GendorChar == "M" || GendorChar == "M")
            {
                lbGendor.Text = "Male";
                pbManIcon.Visible = true;
                pbWomanIcon.Visible = false;
            }
            else
            {
                lbGendor.Text = "Female";
                pbManIcon.Visible = false;
                pbWomanIcon.Visible = true;
            }
        }

        private void _HandleCountry(int CountryID)
        {
            lbCountry.Text = clsCountry.Find(CountryID).CountryName;
        }

        private void _FillPersonControls(clsPerson Person)
        {
            if (Person == null)
                return;

            lbPersonID.Text = _PersonID.ToString();
            lbName.Text = Person.FullName;
            lbEmail.Text = Person.Email;
            lbAddress.Text = Person.Address;
            lbDateOfBirth.Text = Person.DateOfBirth.ToString();
            lbPhone.Text = Person.Phone;
            lbNationalNo.Text = Person.NationalNo;

            // Change color of label name to red
            lbName.ForeColor =Color.Red;

            // handel Gerder
            _HandelGendor(Person.Gendor);

            // handel Image

            string ImagePath = Global.GlobalVars.Path + Person.ImagePath + Global.GlobalVars.ImgExtintion;
            _HandelImage(ImagePath, Person.Gendor);


            // handel country selected
            _HandleCountry(Person.CountryID);
        }

        private void _FillUserControls(clsUser User)
        {
            lbUserID.Text = User.UserID.ToString();
            lbUserName.Text = User.UserName;
            lbIsActive.Text = (User.Active == true)? "Yes" :"No";
        }

        private void _FillControlsWithData()
        {
            //--------------------------------
            // if use edit button
            //-------------------------------- 

            //--------------------------------
            // if use filter
            // person = PersonDataView[0] 
            //--------------------------------

            // Fill ather data if you need
            _User = clsUser.Find(_UserID);
            if (_User == null)
                return;

            _PersonID = _User.PersonID;
            _Person = clsPerson.Find(_PersonID);

            _FillPersonControls(_Person);
            _FillUserControls(_User);


        }


        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(_User.PersonID);
            frmAdd_Update.Show();
        }



        //-----------------------------------
        //-------[Change password]-----------
        //-----------------------------------

        //----------[Validation]-------------

        private void CheckIsEmpty(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (GlobalMethods.CheckTxtBoxIsEmpty(textBox))
                txtErrorProvider.SetError(textBox, "Enter Value in this Field !!!");

            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
        }

        private void CheckCurrentPassWord(object sender)
        {
            TextBox textBox = sender as TextBox;

            string EnteredPassword = GlobalFunctions.HashingPassword(textBox.Text);

            if (EnteredPassword != _User.Password)
                txtErrorProvider.SetError(textBox, "This is not the Current Password !!!");

            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
        }
        private void CheckCurrentPassWord_Leave(object sender, EventArgs e)
        {
            CheckIsEmpty(sender, e);
            CheckCurrentPassWord(sender);


        }

        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            CheckIsEmpty(sender, e);
            _ConfirmPassword(txtNewPass, txtConfirmPass);
        }

        private bool _CheckTextBox(TextBox textBox)
        {
            if (GlobalMethods.CheckTxtBoxIsEmpty(textBox))
            {
                txtErrorProvider.SetError(textBox, "Enter Value in this Field !!!");
                return false;
            }
            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
            return true;
        }

        private bool _CheckPasswordIsValid(TextBox textBox)
        {
            if (textBox.Text.Length <= 5)
            {
                txtErrorProvider.SetError(textBox, "Password Must be more than 5 char");
                return false;
            }
            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
            return true;
        }

        public bool _ConfirmPassword(TextBox PasswordBox1, TextBox PasswordBox2)
        {
            if (PasswordBox1.Text == PasswordBox2.Text)
            {
                txtErrorProvider.SetError(PasswordBox2, "");
                return true;
            }
            txtErrorProvider.SetError(PasswordBox2, "Please enter the same password");
            return false;
        }

        public bool _CheckFormIsValid()
        {
            bool txt1 = _CheckTextBox(txtCurrentPass);
            bool txt2 = _CheckTextBox(txtNewPass);
            bool txt3 = _CheckTextBox(txtConfirmPass);
            bool ValidPassword = _CheckPasswordIsValid(txtNewPass);
            bool IsConfirm = _ConfirmPassword(txtNewPass, txtConfirmPass);


            if (txt1 && txt2 && txt3 && ValidPassword && IsConfirm)
                return true;
            else
                return false;

        }

        //------------[Actions]--------------
        private void _ChangeUserPassword()
        {
            _User.Password = txtNewPass.Text;

        }

        private void _Save()
        {
            if (!_CheckFormIsValid())
                return;

            _ChangeUserPassword();

            if (_User.Save())
                MessageBox.Show("Data Saved Successfuly");

            else
                MessageBox.Show("Error : Data is not Saved Successfuly");
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            UserUpdated?.Invoke(this, e);
            this.Close();
        }

        
    }
}
