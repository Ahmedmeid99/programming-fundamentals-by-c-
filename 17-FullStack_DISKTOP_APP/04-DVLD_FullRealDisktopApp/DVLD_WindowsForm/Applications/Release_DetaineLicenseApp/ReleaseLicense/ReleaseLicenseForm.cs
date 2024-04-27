using DVLD_WindowsForm.Licenses;
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

namespace DVLD_WindowsForm.Applications.Release_DetaineLicenseApp.ReleaseLicense
{
    public partial class ReleaseLicenseForm : Form
    {
        public ReleaseLicenseForm()
        {
            InitializeComponent();

            btnlinkShowLicenseInfo.Enabled = false;
            btnlinkShowLicenseHistory.Enabled = false;
        }    
        public ReleaseLicenseForm(int licenseID)
        {
            InitializeComponent();

            txtFindLicense.Text = licenseID.ToString();
            _LoadForm(licenseID);

            gbFilterBox.Enabled = false;

            btnlinkShowLicenseInfo.Enabled = false;
            btnlinkShowLicenseHistory.Enabled = false;
        }

        // private int _OldLicenseID;
        private clsLicense _OldLicense;

        private int _ReleaseLicenseID;
        private clsReleasedLicense _ReleaseLicense; 
        
       // private int _DetainedLicenseID;
        private clsDetainedLicense _DetainedLicense;

        private double _FineFees, _ApplicationFees ,_TotalFees;


        //-----------------------------------
        //---------Delegation----------------
        //-----------------------------------
        public delegate void ReleasedLicenseAddedEventHandler(object sender, EventArgs e);
        public event ReleasedLicenseAddedEventHandler ReleasedLicenseAdded;

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            int licenseID = Convert.ToInt32(txtFindLicense.Text);
            _LoadForm(licenseID);

        }
        private void _LoadForm(int licenseID)
        {
            _OldLicense = clsLicense.Find(licenseID);

            if (_OldLicense == null)
            {

                MessageBox.Show("This License is not Exists");
                return;
            }
            else if (_OldLicense.IsDetained != true)
            {

                MessageBox.Show("This License is not Detained");
                return;
            }

            _ReleaseLicense = new clsReleasedLicense();

            // find detainedLicense
            _DetainedLicense = clsDetainedLicense.FindDetainedLicense(_OldLicense.LicenseID);

            // fill Controls
            ucShoLicenseInfo.FillControlsWithData(_OldLicense);

            _ApplicationFees = clsApplicationType.Find((int)GlobalEnums.enApplicationType.ReleaseDetainedLicense).Fees;
            _FineFees = _DetainedLicense.FineFees;
            _TotalFees = _ApplicationFees + _FineFees;

            // fill Detain controls
            lbLicenseID.Text = _OldLicense.LicenseID.ToString();
            lbDetainID.Text = _DetainedLicense.DetainID.ToString();
            lbDetainDate.Text = _ReleaseLicense.ReleasedDate.ToString("dd-MM-yyyy");
            lbCreatedBy.Text = _OldLicense.UserInfo.UserID.ToString();
            lbApplicationFees.Text = _ApplicationFees.ToString();
            lbFineFees.Text = _FineFees.ToString();
            lbTotalFees.Text = _TotalFees.ToString();
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

            

            //  Fill Application obj 
            clsReleasedLicense ReleaseLicense =
                _OldLicense.Release(_DetainedLicense.DetainID, _TotalFees, // total fees
                Global.GlobalVars.CurrentUser.UserID);

            if (ReleaseLicense == null)
            {
                MessageBox.Show("Faild to Detain the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _ReleaseLicenseID = ReleaseLicense.LicenseID;
            _ReleaseLicense = clsReleasedLicense.FindDetainedLicense(_ReleaseLicenseID);

            // set  DetainAppID UI ....
            lbReleaseAppID.Text = ReleaseLicense.ReleaseApplicationID.ToString();

            MessageBox.Show("Licensed Detained Successfully with ID=" + _ReleaseLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            btnlinkShowLicenseInfo.Enabled = true;


        }



        
        private void btnlinkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseForm frm = new ShowLicenseForm(_OldLicense);
            frm.Show();
        }

        private void btnlinkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(_OldLicense);
            frm.Show();

        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click_1(object sender, EventArgs e)
        {
            ReleasedLicenseAdded?.Invoke(this, e);
            this.Close();
        }

    }
}
