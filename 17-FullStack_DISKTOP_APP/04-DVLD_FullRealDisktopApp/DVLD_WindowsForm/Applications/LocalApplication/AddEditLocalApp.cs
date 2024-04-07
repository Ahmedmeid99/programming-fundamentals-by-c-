using System;

using System.Data;
using DVLDBusinessLayer;
using System.Windows.Forms;

namespace DVLD_WindowsForm.Applications.LocalApplication
{
    public partial class AddEditLocalApp : Form
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int _LocaLDLApplicationID;
        private int _PersonID;
        private clsLocalDLApplication _LocalDLApp;
        private clsPerson _Person;

        //-----------------------------------
        //---------Delegation----------------
        //-----------------------------------
        public delegate void ApplicationTestAddedEventHandler(object sender, EventArgs e);
        public event ApplicationTestAddedEventHandler ApplicationTestAdded;


        public static DataTable dtPeople;
        public static DataView dtPeopleView;
        private GlobalEnums.enApplicationStatus ApplicationStatus =GlobalEnums.enApplicationStatus.NewApplication;
        private GlobalEnums.enApplicationType ApplicationType = GlobalEnums.enApplicationType.NewLocalApp;

        public AddEditLocalApp(int LocaLDLApplicationID)
        {
            InitializeComponent();
                        

             _LocaLDLApplicationID = LocaLDLApplicationID;
            if (_LocaLDLApplicationID == -1)
            {
                // Create Person 
                _LocalDLApp = new clsLocalDLApplication();

                // in Add new Mode
                Mode = enMode.AddNew;

                SetUIMode(enMode.AddNew);

                return;
            }
            // when save data will use UpdateMethod in BusinessLayer
            Mode = enMode.Update;

            _LocalDLApp = clsLocalDLApplication.Find(_LocaLDLApplicationID);
            _LocaLDLApplicationID = _LocalDLApp.LocaLDLApplicationID;

            // else in Update Mode
            _FillControlsWithData();
            

            // handle Header
            SetUIMode(enMode.Update);

        }
                     
