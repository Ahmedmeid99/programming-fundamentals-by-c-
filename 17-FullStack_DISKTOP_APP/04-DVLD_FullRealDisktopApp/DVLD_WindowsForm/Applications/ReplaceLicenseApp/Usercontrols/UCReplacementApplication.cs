using DVLDBusinessLayer;
using DVLDBusinessLayer.Licenses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WindowsForm.Applications.ReplaceLicenseApp
{
    public partial class UCReplacementApplication : UserControl
    {
        private int NewLicenseID { get; set; }
        private int ReplaceLicenseAppID { get; set; }
        private int OldLicenseID { get; set; }
        private string CreatedByUserName { get; set; }
        private DateTime ApplicationDate { get; set; }
        private double ApplicationFees { get; set; }
        


        private clsLicense _OldLicense;
        private clsLicense _NewLicense;

        public UCReplacementApplication()
        {
            InitializeComponent();
        }
        
       
        public void FillControlsWithData(clsLicense OldLicense, GlobalEnums.enApplicationType ApplicationType)
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


            SetApplicationFees(ApplicationType);
            
        }

        public void SetApplicationFees(GlobalEnums.enApplicationType ApplicationType)
        {
            ApplicationFees = clsApplicationType.Find((int)ApplicationType).Fees;
            lbApplicationFees.Text = ApplicationFees.ToString();
        }

      

        public void SetNewLicenseIDUI(int NewLicenseID) // wil used from Parent Form after save NewLicense
        {
            if (NewLicenseID < 0)
                return;

            this.NewLicenseID = NewLicenseID;

            lbReplaceLicenseID.Text = NewLicenseID.ToString();
        }

        public void SetReplaceLicenseAppIDUI(int ReplaceLicenseAppID)  // wil used from Parent Form after save NewLicense
        {
            if (ReplaceLicenseAppID < 0)
                return;

            this.ReplaceLicenseAppID = ReplaceLicenseAppID;

            lbReplaceLicenseAppID.Text = ReplaceLicenseAppID.ToString();
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



        
    }
}
