using DVLD_WindowsForm.Applications.InternationalApplication;
using DVLD_WindowsForm.Applications.Release_DetaineLicenseApp.DetainLicense;
using DVLD_WindowsForm.Applications.Release_DetaineLicenseApp.ReleaseLicense;
using DVLD_WindowsForm.Licenses;
using DVLD_WindowsForm.Licenses.InternationalLicense;
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

namespace DVLD_WindowsForm.Applications.Release_DetaineLicenseApp
{
    public partial class ManageDetainedLicensesForm : Form
    {


        public static DataTable dtDetainedLicenses;
        public static DataView dtDetainedLicensesView;

        public ManageDetainedLicensesForm()
        {
            InitializeComponent();

            // CenterToParent this form
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvDetainedLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // load data
            _RefreshIDLAppsList();
            _LoadCmbFilterIDLApps();

            cmbActive.Visible = false;

        }


        private void _LoadCmbFilterIDLApps()
        {

            foreach (DataColumn column in dtDetainedLicenses.Columns)
            {
                if (!column.ColumnName.Contains("Date"))
                    cmbFilter.Items.Add(column.ColumnName);
            }

            if (cmbFilter.Items.Count > 0)
            {
                cmbFilter.SelectedIndex = 0;
                cmbActive.SelectedIndex = 0;
            }

        }


        private void _FilterDtView()
        {
            string FilterString = "";

            // fix if Wase not selected 
            if (cmbFilter.SelectedItem == null)
            {
                FilterString = "DetainID = ";
                FilterString += txtFilter.Text;
            }

            // fix if txtFilter is Empty 
            else if (string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";

            // if filterType is Number
            else if (cmbFilter.Text == "DetainID" || cmbFilter.Text == "LicenseID" || cmbFilter.Text == "FineFees" || cmbFilter.Text == "ReleaseApplicationID")
            {
                if (txtFilter.Text != "")
                    FilterString = $"{cmbFilter.SelectedItem} = {txtFilter.Text}";
                else
                    FilterString = "";
            }

            // if filterType is String
            else if (cmbFilter.Text == "FullName" || cmbFilter.Text == "NationalNo")
            {
                if (txtFilter.Text != "")
                    FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";
                else
                    FilterString = "";
            }

            // else will fix by comboBox when SelectedIndexChanged
            if (!string.IsNullOrEmpty(FilterString) && !string.IsNullOrEmpty(txtFilter.Text))
                dtDetainedLicensesView.RowFilter = FilterString;
            else
                dtDetainedLicensesView.RowFilter = "";

            _RefreshIDLAppsCount();
        }
        private void _RefreshIDLAppsCount()
        {
            lbDetainedLicensesCount.Text = dgvDetainedLicenses.RowCount.ToString();
        }

        private void _RefreshIDLAppsList()
        {
            dtDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            dtDetainedLicensesView = new DataView(dtDetainedLicenses);
            dgvDetainedLicenses.DataSource = dtDetainedLicensesView;

            _RefreshIDLAppsCount();
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // onchange update data grid view 
            _RefreshIDLAppsList();

            if (dtDetainedLicenses.Columns.Count > 0 && dtDetainedLicenses.Rows.Count > 0)
            {
                _FilterDtView();
            }
            // refresh => _RefreshIDLAppsList();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "DetainID" || cmbFilter.Text == "LicenseID" || cmbFilter.Text == "FineFees" || cmbFilter.Text == "ReleaseApplicationID")
            {
                if (!GlobalMethods.CheckIsDigit(e))
                    e.Handled = true; // ignore the input char;
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "IsReleased")
            {
                cmbActive.Visible = true;
                txtFilter.Visible = false;
            }
            else
            {
                cmbActive.Visible = false;
                txtFilter.Visible = true;
            }
        }

        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshIDLAppsList();

            string FilterString = "";

            if (cmbActive.Text == "Yes")
                FilterString = "IsReleased = true";
            else if (cmbActive.Text == "No")
                FilterString = "IsReleased = false";
            else
                FilterString = ""; // Mean All

            dtDetainedLicensesView.RowFilter = FilterString;

            _RefreshIDLAppsCount();

        }






        private void DetainedLicense_DetainedLicenseUpdated(object sender, EventArgs e)
        {
            _RefreshIDLAppsList();
        }


        private void pbtnDetain_Click(object sender, EventArgs e)
        {
            // AddNewApplication
            DetainLicenseForm frm = new DetainLicenseForm();
            frm.DetainLicenseAdded += DetainedLicense_DetainedLicenseUpdated;
            frm.Show();
        }

        private void pbtnRelease_Click(object sender, EventArgs e)
        {
            // AddNewApplication
            ReleaseLicenseForm frm = new ReleaseLicenseForm();
            frm.ReleasedLicenseAdded += DetainedLicense_DetainedLicenseUpdated;
            frm.Show();
        }

        private void cmShowPersonDetails_Click_1(object sender, EventArgs e)
        {
            int LiceneID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            clsDetainedLicense DetainedLicense = clsDetainedLicense.FindDetainedLicense(LiceneID);
            ShowPersonForm frm = new ShowPersonForm(DetainedLicense.PersonID);
            frm.Show();
        }

        private void cmShowLicense_Click(object sender, EventArgs e)
        {
            int LiceneID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            clsLicense License = clsLicense.Find(LiceneID);

            ShowLicenseForm frm = new ShowLicenseForm(License);
            frm.Show();
        }

        private void cmShowPersonHistory_Click(object sender, EventArgs e)
        {
            // Show form
            int LiceneID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            clsLicense License = clsLicense.Find(LiceneID);

            LicensesHistoryForm frm = new LicensesHistoryForm(License);   // localLicense
            frm.Show();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // AddNewApplication
            int LiceneID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            ReleaseLicenseForm frm = new ReleaseLicenseForm(LiceneID);
            frm.ReleasedLicenseAdded += DetainedLicense_DetainedLicenseUpdated;
            frm.Show();
        }

        private void dgvDetainedLicenses_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            _handleContetxMenue(sender, e);
        }
        private void _handleContetxMenue(object sender, DataGridViewCellMouseEventArgs e)
        {
            
            if (e.Button != MouseButtons.Right)
                return;
            
            // Select Row
            dgvDetainedLicenses.ClearSelection();
            dgvDetainedLicenses.Rows[e.RowIndex].Selected = true;

            int LicenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            clsDetainedLicense CurrentDetainedLicense = clsDetainedLicense.FindDetainedLicense(LicenseID);

            if (CurrentDetainedLicense == null)
                return;

            if (CurrentDetainedLicense.IsReleased == true)
            {
                cmpDetainedLicense.Items["cmReleaseDetainedLicense"].Enabled = false;

            }  else
                cmpDetainedLicense.Items["cmReleaseDetainedLicense"].Enabled = true;

            
            // Show context  Menue in current poistion
            dgvDetainedLicenses.ContextMenuStrip.Show(Cursor.Position);

}
    }
}