        private void _LoadLocalDLAppControls()
        {
            lbLocalDLApp.Text = "...";
            lbAppDate.Text = DateTime.Now.ToString();
            lbAppFees.Text = clsApplicationType.Find((int)ApplicationType).Fees.ToString();
            lbUserName.Text =Global.GlobalVars.CurrentUser.UserID.ToString();
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
                    lbMode.Text = "Add New Local Driving License Application";
                    break;
                case enMode.Update:
                    lbMode.Text = "Update Local Driving License Application";
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
        private void _LoadCmbApplcationClasses()
        {
            DataTable dtApplcationClasses;
            dtApplcationClasses = clsLicenseClass.GetAllAppTypes();

            if (dtApplcationClasses == null)
                return;

            foreach (DataRow row in dtApplcationClasses.Rows)
            {
                cmbLicenseClass.Items.Add(row["ClassName"]);
            }

           

        }

        private void _FilterDtView()
        {
            string FilterString = "";
            // fix if Wase not selected 
            if (cmbFilter.SelectedItem == null)
            {
                string FilterBy = "PersonID = ";
                FilterString = (txtFilter.Text == "") ? "" : FilterBy + txtFilter.Text;
            }  // fix if txtFilter is Empty 
            else if (string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";

            else if (cmbFilter.Text == "PersonID" || cmbFilter.Text == "LocaLDLApplicationID")
            {
                if (txtFilter.Text != "")
                    FilterString = $"{cmbFilter.SelectedItem} = {txtFilter.Text}";
                else
                    FilterString = "";
            }

            else if (cmbFilter.Text == "LocalDLAppName" || cmbFilter.Text == "FullName")
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
            _PersonID = Convert.ToInt32(PersonRow["PersonID"]);

            _Person = clsPerson.Find(_PersonID);


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

            string ImagePath =  Global.GlobalVars.Path + Person.ImagePath + Global.GlobalVars.ImgExtintion;
            _HandelImage(ImagePath, Person.Gendor);


            // handel country selected
            _HandleCountry(Person.CountryID);
        }

        private void _FillLocalDLAppControls()
        {
            lbLocalDLApp.Text = _LocaLDLApplicationID.ToString();
            lbAppDate.Text = _LocalDLApp.ApplicationDate.ToString(); // or use convert
            lbAppFees.Text = _LocalDLApp.PaidFees.ToString();

            // did not work
            

            // Selected text "" -> "..."
            //cmbLicenseClass.SelectedIndex = cmbLicenseClass.FindString(Class.ClassName);
            
            lbUserName.Text = _LocalDLApp.CreatedByUserID.ToString();
        }

        private void _FillControlsWithData()
        {
            
            if (_LocalDLApp == null)
                return;
            _PersonID = _LocalDLApp.ApplicationPersonID;
            _Person = clsPerson.Find(_PersonID);

            _FillPersonControls(_Person);
            _FillLocalDLAppControls();

        }

        private void _FillLocalDLAppWithData(ref clsLocalDLApplication LocalDLApp)
        {
            // fill LocalDLApp With Data Courectly

            LocalDLApp.ApplicationPersonID = _PersonID;
            LocalDLApp.ApplicationDate = DateTime.Now;
            LocalDLApp.lastStatusDate = DateTime.Now;
            LocalDLApp.ApplicationStatus =(byte) ApplicationStatus;
            LocalDLApp.ApplicationTypeID = (byte)ApplicationType;
            LocalDLApp.PaidFees = clsApplicationType.Find((int)ApplicationType).Fees;
            LocalDLApp.CreatedByUserID = Global.GlobalVars.CurrentUser.UserID;
            LocalDLApp.LicenseClassID =(byte) clsLicenseClass.Find(cmbLicenseClass.Text).LicenseClasseID;

        }

        //--------------------------------
        //-------[ Validation ]-----------
        //--------------------------------

        private bool IsPersonAndAppClassExist(int PersonID,byte LicenseClassID)
        {
            return clsLocalDLApplication.IsExists(PersonID,LicenseClassID);
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "PersonID" || cmbFilter.Text == "Phone")
            {
        
                if (!GlobalMethods.CheckIsDigit(e))
                    e.Handled = true; // ignore the input char;
            }
        }

        
        //------------------------------
        //------[Main Actions]----------
        //------------------------------
        private void _Save()
        {
            // create person 
            // -- by default Constractor
            // -- by Private Constractor => Find

            _FillLocalDLAppWithData(ref _LocalDLApp);

            //  Person is used before to create LocalDLApp
            if (IsPersonAndAppClassExist(_PersonID,_LocalDLApp.LicenseClassID) && Mode == enMode.AddNew)
            {
                MessageBox.Show($"This LocalDLApp is Exists in ApplicationID = {_LocalDLApp.ApplicationID} (You cannot add hem again)");
                return;
            }
            else if (IsPersonAndAppClassExist(_PersonID, _LocalDLApp.LicenseClassID) && Mode == enMode.Update)
            {
                MessageBox.Show($"you will update this LocalDLApp");
            }

           

            if (_LocalDLApp.Save())
            {
                //Set LocalDLApp id
                //_LocalDLApp = clsLocalDLApp.FindPerson(_PersonID);
                if (_LocalDLApp == null)
                {
                    MessageBox.Show("Error : LocalDLApp is null");
                    return;
                }
                _LocaLDLApplicationID = _LocalDLApp.LocaLDLApplicationID;
                lbLocalDLApp.Text = _LocaLDLApplicationID.ToString();

                MessageBox.Show("Data Saved Successfuly");

                SetUIMode(enMode.Update);
            }
            else
                MessageBox.Show("Error : Data is not Saved Successfuly");

            // handle Header
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            // check if Person is used from exist LocalDLApp
            

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
            ApplicationTestAdded?.Invoke(this, e);
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
        private void Form_DataBack(object sender, int PersonID)
        {
            this._PersonID = PersonID;
            // find person
            _Person = clsPerson.Find(this._PersonID);
            _FillPersonControls(this._Person);
        }

        private void AddEditLocalApp_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            _LoadCmbApplcationClasses();



            if (Mode == enMode.Update)
            {
                clsLicenseClass Class = clsLicenseClass.Find(_LocalDLApp.LicenseClassID);

                if (Class == null)
                    return;
                cmbLicenseClass.SelectedIndex = -1;
                cmbLicenseClass.SelectedText = "";
                //cmbLicenseClass.SelectedText = (string)Class.ClassName;
                cmbLicenseClass.SelectedIndex = cmbLicenseClass.FindString((string)Class.ClassName);
            }
            _FullPersonObject();
            _LoadCmbFilterPeople();
            if (Mode == enMode.AddNew)
            {
                _LoadLocalDLAppControls();

                if (cmbLicenseClass.Items.Count > 0)
                    cmbLicenseClass.SelectedIndex = 2;

                groupBoxFilter.Enabled = true;


                if (cmbLicenseClass.Items.Count > 0)
                    cmbLicenseClass.SelectedIndex = 2;
                return;

            }
           
            // that is mean Mode is Update
            groupBoxFilter.Enabled = false;
        }
    }
}
