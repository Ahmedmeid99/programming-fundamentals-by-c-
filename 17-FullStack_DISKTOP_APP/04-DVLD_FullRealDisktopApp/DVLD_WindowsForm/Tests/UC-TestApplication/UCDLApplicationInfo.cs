using System;
using DVLDBusinessLayer;
using System.Windows.Forms;

namespace DVLD_WindowsForm.Tests.UserControls
{
    public partial class UCDLApplicationInfo : UserControl
    {

        public int DLAppID { get; set; }
        public string LicenseClass { get; set; }
        public byte PassedTests { get; set; }

        public UCDLApplicationInfo()
        {
            InitializeComponent();
        }
        
        private void UCDLApplicationInfo_Load(object sender, EventArgs e)
        {

        }
        public void FillTestAppWithDate(clsLocalDLApplication DLApplication)
        {

            if (DLApplication == null)
                return;

            DLAppID = DLApplication.LocaLDLApplicationID;
            SetDLAppIDUI(DLAppID);

            LicenseClass = clsLicenseClass.Find(DLApplication.LicenseClassID).ClassName;
            SetLicenseClassUI( LicenseClass);

            PassedTests = DLApplication.PassedTests;
            SetPassedTestsUI( PassedTests);
        }

        public void SetDLAppIDUI(int DLAppID)
        {
            lbDLAppID.Text = DLAppID.ToString();
        }
        public void SetLicenseClassUI(string LicenseClass)
        {
            lbLicenseClass.Text = LicenseClass;
        }
        public void SetPassedTestsUI(byte PassedTests) 
        {
            lbPassedTests.Text = PassedTests.ToString() + "/3";
        }

        private void linkLbShowLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // show form
        }
    }
}
