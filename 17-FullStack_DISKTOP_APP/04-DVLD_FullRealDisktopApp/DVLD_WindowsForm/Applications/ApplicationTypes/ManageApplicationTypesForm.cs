using System;

using System.Data;
using System.Linq;
using DVLDBusinessLayer;

using System.Windows.Forms;

namespace DVLD_WindowsForm
{
    public partial class ManageApplicationTypesForm : Form
    {

        public static DataTable dtApplicationTypes;
        public static DataView dtApplicationTypesView;

        public ManageApplicationTypesForm()
        {
            InitializeComponent();
            _RefreshApplicationTypesList();
            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void ManageApplicationTypes_Load(object sender, EventArgs e)
        {
            dgvManageAppTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }


        private void _RefreshApplicationTypesList()
        {
            dtApplicationTypes = clsApplicationType.GetAllAppTypes();
            dtApplicationTypesView = new DataView(dtApplicationTypes);
            dgvManageAppTypes.DataSource = dtApplicationTypesView;

            lbAppTypesCount.Text = dgvManageAppTypes.RowCount.ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void editToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            int AppTypeID = (int)dgvManageAppTypes.CurrentRow.Cells[0].Value;

            EditApplicationTypeForm EditAppTypeFrm = new EditApplicationTypeForm(AppTypeID);
            EditAppTypeFrm.Show();
            _RefreshApplicationTypesList();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshApplicationTypesList();
        }
    }
}
