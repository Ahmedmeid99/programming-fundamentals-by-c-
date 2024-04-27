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

namespace DVLD_WindowsForm.Applications.InternationalApplication.UserControls
{
    public partial class UCInterApplicationInfo : UserControl
    {
        private int InternationalLicenseID {get;set;}
        private int InternationaApplicationID {get;set;}
        private int LocalLicenseID {get;set;}
        private string CreatedByUserName {get;set;}
        private DateTime ApplicationDate {get;set;}
        private DateTime IssueDate {get;set;}
        private DateTime ExpirationDate {get;set;}
        private double Fees {get;set;}

        private clsInternationalLicense _InternationalLicense;

        public UCInterApplicationInfo()
        {
            InitializeComponent();

        }
        public UCInterApplicationInfo(clsInternationalLicense InternationalLicense)
        {
            InitializeComponent();

            _InternationalLicense = InternationalLicense;

            FillControlsWithData(_InternationalLicense);
        }

        public void FillControlsWithData(clsInternationalLicense InternationalLicense)
        {
            if (InternationalLicense == null)
                return;

            _InternationalLicense = InternationalLicense;

            InternationalLicenseID = InternationalLicense.InternationalLicenseID;
            SetInternationalLicenseIDUI(InternationalLicenseID);
            
            
            InternationaApplicationID = InternationalLicense.ApplicationID;
            SetInternationaApplicationIDUI(InternationaApplicationID);
            
            
            LocalLicenseID = InternationalLicense.IssuedUsingLocalLicenseID;
            SetLocalLicenseIDUI(LocalLicenseID);
            
            
            CreatedByUserName = clsUser.Find(InternationalLicense.CreatedByUserID).UserName;
            SetCreatedByUserNameUI(CreatedByUserName);
            
            
            ApplicationDate = InternationalLicense.ApplicationDate;
            SetApplicationDateUI(ApplicationDate);
            
            
            IssueDate = InternationalLicense.IssueDate;
            SetIssueDateUI(IssueDate);
            
            
            ExpirationDate = InternationalLicense.ExpirationDate;
            SetExpirationDateUI(ExpirationDate);
            
            
            Fees = InternationalLicense.PaidFees;
            SetFeesUI(Fees);
        }

        public void SetInternationalLicenseIDUI(int InternationalLicenseID)
        {
            if (InternationalLicenseID < 0)
                return;

            lbInterLicenseID.Text = InternationalLicenseID.ToString();
        }
        public void SetInternationaApplicationIDUI(int InternationaApplicationID)
        {
            if (InternationaApplicationID < 0)
                return;

            lbInterAppID.Text = InternationaApplicationID.ToString();
        }
        private void SetLocalLicenseIDUI(int LocalLicenseID)
        {
            if (LocalLicenseID < 0)
                return;

            lbLocalLicenseID.Text = LocalLicenseID.ToString();
        }
        private void SetCreatedByUserNameUI(string CreatedByUserName)
        {
            lbCreatedBy.Text = CreatedByUserName;
        }
        private void SetApplicationDateUI(DateTime ApplicationDate)
        {
            lbApplicationDate.Text = ApplicationDate.ToString("dd-MM-yyyy");
        }
        private void SetIssueDateUI(DateTime IssueDate)
        {
            lbIssueDate.Text = IssueDate.ToString("dd-MM-yyyy");
        }
        private void SetExpirationDateUI(DateTime ExpirationDate)
        {
            lbExpirationDate.Text = ExpirationDate.ToString("dd-MM-yyyy");
        }
        private void SetFeesUI(double Fees) 
        {
            lbFees.Text = Fees.ToString();
        }


        
    }
}
