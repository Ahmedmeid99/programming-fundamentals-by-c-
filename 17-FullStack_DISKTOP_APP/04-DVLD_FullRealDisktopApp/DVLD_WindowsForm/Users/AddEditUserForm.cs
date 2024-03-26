using System;

using DVLDBusinessLayer;
using System.Windows.Forms;
using System.Data;

namespace DVLD_WindowsForm
{
    public partial class AddEditUserForm : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int _UserID;
        private int _PersonID;
        private clsUser _User;
        private clsPerson _Person;


        public static DataTable dtPeople;
        public static DataView dtPeopleView;


        public AddEditUserForm(int UserID)
        {
            InitializeComponent();

           // _LoadCmbFilterPeople();

            _UserID = UserID;

            if (_UserID == -1)
            {
                // Create Person 
                _User = new clsUser();

                // in Add new Mode
                SetUIMode(enMode.AddNew);


                // when save data will use AddNewMethod in BusinessLayer
                Mode = enMode.AddNew;

                return;
            }
            // when save data will use UpdateMethod in BusinessLayer
            Mode = enMode.Update;

            _User = clsUser.Find(UserID);

            // else in Update Mode
            _FillControlsWithData();

            // handle Header
            SetUIMode(enMode.Update);

        }

        private void AddEditUserForm_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

             _FullPersonObject();
             _LoadCmbFilterPeople();


            if (Mode == enMode.AddNew)
            {
                groupBoxFilter.Enabled =true;

                lbUserID.Text = "...";
                txtUserName.Text = "";
                txtPassword.Text = "";
                txtConfirmPassword.Text = "";
                ckbActive.Checked = true;
                return;

            }

