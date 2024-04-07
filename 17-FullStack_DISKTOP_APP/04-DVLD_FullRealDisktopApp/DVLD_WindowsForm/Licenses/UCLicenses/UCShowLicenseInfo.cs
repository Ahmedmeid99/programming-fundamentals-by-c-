using System;
using DVLDBusinessLayer;
using System.Windows.Forms;
using DVLDBusinessLayer.Licenses;
using System.Drawing;
using DVLD_WindowsForm.Global;

namespace DVLD_WindowsForm.Licenses
{
    public partial class UCShowLicenseInfo : UserControl
    {
        public string Name { get; set; }
        public string ClassName { get; set;}
        public string NationalNo { get; set;}
        public string Gandor { get; set; }
        public int LicenseID { get; set; }
        public int DriverID { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string IssueReson { get; set; }
        public string Notes { get; set; }
        public bool IsActive { get; set; }
        public bool IsDetained { get; set; } // 13
        public string PersonImagePath { get; set; } // 13


        public UCShowLicenseInfo()
        {
            InitializeComponent();

        }  
        public UCShowLicenseInfo(clsLicense License)
        {
            InitializeComponent();

            FillControlsWithData(License);
        }

        public void FillControlsWithData(clsLicense License)
        {
            clsPerson Person = clsPerson.Find(License.ApplicationInfo.ApplicationPersonID);

            Name = Person.FullName;
            SetNameUI(Name);

            ClassName = License.LicenseClassInfo.ClassName;
            SetClassNameUI(ClassName);
           
            NationalNo = Person.NationalNo;
            SetNationalNoUI(NationalNo);

            Gandor = Person.Gendor;
            SetGandorUI(Gandor);

            LicenseID = License.LicenseID;
            SetLicenseIDUI(LicenseID);

            DriverID = License.DriverInfo.DriverID;
            SetDriverIDUI(DriverID);

            DateOfBirth = Person.DateOfBirth;
            SetDateOfBirthUI(DateOfBirth);

            IssueDate = License.IssueDate;
            SetIssueDateUI(IssueDate);

            ExpirationDate = License.ExpirationDate;
            SetExpirationDateUI(ExpirationDate);

            IssueReson = GlobalMethods.GetIssueReason(License.IssueReason); 
            SetIssueResonUI(IssueReson);

            Notes = License.Notes;
            SetNotesUI(Notes);

            IsActive = License.IsActive;
            SetIsActiveUI(IsActive);

            IsDetained = false;          // Fix it << -
            SetIsDetainedUI(IsDetained); 

            PersonImagePath = Person.ImagePath;
            SetPersonImageUI(PersonImagePath);
        }

        private void SetNameUI(string Name)
        {
            lbPersonName.Text = Name;
            lbPersonName.ForeColor = Color.Red;
        }
        private void SetClassNameUI(string ClassName)
        {
            lbClassName.Text = ClassName;
        }
        private void SetNationalNoUI(string NationalNo)
        {
            lbNationalN.Text = NationalNo;
        }
        private void SetGandorUI(string Gandor)
        {
            _HandelGendor(Gandor);
        }
        private void SetLicenseIDUI(int LicenseID)
        {
            lbLicenseID.Text = LicenseID.ToString();
        }
        private void SetDriverIDUI(int DriverID)
        {
            lbDriverID.Text = DriverID.ToString();
        }
        private void SetDateOfBirthUI(DateTime DateOfBirth)
        {
            lbDateOfBirth.Text = DateOfBirth.ToString("dd-MM-yyyy");
        }
        private void SetIssueDateUI(DateTime IssueDate)
        {
            lbIssueDate.Text = DateOfBirth.ToString("dd-MM-yyyy");
        }
        private void SetExpirationDateUI(DateTime ExpirationDate)
        {
            lbExpirationDate.Text = DateOfBirth.ToString("dd-MM-yyyy");
        }
        private void SetIssueResonUI(string IssueReson)
        {
            lbIssueReason.Text = IssueReson;
        }
        private void SetNotesUI(string Notes)
        {
            lbNotes.Text = (string.IsNullOrEmpty(Notes.Trim())) ? "No Notes" : Notes;
        }
        private void SetIsActiveUI(bool IsActive)
        {
            lbIsActive.Text = (IsActive == true) ? "Yes" : "No";
        }
        private void SetIsDetainedUI(bool IsDetained) 
        {
            lbIsDetained.Text = (IsDetained) ? "Yes" : "No";   //  Fix it <<-
        }
        private void SetPersonImageUI(string PersonImagePath)
        {
           string ImagePath = GlobalVars.Path + PersonImagePath + GlobalVars.ImgExtintion;
            _HandelImage(ImagePath, this.Gandor);
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
                lbGandor.Text = "Male";
                pbMale.Visible = true;
                pbFemale.Visible = false;
            }
            else
            {
                lbGandor.Text = "Female";
                pbMale.Visible = false;
                pbFemale.Visible = true;
            }
        }
    }
}
