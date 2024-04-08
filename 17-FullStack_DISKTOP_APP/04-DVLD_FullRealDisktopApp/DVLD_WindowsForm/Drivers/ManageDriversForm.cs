using DVLDBusinessLayer.Drivers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WindowsForm
{
    public partial class ManageDriversForm : Form
    {
        public static DataTable dtDrivers;
        public static DataView dtDriversView;

        public ManageDriversForm()
        {
            InitializeComponent();

            // CenterToParent this form
            this.StartPosition = FormStartPosition.CenterScreen;

            

        }

        private void _LoadCmbFilterDrivers()
        {

            foreach (DataColumn column in dtDrivers.Columns)
            {
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
                FilterString = "DriverID = ";
                FilterString += txtFilter.Text;
            }  // fix if txtFilter is Empty 
            else if (string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";

            else if (cmbFilter.Text == "DriverID" ||cmbFilter.Text == "PersonID" || cmbFilter.Text == "Licenses") // Active Licenses
            {
                if (txtFilter.Text != "")
                    FilterString = $"{cmbFilter.SelectedItem} = {txtFilter.Text}";
                else
                    FilterString = "";
            }

            else if (cmbFilter.Text == "Date")
            {
                DateTime date;

                if (DateTime.TryParse(txtFilter.Text, out date))
                    FilterString = $@"{cmbFilter.SelectedItem} = '{date}'";

                else
                    FilterString = "";
            }
            // filter by fullName,NationalNo
            else
                FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";

            if (!string.IsNullOrEmpty(FilterString) && !string.IsNullOrEmpty(txtFilter.Text))
                dtDriversView.RowFilter = FilterString;
            else
                dtDriversView.RowFilter = "";

            lbDriversCount.Text = dgvDrivers.RowCount.ToString();
        }
        private void _RefreshDriversList()
        {
            dtDrivers = clsDriver.GetAllDrivers();
            dtDriversView = new DataView(dtDrivers);
            dgvDrivers.DataSource = dtDriversView;

            lbDriversCount.Text = dgvDrivers.RowCount.ToString();
        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // open use control to add person
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(-1);
            frmAdd_Update.PersonAdded += Drivers_PersonAdded;
            frmAdd_Update.Show();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open use control to add person
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(-1);
            frmAdd_Update.PersonAdded += Drivers_PersonAdded;

            frmAdd_Update.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open use control to add person
            int DriverID = (int)dgvDrivers.CurrentRow.Cells[0].Value;
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(DriverID);
            frmAdd_Update.PersonAdded += Drivers_PersonAdded;
            frmAdd_Update.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvDrivers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you want to delete contact [ " + DriverID + " ]", "delete contact", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (clsDriver.Delete(DriverID))
                {
                    _RefreshDriversList();
                    MessageBox.Show("User Deleted Succesfuly");
                }
                else
                {
                    MessageBox.Show("User is not Deleted");
                }
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int DriverID = (int)dgvDrivers.CurrentRow.Cells[0].Value;
            ShowPersonForm PersonFrm = new ShowPersonForm(DriverID);
            PersonFrm.Show();
        }      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // onchange update data grid view 
            _RefreshDriversList();

            if (dtDrivers.Columns.Count > 0 && dtDrivers.Rows.Count > 0)
            {
                _FilterDtView();
            }
            // refresh => _RefreshDriversList();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "DriverID" || cmbFilter.Text == "Phone")
            {

                if (!GlobalMethods.CheckIsDigit(e))
                    e.Handled = true; // ignore the input char;
            }
        }

        private void Drivers_PersonAdded(object sender, EventArgs e)
        {
            _RefreshDriversList();
        }

        private void ManageDriversForm_Load(object sender, EventArgs e)
        {
            // load data
            _RefreshDriversList();

            // Load cmbFilterDrivers
            _LoadCmbFilterDrivers();

            // strop X scrooling
            dgvDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvDrivers.ColumnHeadersDefaultCellStyle.Font = new Font(dgvDrivers.Font,FontStyle.Bold);

        }
    }
}
