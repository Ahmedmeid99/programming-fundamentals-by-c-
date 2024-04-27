using DVLD_WindowsForm.Licenses;
using DVLDBusinessLayer;
using DVLDBusinessLayer.Drivers;
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

namespace DVLD_WindowsForm.Applications.RenewLicenseApplication
{
    public partial class RenewLocalDrivingLicense : Form
    {
        // private int _OldLicenseID;
        private clsLicense _OldLicense;

        private int _RenewLicenseID;
        private clsLicense _RenewLicense;


        //-----------------------------------
        //---------Delegation----------------
        //-----------------------------------
        public delegate void RenewLicenseAddedEventHandler(object sender, EventArgs e);
        public event RenewLicenseAddedEventHandler RenewLicenseAdded;

        public RenewLocalDrivingLicense()
        {
            InitializeComponent();

            btnlinkShowLicenseInfo.Enabled = false;
            btnlinkShowLicenseHistory.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            int licenseID = Convert.ToInt32(txtFindLicense.Text);
            _OldLicense = clsLicense.Find(licenseID);

            if (_OldLicense == null)
            {

                MessageBox.Show("This License is not Exists");
                return;
            }

            _RenewLicense = new clsLicense();

            // fill Controls
            ucShoLicenseInfo.FillControlsWithData(_OldLicense);
            ucRenewLicenseInfo.FillControlsWithData(_OldLicense);

            btnlinkShowLicenseHistory.Enabled = true;

        }
      

        private void _Save()
        {
            // check if License Exist
            if (!clsLicense.IsExists(_OldLicense.LicenseID))
            {
                MessageBox.Show("This License is not Exists");
                return;
            }

            // check if License Date is Expire
            if (!clsLicense.IsExpire(_OldLicense.LicenseID))
            {
                MessageBox.Show($"This License is not Expire Will Expire after {_OldLicense.ExpirationDate - DateTime.Now}");
                return;
            }

            //  Fill Application obj 
            clsLicense NewLicense =
                _OldLicense.Renew(ucRenewLicenseInfo.GetNotesUI().Trim(),
                Global.GlobalVars.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ucRenewLicenseInfo.SetRenewLicenseAppIDUI(NewLicense.ApplicationInfo.ApplicationID);
            _RenewLicenseID = NewLicense.LicenseID;
            _RenewLicense = clsLicense.Find(_RenewLicenseID);
            ucRenewLicenseInfo.SetNewLicenseIDUI(_RenewLicenseID);

            MessageBox.Show("Licensed Renewed Successfully with ID=" + _RenewLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
            btnlinkShowLicenseInfo.Enabled = true;


        }                                                                       
        

        private void btnlinkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseForm frm = new ShowLicenseForm(_RenewLicense);
            frm.Show();
        }

        private void btnlinkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(_RenewLicense);
            frm.Show();
        }


        private void btnRenew_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            RenewLicenseAdded?.Invoke(this, e);
            this.Close();
        }
    }
}
