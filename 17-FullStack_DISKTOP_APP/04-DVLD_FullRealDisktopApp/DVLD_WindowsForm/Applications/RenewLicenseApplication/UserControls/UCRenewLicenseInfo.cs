using System;
using DVLDBusinessLayer;
using DVLDBusinessLayer.Licenses;

using System.Windows.Forms;
using System.ComponentModel;

namespace DVLD_WindowsForm.Applications.RenewApplication.UserControls
{
    public partial class UCRenewLicenseInfo : UserControl
    {
        
        private int NewLicenseID { get; set; }
        private int RenewLicenseAppID { get; set; }
        private int OldLicenseID { get; set; }
        private string CreatedByUserName { get; set; }
        private DateTime ApplicationDate { get; set; }
        private DateTime IssueDate { get; set; }
        private DateTime ExpirationDate { get; set; }
        private double ApplicationFees { get; set; }
        private double LicenseFees { get; set; }
        private double TotalFees { get; set; }
        private string Notes { get; set; }


        private clsLicense _OldLicense;
        private clsLicense _NewLicense;

        public UCRenewLicenseInfo()
        {
            InitializeComponent();

        }
        public UCRenewLicenseInfo(clsLicense OldLicense)
        {
            InitializeComponent();

            _OldLicense = OldLicense;

            FillControlsWithData(_OldLicense);
        }

        public void FillControlsWithData(clsLicense OldLicense)
        {
            if (OldLicense == null)
                return;

            _OldLicense = OldLicense;
         
            OldLicenseID = _OldLicense.LicenseID;
            _SetOldLicenseIDUI(OldLicenseID);

            CreatedByUserName = Global.GlobalVars.CurrentUser.UserName;
            _SetCreatedByUserNameUI(CreatedByUserName);

            ApplicationDate = _OldLicense.ApplicationInfo.ApplicationDate;
            _SetApplicationDateUI(ApplicationDate);

            IssueDate = _OldLicense.IssueDate;
            _SetIssueDateUI(IssueDate);

            ExpirationDate = _OldLicense.ExpirationDate;
            _SetExpirationDateUI(ExpirationDate);

            ApplicationFees = clsApplicationType.Find((int) GlobalEnums.enApplicationType.ReNewDrivingLicense).Fees;
            _SetApplicationFeesUI(ApplicationFees);

            LicenseFees = _OldLicense.LicenseClassInfo.ClassFees;//_OldLicense.PaidFees;
            _SetLicenseFeesUI(LicenseFees);

            TotalFees = ApplicationFees + LicenseFees;
            _SetTotalFeesUI(TotalFees);

            Notes = _OldLicense.Notes;
            _SetNotesUI(Notes);

        }

        public void SetNewLicenseIDUI(int NewLicenseID) // wil used from Parent Form after save NewLicense
        {
            if (NewLicenseID < 0)
                return;

            this.NewLicenseID = NewLicenseID;

            lbRenewLicenseID.Text = NewLicenseID.ToString();
        }
        
        public void SetRenewLicenseAppIDUI(int RenewLicenseAppID)  // wil used from Parent Form after save NewLicense
        {
            if (RenewLicenseAppID < 0)
                return;

            this.RenewLicenseAppID = RenewLicenseAppID;

            lbRenewLicenseAppID.Text = RenewLicenseAppID.ToString();
        }

        public double GetTotalFees()
        {
            return this.TotalFees;
        }


        private void _SetOldLicenseIDUI(int OldLicenseID)
        {
            if (OldLicenseID < 0)
                return;

            lbOldLicenseID.Text = OldLicenseID.ToString();
        }
      
        private void _SetCreatedByUserNameUI(string CreatedByUserName)
        {
            lbCreatedBy.Text = CreatedByUserName;
        }
      
        private void _SetApplicationDateUI(DateTime ApplicationDate)
        {
            lbApplicationDate.Text = ApplicationDate.ToString("dd-MM-yyyy");
        }
     
        private void _SetIssueDateUI(DateTime IssueDate)
        {
            lbIssueDate.Text = IssueDate.ToString("dd-MM-yyyy");
        }
        
        private void _SetExpirationDateUI(DateTime ExpirationDate)
        {
            lbExpirationDate.Text = ExpirationDate.ToString("dd-MM-yyyy");
        }
        
        private void _SetApplicationFeesUI(double ApplicationFees)
        {
            lbApplicationFees.Text = ApplicationFees.ToString();
        } 
        
        private void _SetLicenseFeesUI(double LicenseFees)
        {
            lbLicenseFess.Text = LicenseFees.ToString();
        } 
        
        private void _SetTotalFeesUI(double TotalFees)
        {
            lbTotalFees.Text = TotalFees.ToString();
        }  
        
        private void _SetNotesUI(string Notes)
        {
            txtNotes.Text = Notes;
        }

        public string GetNotesUI()
        {
           return txtNotes.Text;
        }

        



    }
}