            // that is mean Mode is Update
            groupBoxFilter.Enabled = false;


        }


        //-----------------------------------------
        //--------[ Set and get properties]--------
        //-----------------------------------------

        public void SetUIMode(enMode Mode)
        {
            this.Mode = Mode;
            switch (Mode)
            {
                case enMode.AddNew:
                    lbMode.Text = "Add New User";
                    break;
                case enMode.Update:
                    lbMode.Text = "Update User";
                    break;
                default:
                    lbMode.Text = "....";
                    break;
            }
        }
        
        //-----------------------------------------
        //---------[Find Person by Filter]---------
        //-----------------------------------------
        

        private void _LoadCmbFilterPeople()
        {
            if (dtPeople == null)
                return;

            foreach (DataColumn column in dtPeople.Columns)
            {
                cmbFilter.Items.Add(column.ColumnName);
            }

            if (cmbFilter.Items.Count > 0)
                cmbFilter.SelectedIndex = 0;

        }

        private void _FilterDtView()
        {
            string FilterString = "";
            // fix if Wase not selected 
            if (cmbFilter.SelectedItem == null)
            {                                                                  
               string FilterBy= "PersonID = ";
                FilterString = (txtFilter.Text== "")?"": FilterBy + txtFilter.Text;
            }  // fix if txtFilter is Empty 
            else if (string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";

            else if (cmbFilter.Text == "PersonID" || cmbFilter.Text == "UserID")
            {
                if (txtFilter.Text != "")
                    FilterString = $"{cmbFilter.SelectedItem} = {txtFilter.Text}";
                else
                    FilterString = "";
            }

            else if (cmbFilter.Text == "UserName" || cmbFilter.Text == "FullName")
            {
                if (txtFilter.Text != "")
                    FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";
                else
                    FilterString = "";
            }
            // filter by First,Second,Third,Last (Name) ,Gendor,Country,NationalNo,Address,Email,ImagePath ,Phone
            else
                FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";

            if (!string.IsNullOrEmpty(FilterString))
                dtPeopleView.RowFilter = FilterString;
            else
                dtPeopleView.RowFilter = "";
            dtPeopleView.RowFilter = FilterString;

        }

         private void _FullPersonObject()
        {
            // full Person
            dtPeople = clsPerson.GetAllPeople();
            dtPeopleView = new DataView(dtPeople);

            // filter data
            _FilterDtView();

            // get first result after filtering
            if (dtPeopleView.Count <= 0)
                return;

            DataRowView PersonRow = dtPeopleView[0];
             _PersonID =Convert.ToInt32(PersonRow["PersonID"]);

            _Person = clsPerson.Find(_PersonID);

           
            //IsPersonOfUserExists(_PersonID);
        }

       

        //-----------------------------------------

        //-----------------------------------------

       
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
            lbFirstName.Text = Person.FirstName;
            lbLastName.Text = Person.LastName;
            lbThirdName.Text = Person.ThirdName;
            lbSecondName.Text = Person.SecondName;
            lbEmail.Text = Person.Email;
            lbAddress.Text = Person.Address;
            lbDateOfBirth.Text = Person.DateOfBirth.ToString();
            lbPhone.Text = Person.Phone;
            lbNationalNo.Text = Person.NationalNo;

            // handel Gerder
            _HandelGendor(Person.Gendor);

            // handel Image

            string ImagePath = Global.Path + Person.ImagePath + Global.ImgExtintion;
            _HandelImage(ImagePath, Person.Gendor);


            // handel country selected
            _HandleCountry(Person.CountryID);
        }

        private void _FillUserControls(clsUser User)
        {
            lbUserID.Text = User.UserID.ToString();
            txtUserName.Text = User.UserName;
            txtPassword.Text = User.Password;
            txtConfirmPassword.Text = User.Password;
            ckbActive.Checked = User.Active;
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
            _PersonID = _User.PersonID;
            _Person = clsPerson.Find(_PersonID);

            _FillPersonControls(_Person);
            _FillUserControls(_User);


        }

        private void _FillUserWithData(ref clsUser User)
        {
            // fill User With Data Courectly

            //Check Form is valid
            User.PersonID = _PersonID;
            User.UserName   = txtUserName.Text;
            User.Password    =txtPassword.Text;
            User.Permission = -1;
            User.Active = ckbActive.Checked;


        }

        //--------------------------------
        //-------[ Validation ]-----------
        //--------------------------------

        private bool IsPersonOfUserExists(int PersonID)
        {
            clsUser User = clsUser.FindPerson(PersonID);
            if (User == null)
                return false;

           // _FillUserControls(_User);
            return true;
        }

        private void txtFilter_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "PersonID" || cmbFilter.Text == "Phone")
            {

                if (!GlobalMethods.CheckIsDigit(e))
                    e.Handled = true; // ignore the input char;
            }
        }

        private void CheckIsEmpty(object sender, EventArgs e)
        {
           TextBox textBox = sender as TextBox;
            if (GlobalMethods.CheckTxtBoxIsEmpty(textBox))
                txtErrorProvider.SetError(textBox, "Enter Value in this Field !!!");

            else
                txtErrorProvider.SetError(textBox, ""); // remove the error
        }
        
        private void txtConfirmPassword_Leave(object sender, EventArgs e)
        {
            CheckIsEmpty(sender, e);
            _ConfirmPassword(txtPassword, txtConfirmPassword);
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

        private void CheckNumField(object sender, KeyPressEventArgs e)
        {
            GlobalMethods.CheckNumField(sender, e);
        }

        public bool _ConfirmPassword(TextBox  PasswordBox1, TextBox PasswordBox2)
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
            bool txt1 = _CheckTextBox(txtUserName);
            bool txt2 = _CheckTextBox(txtPassword);
            bool txt3 = _CheckTextBox(txtConfirmPassword);
            bool ValidPassword = _CheckPasswordIsValid(txtPassword);
            bool IsConfirm = _ConfirmPassword(txtPassword, txtConfirmPassword);


            if (txt1 && txt2 && txt3 && ValidPassword && IsConfirm)
                return true;
            else
                return false;

        }
       
        //------------------------------
        //------[Main Actions]----------
        //------------------------------
        private void _Save()
        {
            // create person 
            // -- by default Constractor
            // -- by Private Constractor => Find

            _FillUserWithData(ref _User);

            //  Person is used before to create user
            if (IsPersonOfUserExists(_PersonID) && Mode == enMode.AddNew)
            {
                MessageBox.Show($"This user is Exists in _UserID = {_UserID}(You cannot add hem again)");
                return;
            } 
            else if (IsPersonOfUserExists(_PersonID) && Mode == enMode.Update)
            {
                MessageBox.Show($"you will update this user");
            }

            // Check form is Valid if it is not valid go back
            if (!_CheckFormIsValid())
                return;            

            if (_User.Save())
            {
                //Set user id
                //_User = clsUser.FindPerson(_PersonID);
                if (_User == null)
                {
                    MessageBox.Show("Error : User is null");
                    return;
                }
                _UserID = _User.UserID;
                lbUserID.Text = _UserID.ToString();

                MessageBox.Show("Data Saved Successfuly");
                
                SetUIMode(enMode.Update);
            }
            else
                MessageBox.Show("Error : Data is not Saved Successfuly");

            // handle Header
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // check if Person is used from exist user
            if (IsPersonOfUserExists(_PersonID) && Mode == enMode.AddNew)
            {
                MessageBox.Show("This user is Exists (You cannot add hem again)");
                return;
            }

            int CurrentIndex = UserTabControl.SelectedIndex;
            int NextIndex = (CurrentIndex + 1) % UserTabControl.TabCount;
            UserTabControl.SelectedIndex = NextIndex;
        }

        private void btnprev_Click(object sender, EventArgs e)
        {
            int CurrentIndex = UserTabControl.SelectedIndex;
            int PrevIndex = CurrentIndex == 0 ? UserTabControl.TabCount - 1 : CurrentIndex - 1;
            UserTabControl.SelectedIndex = PrevIndex;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFilter.Text))
                return;
            // onchange update data grid view 
            _FullPersonObject();  // full person object with data

            if (dtPeople.Columns.Count > 0 && dtPeople.Rows.Count > 0)
            {
                _FillPersonControls(_Person);
            }
            // refresh => _FullPersonObject();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // update person
            if (_PersonID <= 0)
                return;

            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(_PersonID);
            frmAdd_Update.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AddEditPersonForm AddEditPersonFrm = new AddEditPersonForm(-1);
            // After done call this Function 
            AddEditPersonFrm.DataBack += Form_DataBack;
            AddEditPersonFrm.Show();
        }


        // Delegation Function
        private void Form_DataBack(object sender,int PersonID)
        {
            this._PersonID = PersonID;
            // find person
            _Person = clsPerson.Find(this._PersonID);
            _FillPersonControls(this._Person);
        }
    }
}
