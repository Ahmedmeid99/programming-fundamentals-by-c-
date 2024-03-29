﻿using System;

using System.Data;
using DVLDBusinessLayer;

using System.Windows.Forms;

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
            frmAdd_Update.Show();
            _RefreshLDLAppsList();
        }

        private void cmEditApplication_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            AddEditLocalApp frmAdd_Update = new AddEditLocalApp(LDLAppID);
            frmAdd_Update.Show();
            _RefreshLDLAppsList();
        }

        private void cmDeleteApplication_Click(object sender, EventArgs e)
        {
            int LDLAppID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you want to delete contact [ " + LDLAppID + " ]", "delete contact", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (clsLocalDLApplication.Delete(LDLAppID))
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
            int LDLAppID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            clsLocalDLApplication CurrentApplication = clsLocalDLApplication.Find(LDLAppID);
            if (clsLocalDLApplication.CancelApplication(CurrentApplication.ApplicationID,(byte) Global.enApplicationStatus.CancledApplication))
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
                FilterString = "LDLAppID = ";
                FilterString += txtFilter.Text;
            }  
            
            // fix if txtFilter is Empty 
            else if (string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";
           
            // if filterType is Number
            else if (cmbFilter.Text == "LDLAppID")
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
            if (cmbFilter.Text == "LDLAppID")
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

            int LDLAppID = (int)dgvLDLApps.CurrentRow.Cells[0].Value;
            clsLocalDLApplication CurrentApplication = clsLocalDLApplication.Find(LDLAppID);

            if (CurrentApplication == null)
                return;

            if(CurrentApplication.ApplicationStatus ==(byte) Global.enApplicationStatus.CancledApplication)
            {
                cmpApplication.Items["cmShowApplication"].Enabled = false;
                cmpApplication.Items["cmEditApplication"].Enabled = false;
                cmpApplication.Items["cmDeleteApplication"].Enabled = false;
                cmpApplication.Items["cmCancelApplication"].Enabled = false;
                cmpApplication.Items["cmSechduleTests"].Enabled = false;
                cmpApplication.Items["cmIssueDriving"].Enabled = false;
                cmpApplication.Items["cmShowLicense"].Enabled = false;
              //  cmpApplication.Items["cmShowPersonHistory"].Visible = false;
            }
            else
            {
                cmpApplication.Items["cmShowApplication"].Enabled = true;
                cmpApplication.Items["cmEditApplication"].Enabled = true;
                cmpApplication.Items["cmDeleteApplication"].Enabled = true;
                cmpApplication.Items["cmCancelApplication"].Enabled = true;
                cmpApplication.Items["cmSechduleTests"].Enabled = true;
                cmpApplication.Items["cmIssueDriving"].Enabled = true;
                cmpApplication.Items["cmShowLicense"].Enabled = true;
              //  cmpApplication.Items["cmShowPersonHistory"].Visible = false;

            }

            // Show context  Menue in current poistion
            dgvLDLApps.ContextMenuStrip.Show(Cursor.Position);

            

        }
        private void dgvLDLApps_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _handleContetxMenue(sender, e);
        }
    }
}
