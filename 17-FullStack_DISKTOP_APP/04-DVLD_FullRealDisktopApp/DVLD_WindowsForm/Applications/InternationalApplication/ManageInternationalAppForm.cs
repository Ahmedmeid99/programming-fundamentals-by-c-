using System;
using System.Data;
using DVLDBusinessLayer;
using System.Windows.Forms;
using DVLDBusinessLayer.Licenses;
using DVLD_WindowsForm.Licenses;
using DVLD_WindowsForm.Licenses.InternationalLicense;

namespace DVLD_WindowsForm.Applications.InternationalApplication
{
    public partial class ManageInternationalAppForm : Form
    {
       

        public static DataTable dtIDLApps;
        public static DataView dtIDLAppsView;

        public ManageInternationalAppForm()
        {
            InitializeComponent();

            // CenterToParent this form
            this.StartPosition = FormStartPosition.CenterScreen;
            dgvIDLApps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // load data
            _RefreshIDLAppsList();
            _LoadCmbFilterIDLApps();

            cmbActive.Visible = false;

        }


        private void _LoadCmbFilterIDLApps()
        {

            foreach (DataColumn column in dtIDLApps.Columns)
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
                FilterString = "InterLicenseID = ";
                FilterString += txtFilter.Text;
            }

            // fix if txtFilter is Empty 
            else if (string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";

            // if filterType is Number
            else if (cmbFilter.Text == "InterLicenseID" || cmbFilter.Text == "ApplicationID" || cmbFilter.Text == "DriverID" || cmbFilter.Text == "L_LicenseID")
            {
                if (txtFilter.Text != "")
                    FilterString = $"{cmbFilter.SelectedItem} = {txtFilter.Text}";
                else
                    FilterString = "";
            }

            // if filterType is String
            else if ( cmbFilter.Text == "FullName")
            {
                if (txtFilter.Text != "")
                    FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";
                else
                    FilterString = "";
            }

            // else will fix by comboBox when SelectedIndexChanged
            if (!string.IsNullOrEmpty(FilterString) && !string.IsNullOrEmpty(txtFilter.Text))
                dtIDLAppsView.RowFilter = FilterString;
            else
                dtIDLAppsView.RowFilter = "";

            _RefreshIDLAppsCount();
        }
        private void _RefreshIDLAppsCount()
        {
            lbIDLAppsCount.Text = dgvIDLApps.RowCount.ToString();
        }

        private void _RefreshIDLAppsList()
        {
            dtIDLApps = clsInternationalLicense.GetAllInternationalLicenses();
            dtIDLAppsView = new DataView(dtIDLApps);
            dgvIDLApps.DataSource = dtIDLAppsView;

            _RefreshIDLAppsCount();
        }

       
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // onchange update data grid view 
            _RefreshIDLAppsList();

            if (dtIDLApps.Columns.Count > 0 && dtIDLApps.Rows.Count > 0)
            {
                _FilterDtView();
            }
            // refresh => _RefreshIDLAppsList();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "InterLicenseID" || cmbFilter.Text == "ApplicationID" || cmbFilter.Text == "DriverID" || cmbFilter.Text == "L_LicenseID")
            {
                if (!GlobalMethods.CheckIsDigit(e))
                    e.Handled = true; // ignore the input char;
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "IsActive")
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
                FilterString = "IsActive = true";
            else if (cmbActive.Text == "No")
                FilterString = "IsActive = false";
            else
                FilterString = ""; // Mean All

            dtIDLAppsView.RowFilter = FilterString;

            _RefreshIDLAppsCount();

        }

        private void cmShowLicense_Click_1(object sender, EventArgs e)
        {
            int IDLApplicationID = (int)dgvIDLApps.CurrentRow.Cells[0].Value;

            InternationalLicenseInfoForm frm = new InternationalLicenseInfoForm(IDLApplicationID);
            frm.Show();

        }

        private void cmShowPersonHistory_Click_1(object sender, EventArgs e)
        {
            // Show form
            int IDLApplicationID = (int)dgvIDLApps.CurrentRow.Cells[0].Value;
            clsInternationalLicense IDLApplication = clsInternationalLicense.Find(IDLApplicationID);
            clsLicense License = clsLicense.Find(IDLApplication.IssuedUsingLocalLicenseID);

            LicensesHistoryForm frm = new LicensesHistoryForm(License);   // localLicense
            frm.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // AddNewApplication
            AddInternarionalAppForm frm = new AddInternarionalAppForm();
            frm.InterLicenseAdded += InterLicense_InterLicenseAdded;
            frm.Show();

        }

        private void InterLicense_InterLicenseAdded(object sender, EventArgs e)
        {
            _RefreshIDLAppsList();
        }

        private void cmShowPersonDetails_Click(object sender, EventArgs e)
        {
            int IDLApplicationID = (int)dgvIDLApps.CurrentRow.Cells[0].Value;
            clsLocalDLApplication IDLApplication = clsLocalDLApplication.Find(IDLApplicationID);
            ShowPersonForm frm = new ShowPersonForm(IDLApplication.ApplicationPersonID);
            frm.Show();

        }
    }
}
