using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD_WindowsForm.Licenses.InternationalLicense
{
    public partial class InternationalLicenseInfoForm : Form
    {
        public InternationalLicenseInfoForm()
        {
            InitializeComponent();
        }
        public InternationalLicenseInfoForm(int internationalLicenseID)
        {
            InitializeComponent();

            if (internationalLicenseID <= 0)
                return;

            ucShowInternationalLicense.LoadInfo(internationalLicenseID);
        }
    }
}
