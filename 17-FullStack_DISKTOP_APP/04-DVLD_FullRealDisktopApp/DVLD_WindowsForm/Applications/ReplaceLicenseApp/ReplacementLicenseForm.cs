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

namespace DVLD_WindowsForm.Applications.ReplaceLicenseApp
{
    public partial class ReplacementLicenseForm : Form
    {

        // private int _OldLicenseID;
        private clsLicense _OldLicense;

        private int _ReplaceLicenseID;
        private clsLicense _ReplaceLicense;

        private enum enReplacementType
        {
            ReplacementForDamagedLicense = 1,
            ReplacementForLostLicense = 2
        }

        private enReplacementType _ReplacementType = enReplacementType.ReplacementForDamagedLicense;
        //-----------------------------------
        //---------Delegation----------------
        //-----------------------------------
        public delegate void ReplaceLicenseAddedEventHandler(object sender, EventArgs e);
        public event ReplaceLicenseAddedEventHandler ReplaceLicenseAdded;

        public ReplacementLicenseForm()
        {
            InitializeComponent();
        }
        
        public ReplacementLicenseForm(GlobalEnums.enApplicationType ApplicationType)
        {
            InitializeComponent();

            btnlinkShowLicenseInfo.Enabled = false;
            btnlinkShowLicenseHistory.Enabled = false;

            if (ApplicationType == GlobalEnums.enApplicationType.ReplaceDamagedDrivingLicense)
            {
                rdDamageLicense.Checked = true;
                _ReplacementType = enReplacementType.ReplacementForDamagedLicense;
                this.Text = "Replacement License for Damage";
                lbReplacementTypeTitle.Text = "Replacement for Damaged License";

            }
            else if (ApplicationType == GlobalEnums.enApplicationType.ReplaceLostDrivingLicense)
            {
                rdLostLicense.Checked = true;
                _ReplacementType = enReplacementType.ReplacementForLostLicense;
                this.Text = "Replacement License for Lost";
                lbReplacementTypeTitle.Text = "Replacement for Losted License";
            }

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

            _ReplaceLicense = new clsLicense();

            // fill Controls
            ucShoLicenseInfo.FillControlsWithData(_OldLicense);
            ucReplacementApplication.FillControlsWithData(_OldLicense,_GetApplicationType(_ReplacementType));

            btnlinkShowLicenseHistory.Enabled = true;

        }

        
        private GlobalEnums.enApplicationType _GetApplicationType(enReplacementType ReplacementType)
        {
            switch (ReplacementType)
            {
                case enReplacementType.ReplacementForDamagedLicense:
                    return GlobalEnums.enApplicationType.ReplaceDamagedDrivingLicense;
                case enReplacementType.ReplacementForLostLicense:
                    return GlobalEnums.enApplicationType.ReplaceLostDrivingLicense;
                default:
                    return GlobalEnums.enApplicationType.ReplaceDamagedDrivingLicense;
            }
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
            clsLicense NewLicense =
                _OldLicense.Replace(_GetApplicationType(_ReplacementType),
                Global.GlobalVars.CurrentUser.UserID);

            if (NewLicense == null)
            {
                MessageBox.Show("Faild to Replace the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ucReplacementApplication.SetReplaceLicenseAppIDUI(NewLicense.ApplicationInfo.ApplicationID);
            _ReplaceLicenseID = NewLicense.LicenseID;
            _ReplaceLicense = clsLicense.Find(_ReplaceLicenseID);
            ucReplacementApplication.SetNewLicenseIDUI(_ReplaceLicenseID);

            MessageBox.Show("Licensed Replaceed Successfully with ID=" + _ReplaceLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnReplace.Enabled = false;
            btnlinkShowLicenseInfo.Enabled = true;


        }

        private void UpdateReplacementType(object sender, EventArgs e)
        {
            
            if(rdDamageLicense.Checked)
            {
                this.Text = "Replacement License for Damage";
                lbReplacementTypeTitle.Text = "Replacement for Damaged License";
                _ReplacementType = enReplacementType.ReplacementForDamagedLicense;
                ucReplacementApplication.SetApplicationFees(GlobalEnums.enApplicationType.ReplaceDamagedDrivingLicense);

            }
            else if(rdLostLicense.Checked)
            {
                this.Text = "Replacement License for Lost";
                lbReplacementTypeTitle.Text = "Replacement for Losted License";
                _ReplacementType = enReplacementType.ReplacementForLostLicense;
                ucReplacementApplication.SetApplicationFees(GlobalEnums.enApplicationType.ReplaceLostDrivingLicense);
            }

        }

        private void btnlinkShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ShowLicenseForm frm = new ShowLicenseForm(_ReplaceLicense);
            frm.Show();
        }

        private void btnlinkShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LicensesHistoryForm frm = new LicensesHistoryForm(_ReplaceLicense);
            frm.Show();
        }


        private void btnReplace_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            ReplaceLicenseAdded?.Invoke(this, e);
            this.Close();
        }

       
    }
}
