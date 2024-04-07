using System;

using System.Data;
using DVLDBusinessLayer;


using System.Windows.Forms;
using DVLD_WindowsForm.Tests.VisionTest;
using DVLD_WindowsForm.Tests.WrittenTest;
using DVLD_WindowsForm.Tests.StreetTest;
using DVLDBusinessLayer.Drivers;
using DVLDBusinessLayer.Licenses;
using DVLD_WindowsForm.Licenses;

namespace DVLD_WindowsForm.Applications.LocalApplication
{
    public partial class ManageLocalDLApplication : Form
    {
        public static DataTable dtLDLApps;
        public static DataView dtLDLAppsView;

        public ManageLocalDLApplication()
        {
            InitializeComponent();

            // CenterToParent this form
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvLDLApps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // load data
            _RefreshLDLAppsList();
            _LoadCmbFilterLDLApps();


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // AddNewApplication
            AddEditLocalApp frmAdd_Update = new AddEditLocalApp(-1);
            frmAdd_Update.ApplicationTestAdded += Application_ApplicationTestAdded;
            frmAdd_Update.Show();
            _RefreshLDLAppsList();
        }

        private void cmEditApplication_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            AddEditLocalApp frmAdd_Update = new AddEditLocalApp(LDLApplicationID);
            frmAdd_Update.ApplicationTestAdded += Application_ApplicationTestAdded;
            frmAdd_Update.Show();
            _RefreshLDLAppsList();
        }

