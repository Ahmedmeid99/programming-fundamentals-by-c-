using DVLD_WindowsForm.Licenses;
using DVLD_WindowsForm.Licenses.InternationalLicense;
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

namespace DVLD_WindowsForm.Applications.InternationalApplication
{
    public partial class AddInternarionalAppForm : Form
    {
        private int _LocalLicenseID;
        private clsLicense _LocalLicense;

        private int _InternationalLicenseID;
        private clsInternationalLicense _InternationalLicense;

        //-----------------------------------
        //---------Delegation----------------
        //-----------------------------------
        public delegate void InterLicenseAddedEventHandler(object sender, EventArgs e);
        public event InterLicenseAddedEventHandler InterLicenseAdded;
        //------------------------------------
        public AddInternarionalAppForm()
        {
            InitializeComponent();

            btnlinkShowLicenseInfo.Enabled = false;
            btnlinkShowLicenseHistory.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
            _LocalLicense = _GetLicense(txtFindLicense.Text);

            if (_LocalLicense == null)
                return;

            _InternationalLicense = new clsInternationalLicense();

            //  Fill Application obj 
            _FillApplicationObject(_InternationalLicense);

            //  Fill InternationalLicense obj     
            _FillInternationalLicenseObject(_InternationalLicense);

            // fill Controls
            ucShoLicenseInfo.FillControlsWithData(_LocalLicense);
            ucInterApplicationInfo.FillControlsWithData(_InternationalLicense);

            // check if has prev International Licenses
            if (clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(_LocalLicense.DriverInfo.DriverID) > 0)
            {
                MessageBox.Show("This Driver has Prev International License");
                return;
            }

            // check if Local License Class is " class 3 ..."
            if (_LocalLicense.LicenseClassInfo.LicenseClasseID != (int)GlobalEnums.enLicenseClasses.Class_3_OrdinaryDivingLicense)
            {
                MessageBox.Show("This License has not License Class of Typt Class_3_OrdinaryDivingLicense");
                return;
            }

            btnlinkShowLicenseHistory.Enabled = true;

        }
        private void _FillApplicationObject (clsInternationalLicense InternationalLicense)
        {
            //internationalLicense.ApplicationID = ApplicationID;
            InternationalLicense.ApplicationPersonID =_LocalLicense.DriverInfo.PersonInfo.PersonID ;
            InternationalLicense.ApplicationDate = DateTime.Now;
            InternationalLicense.ApplicationTypeID = (byte)GlobalEnums.enApplicationType.NewInternationalLicense;
            InternationalLicense.ApplicationStatus = (byte)GlobalEnums.enApplicationStatus.CompletedApplication;
            InternationalLicense.lastStatusDate = DateTime.Now;
            InternationalLicense.PaidFees = clsApplicationType.Find((int)GlobalEnums.enApplicationType.NewInternationalLicense).Fees;
            InternationalLicense.CreatedByUserID =(int) Global.GlobalVars.CurrentUser.UserID;
        }
        private void _FillInternationalLicenseObject(clsInternationalLicense InternationalLicense)
        {
            //InternationalLicense.InternationalLicenseID = InternationalLicenseID;
            //InternationalLicense.ApplicationID = ApplicationID;
            InternationalLicense.DriverID = _LocalLicense.DriverInfo.DriverID;
            InternationalLicense.IssuedUsingLocalLicenseID = _LocalLicense.LicenseID;
            InternationalLicense.IssueDate = DateTime.Now;
            InternationalLicense.ExpirationDate = DateTime.Now.AddYears(_LocalLicense.LicenseClassInfo.MinimumAllowedAge);
            InternationalLicense.IsActive = true;
            InternationalLicense.CreatedByUserID = (int)Global.GlobalVars.CurrentUser.UserID;
            InternationalLicense.DriverInfo = _LocalLicense.DriverInfo;
        }

        private clsLicense _GetLicense(string LicenseID)
        {
            int licenseID =Convert.ToInt32(LicenseID);
            return clsLicense.Find(licenseID);
        }

        private void _Save()
        {

            // check if ha prev International Licenses
            if (clsInternationalLicense.GetActiveInternationalLicenseIDByDriverID(_LocalLicense.DriverInfo.DriverID) > 0)
            {
                MessageBox.Show("This Driver has Prev International License");
                return;
            }

            // check if Local License Class is " class 3 ..."
            if(_LocalLicense.LicenseClassInfo.LicenseClasseID != (int) GlobalEnums.enLicenseClasses.Class_3_OrdinaryDivingLicense)
            {
                MessageBox.Show("This License has not License Class of Typt Class_3_OrdinaryDivingLicense");
                return;
            }

            if(_InternationalLicense.Save())
            {
                MessageBox.Show("This International License saved Successfuly");

                ucInterApplicationInfo.SetInternationaApplicationIDUI(_InternationalLicense.ApplicationID);
                ucInterApplicationInfo.SetInternationalLicenseIDUI(_InternationalLicense.InternationalLicenseID);

                btnlinkShowLicenseInfo.Enabled = true;
                btnlinkShowLicenseHistory.Enabled = true;
            }
            else
            {
                MessageBox.Show("This International License had not saved Successfuly");
                btnlinkShowLicenseInfo.Enabled = false;
                btnlinkShowLicenseHistory.Enabled = false;
            }

        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            InterLicenseAdded?.Invoke(this, e);
            this.Close();
        }

        private void btnlinkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InternationalLicenseInfoForm frm = new InternationalLicenseInfoForm(_InternationalLicenseID);
            frm.Show();
        }

        private void btnlinkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(_LocalLicense);
            frm.Show();
        }
    }
}
