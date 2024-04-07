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

namespace DVLD_WindowsForm.Licenses
{
    public partial class ShowLicenseForm : Form
    {
        private clsLicense _License;
        public ShowLicenseForm(clsLicense License)
        {
            InitializeComponent();

            _License = License;

            ucShowLicenseInfo.FillControlsWithData(_License);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