        private void cmDeleteApplication_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you want to delete contact [ " + LDLApplicationID + " ]", "delete contact", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsLocalDLApplication.Delete(LDLApplicationID))
                {
                    _RefreshLDLAppsList();
                    MessageBox.Show("Application Deleted Succesfuly");
                }
                else
                {
                    MessageBox.Show("Application is not Deleted");
                }
            }
        }

        private void cmCancelApplication_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            clsLocalDLApplication CurrentApplication = clsLocalDLApplication.Find(LDLApplicationID);
            if (clsLocalDLApplication.CancelApplication(CurrentApplication.ApplicationID,(byte) GlobalEnums.enApplicationStatus.CancledApplication,CurrentApplication.PassedTests))
            {
                _RefreshLDLAppsList();
                MessageBox.Show("Application Cancelled Succesfuly");
            }
            else
            {
                MessageBox.Show("Application is not Cancelled");
            }
        }

        // ----------------


        private void _LoadCmbFilterLDLApps()
        {

            foreach (DataColumn column in dtLDLApps.Columns)
            {
                if(column.ColumnName != "ApplicationDate")
                    cmbFilter.Items.Add(column.ColumnName);
            }

            if (cmbFilter.Items.Count > 0)
                cmbFilter.SelectedIndex = 0;

        }


        private void _FilterDtView()
        {
            string FilterString = "";
            
            // fix if Wase not selected 
            if (cmbFilter.SelectedItem == null)
            {
                FilterString = "LDLApplicationID = ";
                FilterString += txtFilter.Text;
            }  
            
            // fix if txtFilter is Empty 
            else if (string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";
           
            // if filterType is Number
            else if (cmbFilter.Text == "LDLApplicationID")
            {
                if (txtFilter.Text != "")
                    FilterString = $"{cmbFilter.SelectedItem} = {txtFilter.Text}";
                else
                    FilterString = "";
            }

            // if filterType is String
            else if (cmbFilter.Text == "ClassName" || cmbFilter.Text == "NationalNo"|| cmbFilter.Text == "FullName" || cmbFilter.Text == "ApplicationStatus")
            {
                if (txtFilter.Text != "")
                    FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";
                else
                    FilterString = "";
            }

            // else will fix by comboBox when SelectedIndexChanged
            if (!string.IsNullOrEmpty(FilterString) && !string.IsNullOrEmpty(txtFilter.Text)) 
                dtLDLAppsView.RowFilter = FilterString;
            else
                dtLDLAppsView.RowFilter = "";

            _RefreshLDLppsCount();
        }
        private void _RefreshLDLppsCount()
        {
            lbLDLAppsCount.Text = dgvLDLApps.RowCount.ToString();
        }
        
        private void _RefreshLDLAppsList()
        {
            dtLDLApps = clsLocalDLApplication.GetAllLocalApplications();
            dtLDLAppsView = new DataView(dtLDLApps);
            dgvLDLApps.DataSource = dtLDLAppsView;

            _RefreshLDLppsCount();
        }
       
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // onchange update data grid view 
            _RefreshLDLAppsList();

            if (dtLDLApps.Columns.Count > 0 && dtLDLApps.Rows.Count > 0)
            {
                _FilterDtView();
            }
            // refresh => _RefreshLDLAppsList();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "LDLApplicationID")
            {

                if (!GlobalMethods.CheckIsDigit(e))
                    e.Handled = true; // ignore the input char;
            }
        }

        private void ManageLocalDLApplication_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshLDLAppsList();
        }

        // handle Contetx Menue

        private void _handleContetxMenue(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.Button != MouseButtons.Right)
                return;

            
            // Select Row
            dgvLDLApps.ClearSelection();
            dgvLDLApps.Rows[e.RowIndex].Selected = true;

            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            clsLocalDLApplication CurrentApplication = clsLocalDLApplication.Find(LDLApplicationID);

            if (CurrentApplication == null)
                return;

            if (CurrentApplication.PassedTests == (byte)GlobalEnums.enApplicationPassedTests.NoTestsPassed)
            {
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmVisionTest"].Enabled = true;
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmWrittenTest"].Enabled = false;
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmStreetTest"].Enabled = false;
                cmpApplication.Items["cmSechduleTests"].Enabled = true;

            }
            else if (CurrentApplication.PassedTests == (byte)GlobalEnums.enApplicationPassedTests.PassedVissionTest)
            {
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmVisionTest"].Enabled = false;
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmWrittenTest"].Enabled = true;
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmStreetTest"].Enabled = false;
                cmpApplication.Items["cmSechduleTests"].Enabled = true;
            }
            else if (CurrentApplication.PassedTests == (byte)GlobalEnums.enApplicationPassedTests.PassedWrittenTest)
            {
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmVisionTest"].Enabled = false;
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmWrittenTest"].Enabled = false;
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmStreetTest"].Enabled = true;
                cmpApplication.Items["cmSechduleTests"].Enabled = true;
            }
            else if (CurrentApplication.PassedTests == (byte)GlobalEnums.enApplicationPassedTests.PassedStreetTest)
            {
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmVisionTest"].Enabled = false;
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmWrittenTest"].Enabled = false;
                ((ToolStripMenuItem)cmpApplication.Items["cmSechduleTests"]).DropDownItems["cmStreetTest"].Enabled = false;
                cmpApplication.Items["cmSechduleTests"].Enabled = false;
            }

            if (CurrentApplication.ApplicationStatus ==(byte) GlobalEnums.enApplicationStatus.CancledApplication)
            {
                cmpApplication.Items["cmShowApplication"].Enabled = false;
                cmpApplication.Items["cmEditApplication"].Enabled = false;
                cmpApplication.Items["cmCancelApplication"].Enabled = false;
                cmpApplication.Items["cmDeleteApplication"].Enabled = true;
                cmpApplication.Items["cmSechduleTests"].Enabled = false;
                cmpApplication.Items["cmIssueDriving"].Enabled = false;
                cmpApplication.Items["cmShowLicense"].Enabled = false;
                cmpApplication.Items["cmShowPersonHistory"].Enabled = true;
            }

            else if (CurrentApplication.ApplicationStatus == (byte)GlobalEnums.enApplicationStatus.CompletedApplication)
            {
                cmpApplication.Items["cmEditApplication"].Enabled = false;
                cmpApplication.Items["cmDeleteApplication"].Enabled = false;
                cmpApplication.Items["cmCancelApplication"].Enabled = false;
                cmpApplication.Items["cmSechduleTests"].Enabled = false;

                // if he has a License  disable cmIssueDriving
                // else enable it
                if (clsLicense.IsApplicationExists(CurrentApplication.ApplicationID))
                    cmpApplication.Items["cmIssueDriving"].Enabled = false;
                else
                    cmpApplication.Items["cmIssueDriving"].Enabled = true;

                // if he has a License History disable cmIssueDriving
                // else enable it
                cmpApplication.Items["cmShowLicense"].Enabled = true;

            }
            else
            {
                // New status
                cmpApplication.Items["cmShowApplication"].Enabled = true;
                cmpApplication.Items["cmEditApplication"].Enabled = true;
                cmpApplication.Items["cmDeleteApplication"].Enabled = true;
                cmpApplication.Items["cmCancelApplication"].Enabled = true;
                cmpApplication.Items["cmSechduleTests"].Enabled = true;
                cmpApplication.Items["cmIssueDriving"].Enabled = false;
                cmpApplication.Items["cmShowLicense"].Enabled = false;
                cmpApplication.Items["cmShowPersonHistory"].Enabled = true;

            }

            //  handle cmShowPersonHistory

            // Show context  Menue in current poistion
            dgvLDLApps.ContextMenuStrip.Show(Cursor.Position);

            

        }
        private void dgvLDLApps_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _handleContetxMenue(sender, e);
        }

        private void ManageLocalDLApplication_Load_1(object sender, EventArgs e)
        {

        }

        private void cmVisionTest_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            ManageVisionTestForm ManageVisionTestFrm = new ManageVisionTestForm(LDLApplicationID);
            ManageVisionTestFrm.ApplicationTestAdded += Application_ApplicationTestAdded;
            ManageVisionTestFrm.Show();      
        }

        private void cmWrittenTest_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            ManageWrittenTestForm ManageWrittenTestFrm = new ManageWrittenTestForm(LDLApplicationID);
            ManageWrittenTestFrm.ApplicationTestAdded += Application_ApplicationTestAdded;
            ManageWrittenTestFrm.Show();

        }

        private void cmStreetTest_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            ManageStreetTestForm ManageStreetTestFrm = new ManageStreetTestForm(LDLApplicationID);
            ManageStreetTestFrm.ApplicationTestAdded += Application_ApplicationTestAdded;
            ManageStreetTestFrm.Show();
        }

        private void Application_ApplicationTestAdded(object sender, EventArgs e)
        {
            _RefreshLDLAppsList();
        }

        private void _FillDriverWithData(ref clsDriver Driver,clsLocalDLApplication LDLApplication)
        {
            Driver.PersonInfo = clsPerson.Find(LDLApplication.ApplicationPersonID);
            Driver.UserInfo = clsUser.Find(Global.GlobalVars.CurrentUser.UserID);
            Driver.CreatedDate = DateTime.Now;

        } 
        private void _FillLicenseWithData(ref clsLicense License, int DriverID,clsLocalDLApplication LDLApplication)
        {
            License.ApplicationInfo = clsApplication.FindApplication(LDLApplication.ApplicationID);
            License.LicenseClassInfo = clsLicenseClass.Find(LDLApplication.LicenseClassID);
            License.DriverInfo = clsDriver.Find(DriverID);
            License.IssueReason =(byte) GlobalEnums.enApplicationType.NewLocalApp;
            License.PaidFees = License.LicenseClassInfo.ClassFees;
            License.UserInfo = clsUser.Find(Global.GlobalVars.CurrentUser.UserID);
            License.Notes = "";
            License.IsActive = true;
            License.IssueDate = DateTime.Now;
            License.ExpirationDate = License.IssueDate.AddYears(License.LicenseClassInfo.DefaultValidityLength);

        }
        private void cmIssueDriving_Click(object sender, EventArgs e)
        {
            // IF Application Completed status
            // - create New Driver if Not Exist
            // - Create New License
            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            clsLocalDLApplication LDLApplication = clsLocalDLApplication.Find(LDLApplicationID);

            clsDriver Driver = new clsDriver();
            _FillDriverWithData (ref Driver, LDLApplication);

            if (!clsDriver.IsPersonExists(Driver.PersonInfo.PersonID))
            {
                if (Driver.Save() )
                    MessageBox.Show($"Driver Added Successfly DriverID = {Driver.DriverID}");
            }
            else
            {
                MessageBox.Show($"Driver IsExists DriverID = {Driver.DriverID}");
                Driver = clsDriver.FindPerson(Driver.PersonInfo.PersonID);
            }
               


            clsLicense License = new clsLicense();
            _FillLicenseWithData(ref License, Driver.DriverID, LDLApplication);

            if (!clsLicense.IsApplicationExists(LDLApplication.ApplicationID))
            {
                if (License.Save())
                    MessageBox.Show($"and Driving License Added Successfly LicenseID = {License.LicenseID}");
            }
            else
                MessageBox.Show($"License IsExists LicenseID = {License.LicenseID}");
        }

        private void cmShowLicense_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            clsLocalDLApplication LDLApplication = clsLocalDLApplication.Find(LDLApplicationID);

            if (clsLicense.IsApplicationExists(LDLApplication.ApplicationID))
            {
                clsLicense License = clsLicense.FindByApplicationID(LDLApplication.ApplicationID);
                ShowLicenseForm frm = new ShowLicenseForm(License);
                frm.Show();
            }
        }

        private void cmShowPersonHistory_Click(object sender, EventArgs e)
        {
            // Show form
        }
    }
}
