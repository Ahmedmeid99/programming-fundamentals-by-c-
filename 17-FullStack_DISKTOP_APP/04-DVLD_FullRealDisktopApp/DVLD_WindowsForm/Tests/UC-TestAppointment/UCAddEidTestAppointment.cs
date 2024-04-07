using System;
using System.Data;
using DVLDBusinessLayer;

using System.Windows.Forms;
using System.Drawing;

namespace DVLD_WindowsForm.Tests.UC_TestAppointment
{
    public partial class UCAddEidTestAppointment : UserControl
    {
        public int DLAppID { get; set; }
        public byte ClassTypeID { get; set; }
        public string Name { get; set; }
        public byte  TrialCount { get; set; }
        public DateTime Date { get; set; }
        public double Fees { get; set; }

        public UCAddEidTestAppointment()
        {
            InitializeComponent();
        }        
        public UCAddEidTestAppointment(clsLocalDLApplication DLApplication)
        {
            InitializeComponent();

            
        }

        public void FillControls(clsLocalDLApplication DLApplication)
        {
            if (DLApplication == null)
                return;


            DLAppID = DLApplication.LocaLDLApplicationID;
            SetLDLAppIDUI(DLAppID);

            ClassTypeID = DLApplication.LicenseClassID;
            SetClassTypeUI(ClassTypeID);

            Name = clsPerson.Find(DLApplication.ApplicationPersonID).FullName;
            SetNameUI(Name);
            
            // GetCountOfPrevTestAppointments   BUG <<--
            SetTrialCountUI(TrialCount);

            Date = DateTime.Now;
            SetDateUI(Date);
            // The Fees that will giveen when pass the Test  BUG <<-
            Fees = 0;
            SetFeesUI(Fees);

        }

        private void SetLDLAppIDUI(int DLAppID)
        {
            lbDLAppID.Text = DLAppID.ToString();
        }

        private void SetClassTypeUI(byte ClassTypeID)
        {
            // handle class type
            string ClassName = clsLicenseClass.Find(ClassTypeID).ClassName;
            lbCLassType.Text = ClassName;


        }
        
        private void SetNameUI(string Name)
        {
            lbName.Text = Name;

            // Change color of label name to red
            lbName.ForeColor = Color.Red;
        }
      
        public void SetTrialCountUI(byte TrialCount)
        {
            this.TrialCount = TrialCount;
            lbTrial.Text = TrialCount.ToString();
        }
        public void SetDateUI(DateTime Date)
        {
            this.Date = Date;
            dTTestAppointmentDate.Value = Date;
        
        }   
       
        public void SetDateUIEnabled(bool IsEnabled)
        {
            dTTestAppointmentDate.Enabled = IsEnabled;
        
        }
        
        public void SetFeesUI(double Fees)
        {
            this.Fees = Fees;

            lbFees.Text = Fees.ToString();
        }

        private void UCAddEidTestAppointment_Load(object sender, EventArgs e)
        {
            DateTime DateNow = DateTime.Now;
            dTTestAppointmentDate.MinDate = DateNow;
            dTTestAppointmentDate.MaxDate = new DateTime(DateNow.Year + 1, DateNow.Month, DateNow.Day);
            
            // formate date
            dTTestAppointmentDate.Value.ToString("dd-mm-yyyy");
        }

        private void dTTestAppointmentDate_ValueChanged(object sender, EventArgs e)
        {
            this.Date = dTTestAppointmentDate.Value;
        }
    }
}
