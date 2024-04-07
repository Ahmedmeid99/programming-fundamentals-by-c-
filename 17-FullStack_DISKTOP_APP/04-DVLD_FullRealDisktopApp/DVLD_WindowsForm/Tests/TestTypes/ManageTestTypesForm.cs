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
    public partial class ManageTestTypesForm : Form
    {
        public ManageTestTypesForm()
        {
            InitializeComponent();
            _RefreshTestTypesList();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void ManageTestTypesForm_Load(object sender, EventArgs e)
        {
            dgvTestTypes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            _RefreshTestTypesList();
        }

        public static DataTable dtTestTypes;
        public static DataView dtTestTypesView;


        


        private void _RefreshTestTypesList()
        {
            dtTestTypes = clsTestType.GetAllTestTypes();
            dtTestTypesView = new DataView(dtTestTypes);
            dgvTestTypes.DataSource = dtTestTypesView;

            lbTestTypesCount.Text = dgvTestTypes.RowCount.ToString();
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

      
        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int TestTypeID = (int)dgvTestTypes.CurrentRow.Cells[0].Value;

            EditTestTypeForm EditTestTypeFrm = new EditTestTypeForm(TestTypeID);
            EditTestTypeFrm.Show();
            _RefreshTestTypesList();
        }
    }
}
