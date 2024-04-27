using System;
using System.Data;
using DVLDBusinessLayer;

using System.Windows.Forms;
using DVLD_WindowsForm.Applications.LocalApplication;
using DVLD_WindowsForm.Applications.InternationalApplication;
using DVLD_WindowsForm.Applications.RenewLicenseApplication;
using DVLD_WindowsForm.Applications.ReplaceLicenseApp;
using DVLD_WindowsForm.Applications.Release_DetaineLicenseApp.ReleaseLicense;
using DVLD_WindowsForm.Applications.Release_DetaineLicenseApp.DetainLicense;
using DVLD_WindowsForm.Applications.Release_DetaineLicenseApp;
using DVLDBusinessLayer.Global;

namespace DVLD_WindowsForm
{
    public partial class MainForm : Form
    {
        // forms will open once while click on its button many times

        public MainForm()
        {
            InitializeComponent();
            this.IsMdiContainer= true;

            // Check allowed access [ Data, Informations, Actions ]

            if (!GlobalFunctions.CheckAccessPermission(Global.GlobalVars.CurrentUser.Permission, GlobalEnums.enUserPermission.AddEditUsers) &&
            !GlobalFunctions.CheckAccessPermission(Global.GlobalVars.CurrentUser.Permission, GlobalEnums.enUserPermission.DeleteUsers))
                usersToolStripMenuItem.Enabled = false;

            if (!GlobalFunctions.CheckAccessPermission(Global.GlobalVars.CurrentUser.Permission, GlobalEnums.enUserPermission.ManageDrivers))
                driversToolStripMenuItem.Enabled = false;
            
            if (!GlobalFunctions.CheckAccessPermission(Global.GlobalVars.CurrentUser.Permission, GlobalEnums.enUserPermission.ManageDetainedLicenses))
                detainLicensesToolStripMenuItem.Enabled = false; 
            
            if (!GlobalFunctions.CheckAccessPermission(Global.GlobalVars.CurrentUser.Permission, GlobalEnums.enUserPermission.EditApplicationTypes))
                manageApplicationsTypesToolStripMenuItem.Enabled = false; 
            
            if (!GlobalFunctions.CheckAccessPermission(Global.GlobalVars.CurrentUser.Permission, GlobalEnums.enUserPermission.EditTestTypes))
                manageTestTypesToolStripMenuItem.Enabled = false;

        }
        
        
        private void PeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
                Form frmPeople = new Manage_People();
                frmPeople.MdiParent = this;
                frmPeople.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmUsers = new Manage_Users();
            frmUsers.MdiParent = this;
            frmUsers.Show();
        }

        private void currentUserInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowUserForm ShowUserFrm = new ShowUserForm(Global.GlobalVars.CurrentUser.UserID);
            ShowUserFrm.MdiParent = this;
            ShowUserFrm.Show();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChangePasswordForm ChangePasswordFrm = new ChangePasswordForm(Global.GlobalVars.CurrentUser.UserID);
            ChangePasswordFrm.MdiParent = this;
            ChangePasswordFrm.Show();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Global.GlobalVars.CurrentUser = null;
            LoginForm LoginFrm = new LoginForm();
            //LoginFrm.MdiParent = this;
            LoginFrm.Show();
        }

        private void manageApplicationsTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // form 
            ManageApplicationTypesForm ManageAppFrm = new ManageApplicationTypesForm();
            ManageAppFrm.MdiParent = this;
            ManageAppFrm.Show();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageTestTypesForm ManageTestFrm = new ManageTestTypesForm();
            ManageTestFrm.MdiParent = this;
            ManageTestFrm.Show();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddEditLocalApp frmAdd_Update = new AddEditLocalApp(-1);
            frmAdd_Update.Show();

        }

        private void localDrivingLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageLocalDLApplication ManageLocalFrm = new ManageLocalDLApplication();
            ManageLocalFrm.MdiParent = this;
            ManageLocalFrm.Show();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDriversForm frm = new ManageDriversForm();
            frm.MdiParent = this;
            frm.Show();

        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddInternarionalAppForm frm =new AddInternarionalAppForm();
            frm.Show();
        }

        private void internationalLicenseApplicationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageInternationalAppForm frm = new ManageInternationalAppForm();
            frm.Show();
        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RenewLocalDrivingLicense frm = new RenewLocalDrivingLicense();
            frm.Show();

        }

        private void replacementForToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReplacementLicenseForm frm = new ReplacementLicenseForm(GlobalEnums.enApplicationType.ReplaceDamagedDrivingLicense);
            frm.Show();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicenseForm frm = new ReleaseLicenseForm();
            frm.Show();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ManageLocalDLApplication ManageLocalFrm = new ManageLocalDLApplication();
            ManageLocalFrm.MdiParent = this;
            ManageLocalFrm.Show();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DetainLicenseForm frm = new DetainLicenseForm();
            frm.Show();
        }

        private void relaeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReleaseLicenseForm frm = new ReleaseLicenseForm();
            frm.Show();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageDetainedLicensesForm frm = new ManageDetainedLicensesForm();
            frm.Show();
        }

        private void detainLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
