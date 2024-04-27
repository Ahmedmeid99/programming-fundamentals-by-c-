using DVLD_WindowsForm.Licenses;
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

namespace DVLD_WindowsForm.Applications.Release_DetaineLicenseApp.DetainLicense
{
    public partial class DetainLicenseForm : Form
    {
        public DetainLicenseForm()
        {
            InitializeComponent();

            btnlinkShowLicenseInfo.Enabled = false;
            btnlinkShowLicenseHistory.Enabled = false;

        }     
        public DetainLicenseForm(int licenseID)
        {
            InitializeComponent();

            _OldLicense = clsLicense.Find(licenseID);

            gbFilterBox.Enabled = false;

            btnlinkShowLicenseInfo.Enabled = false;
            btnlinkShowLicenseHistory.Enabled = false;

        }

            // private int _OldLicenseID;
        private clsLicense _OldLicense;

        private int _DetainLicenseID;
        private clsDetainedLicense _DetainLicense;


        //-----------------------------------
        //---------Delegation----------------
        //-----------------------------------
        public delegate void DetainLicenseAddedEventHandler(object sender, EventArgs e);
        public event DetainLicenseAddedEventHandler DetainLicenseAdded;


        private void pictureBox1_Click(object sender, EventArgs e)
        {

            int licenseID = Convert.ToInt32(txtFindLicense.Text);
            _OldLicense = clsLicense.Find(licenseID);

            if (_OldLicense == null)
            {

                MessageBox.Show("This License is not Exists");
                return;
            }

            _DetainLicense = new clsDetainedLicense();

            // fill Controls
            ucShoLicenseInfo.FillControlsWithData(_OldLicense);

            // fill Detain controls
            lbLicenseID.Text = _OldLicense.LicenseID.ToString();
            lbCreatedBy.Text = _OldLicense.UserInfo.UserID.ToString();
            
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
            clsDetainedLicense DetainedLicense =
                _OldLicense.Detain(Convert.ToDouble(txtFineFees.Text.Trim()),
                Global.GlobalVars.CurrentUser.UserID);

            if (DetainedLicense == null)
            {
                MessageBox.Show("Faild to Detain the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _DetainLicenseID = DetainedLicense.LicenseID;
            _DetainLicense = clsDetainedLicense.FindDetainedLicense(_DetainLicenseID);

            // set  DetainAppID UI ....
            lbDetainID.Text = _DetainLicense.DetainID.ToString();
            lbDetainDate.Text = _DetainLicense.DetainedDate.ToString("dd-MM-yyyy");

            MessageBox.Show("Licensed Detained Successfully with ID=" + _DetainLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnDetain.Enabled = false;
            btnlinkShowLicenseInfo.Enabled = true;


        }



        private void btnDetain_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DetainLicenseAdded?.Invoke(this, e);
            this.Close();
        }
        
        private void btnlinkShowLicenseHistory_LinkClicked(object sender, EventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(_OldLicense);
            frm.Show();
        }

        private void btnlinkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseForm frm = new ShowLicenseForm(_OldLicense);
            frm.Show();

        }
    }
}
