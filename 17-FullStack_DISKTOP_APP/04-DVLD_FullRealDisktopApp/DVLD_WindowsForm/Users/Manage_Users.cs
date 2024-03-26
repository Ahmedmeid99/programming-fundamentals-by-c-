using System;

using System.Data;

using System.Windows.Forms;
using DVLDBusinessLayer;

namespace DVLD_WindowsForm
{
    public partial class Manage_Users : Form
    {
        public Manage_Users()
        {
            InitializeComponent();
            // CenterToParent this form
            this.StartPosition = FormStartPosition.CenterScreen;

            // load data
            _RefreshUsersList();
        }

        public static DataTable dtUsers;
        public static DataView dtUsersView;

        

        private void _LoadCmbFilterUsers()
        {

            foreach (DataColumn column in dtUsers.Columns)
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
            else if (string.IsNullOrEmpty(txtFilter.Text))
                FilterString = "";

            else if (cmbFilter.Text == "PersonID" || cmbFilter.Text == "UserID")
            {
                if (txtFilter.Text != "")
                    FilterString = $"{cmbFilter.SelectedItem} = {txtFilter.Text}";
                else
                    FilterString = "";
            }

            else if(cmbFilter.Text == "UserName" || cmbFilter.Text == "FullName")
            {
                if (txtFilter.Text != "")
                    FilterString = $@"{cmbFilter.SelectedItem} LIKE '{txtFilter.Text}%'";
                else
                    FilterString = "";
            }

            // else will fix by comboBox when SelectedIndexChanged
            if (!string.IsNullOrEmpty(FilterString))
                dtUsersView.RowFilter = FilterString;
            else
                dtUsersView.RowFilter = "";

            _RefreshUsersCount();



        }
        
        private void _RefreshUsersCount ()
        {
            lbUsersCount.Text = dgvUsers.RowCount.ToString();
        }
        
        private void _RefreshUsersList()
        {
            dtUsers = clsUser.GetAllUsers();
            dtUsersView = new DataView(dtUsers);
            dgvUsers.DataSource = dtUsersView;

            _RefreshUsersCount();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // ------------------------------------------------------

        private void Manage_Users_Load(object sender, EventArgs e)
        {
            _RefreshUsersList();  // load data table  & set default view

            // Load cmbFilterUsers
            _LoadCmbFilterUsers();

            // hide cmbActive
            cmbActive.Visible = false;

            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // -----------------------------------------------------------
        // [ Show AddEditUse Form That is have userControl for users ]
        // -----------------------------------------------------------
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            // open use control to add person
            _RefreshUsersList();
            AddEditUserForm frmAdd_Update = new AddEditUserForm(-1);
            frmAdd_Update.Show();
        }

        private void mbtnAddNewUser_Click(object sender, EventArgs e)
        {
            // open use control to add person
            _RefreshUsersList();
            AddEditUserForm frmAdd_Update = new AddEditUserForm(-1);
            frmAdd_Update.Show();
        }

        private void mbtnEdit_Click(object sender, EventArgs e)
        {
            // open use control to add person
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            _RefreshUsersList();
            AddEditUserForm frmAdd_Update = new AddEditUserForm(UserID);
            frmAdd_Update.Show();
        }

        private void mbtnDelete_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you want to delete contact [ " + UserID + " ]", "delete contact", MessageBoxButtons.OK) == DialogResult.OK)
            {
                try
                {

                    if (clsUser.Delete(UserID))
                    {
                        _RefreshUsersList();
                        MessageBox.Show("Contatct Deleted Succesfuly");
                    }
                    else
                    {
                        MessageBox.Show("Contatct is not Deleted");
                    }
                }  catch(Exception Ex)
                {
                    MessageBox.Show("Error : " + Ex.Message);
                }
            }
        }

        private void sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            ShowUserForm UserFrm = new ShowUserForm(UserID);
            UserFrm.Show();
        }

        private void mbtnSendEmail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Completed Yet");
        }

        private void mbtnPhoneCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Not Completed Yet");
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshUsersList();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            // onchange update data grid view 
            _RefreshUsersList();

            if (dtUsers.Columns.Count > 0 && dtUsers.Rows.Count > 0)
            {
                _FilterDtView();
            }
            // refresh => _RefreshUsersList();
        }

        private void txtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (cmbFilter.Text == "PersonID" || cmbFilter.Text == "Phone")
            {

                if (!GlobalMethods.CheckIsDigit(e))
                    e.Handled = true; // ignore the input char;
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFilter.Text == "Active")
            {
                cmbActive.Visible = true;
                txtFilter.Visible = false;
            } else
            {
                cmbActive.Visible =false;
                txtFilter.Visible =true;
            }
        }

        private void cmbActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            _RefreshUsersList();

            string FilterString = "";

             if (cmbActive.Text == "Yes")
                FilterString = "Active = true"; 
            else if (cmbActive.Text == "No")
                FilterString = "Active = false";
            else
                FilterString = "";

            dtUsersView.RowFilter = FilterString;

            _RefreshUsersCount();

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            // open from update user
            // open use control to add person
            int UserID = (int)dgvUsers.CurrentRow.Cells[0].Value;
            ChangePasswordForm ChangePasswordFrm = new ChangePasswordForm(UserID);
            ChangePasswordFrm.Show();
            _RefreshUsersList();
        }
    }
}
