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
    public partial class Manage_Pepole : Form
    {
        public static DataTable dtPepole ;
        public static DataView dtPepoleView ;
        
        public Manage_Pepole()
        {
            InitializeComponent();

            // CenterToParent this form
            this.StartPosition = FormStartPosition.CenterScreen;

            // load data
            _RefreshPepoleList();

        }

        private void _LoadCmbFilterPepole ()
        {

            foreach (DataColumn column in dtPepole.Columns)
            {
                cmbFilter.Items.Add(column.ColumnName);
            }

            if (cmbFilter.Items.Count > 0)
                cmbFilter.SelectedIndex = 0;
            
        }

        private bool _CheckIsDigit(KeyPressEventArgs e)
        {
            if (!(e is KeyPressEventArgs KeyPressEventArgs))
                return false;

            if (!char.IsDigit(e.KeyChar) &&
                e.KeyChar != (char)Keys.Back &&
                e.KeyChar != '(' &&
                e.KeyChar != ')' &&
                e.KeyChar != '{' &&
                e.KeyChar != '}' &&
                e.KeyChar != '-' &&
                e.KeyChar != ' '
                )
            {
                return false;
            }
            return true;
        }
        private void _FilterDtView()
        {
            string FilterString = "";

            if (cmbFilter.Text == "PersonID") 
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
            // filter by First,Second,Third,Last (Name) ,Gandor,Country,NationalN,Address,Email,ImagePath ,Phone
            else
                FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";

            //FilterString = FilterString.Replace("'", "''");
            if (!string.IsNullOrEmpty(FilterString))
                dtPepoleView.RowFilter = FilterString;
            else
                dtPepoleView.RowFilter = "";

            lbPepoleCount.Text = dgvPepole.RowCount.ToString();
        }
        private void _RefreshPepoleList()
        {
            dtPepole = clsPersonBusiness.GetAllPepole();
            dtPepoleView = new DataView(dtPepole);
            dgvPepole.DataSource = dtPepoleView;

            lbPepoleCount.Text = dgvPepole.RowCount.ToString();
        }


        private void Manage_Pepole_Load(object sender, EventArgs e)
        {
            _RefreshPepoleList();  // load data table  & set default view

            // Load cmbFilterPepole
            _LoadCmbFilterPepole();

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            // open use control to add person
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(-1);
            frmAdd_Update.Show();
            _RefreshPepoleList();
        }

        private void addNewPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open use control to add person
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(-1);
            frmAdd_Update.Show();
            _RefreshPepoleList();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open use control to add person
            int PersonID = (int)dgvPepole.CurrentRow.Cells[0].Value;
            AddEditPersonForm frmAdd_Update = new AddEditPersonForm(PersonID);
            frmAdd_Update.Show();
            _RefreshPepoleList();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPepole.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you want to delete contact [ " + PersonID + " ]", "delete contact", MessageBoxButtons.OK) == DialogResult.OK)
            {
                if (clsPersonBusiness.Delete(PersonID))
                {
                    MessageBox.Show("Contatct Deleted Succesfuly");
                    _RefreshPepoleList();
                }
                else
                {
                    MessageBox.Show("Contatct is not Deleted");
                }
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)dgvPepole.CurrentRow.Cells[0].Value;
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
            _RefreshPepoleList();
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // onchange update data grid view 
            // dtPepoleView.Rowfilter = $"{filter by} = {txtFilter.Text}"

            // finction(ref dtPepoleView)
            _RefreshPepoleList();

            if(dtPepole.Columns.Count > 0 && dtPepole.Rows.Count > 0)
            {
                _FilterDtView();
            }
            // refresh => _RefreshPepoleList();

        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "PersonID" ||  cmbFilter.Text == "Phone")
            {

                if (!_CheckIsDigit(e))
                e.Handled = true; // ignore the input char;
            }
        }
    }
}
