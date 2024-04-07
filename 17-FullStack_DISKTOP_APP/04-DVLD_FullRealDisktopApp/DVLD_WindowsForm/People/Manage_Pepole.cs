using DVLDBusinessLayer;
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
    public partial class Manage_People : Form
    {
        public static DataTable dtPeople ;
        public static DataView dtPeopleView ;
        
        public Manage_People()
        {
            InitializeComponent();

            // CenterToParent this form
            this.StartPosition = FormStartPosition.CenterScreen;

            // load data
            _RefreshPeopleList();

        }

        private void _LoadCmbFilterPeople ()
        {

            foreach (DataColumn column in dtPeople.Columns)
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
                FilterString = "PersonID = ";
                FilterString += txtFilter.Text;
            }  // fix if txtFilter is Empty 
            else if(string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";

            else if (cmbFilter.Text == "PersonID")
            {
                if (txtFilter.Text != "")
                    FilterString = $"{cmbFilter.SelectedItem} = {txtFilter.Text}";
                else
                    FilterString = "";
            }

            else if (cmbFilter.Text == "DateOfBirth")
            {
                DateTime date;

                if (DateTime.TryParse(txtFilter.Text, out date))
                    FilterString = $@"{cmbFilter.SelectedItem} = '{date}'";

                else
                    FilterString = "";
            }
            // filter by First,Second,Third,Last (Name) ,Gendor,Country,NationalNo,Address,Email,ImagePath ,Phone
            else
                FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";

            if (!string.IsNullOrEmpty(FilterString) && !string.IsNullOrEmpty(txtFilter.Text))
                dtPeopleView.RowFilter = FilterString;
            else
                dtPeopleView.RowFilter = "";

            lbPeopleCount.Text = dgvPeople.RowCount.ToString();
        }
        private void _RefreshPeopleList()
        {
            dtPeople = clsPerson.GetAllPeople();
            dtPeopleView = new DataView(dtPeople);
            dgvPeople.DataSource = dtPeopleView;

            lbPeopleCount.Text = dgvPeople.RowCount.ToString();
        }


        private void Manage_People_Load(object sender, EventArgs e)
        {
            // strop X scrooling
            dgvPeople.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            // Load cmbFilterPeople
            _LoadCmbFilterPeople();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // open use control to add person
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(-1);
            frmAdd_Update.PersonAdded += People_PersonAdded;
            frmAdd_Update.Show();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open use control to add person
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(-1);
            frmAdd_Update.PersonAdded += People_PersonAdded;

            frmAdd_Update.Show();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open use control to add person
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(PersonID);
            frmAdd_Update.PersonAdded += People_PersonAdded;
            frmAdd_Update.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you want to delete contact [ " + PersonID + " ]", "delete contact", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (clsPerson.Delete(PersonID))
                {
                    _RefreshPeopleList();
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
            int PersonID = (int)dgvPeople.CurrentRow.Cells[0].Value;
            ShowPersonForm PersonFrm = new ShowPersonForm(PersonID);
            PersonFrm.Show();
        }

        private void sendEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Completed Yet");
        }

        private void phoneCallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Completed Yet");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _RefreshPeopleList();
        }    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // onchange update data grid view 
            _RefreshPeopleList();

            if(dtPeople.Columns.Count > 0 && dtPeople.Rows.Count > 0)
            {
                _FilterDtView();
            }
            // refresh => _RefreshPeopleList();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "PersonID" ||  cmbFilter.Text == "Phone")
            {

                if (!GlobalMethods.CheckIsDigit(e))
                e.Handled = true; // ignore the input char;
            }
        }
    
        private void People_PersonAdded(object sender, EventArgs e)
        {
            _RefreshPeopleList();
        }
    
    }
}
