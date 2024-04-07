using System;
using DVLDBusinessLayer;
using System.Windows.Forms;
using System.Drawing;

namespace DVLD_WindowsForm.Tests.UserControls
{
    public partial class UCApplicationInfo : UserControl
    {
        public int ID { get; set; }
        public string Status { get; set; }
        public double Fees { get; set; }
        public string Type { get; set; }
        public string Applicant { get; set; }
        public DateTime Date { get; set; }
        public DateTime StatusDate { get; set; }
        public string CreatedBy { get; set; }
        
        public UCApplicationInfo()
        {
            InitializeComponent();
        }
        
        private void UCApplicationInfo_Load(object sender, EventArgs e)
        {

        }
        public void FillTestAppWithDate (clsLocalDLApplication DLApplication)
        {
            
            if (DLApplication == null)
               return;

            ID = DLApplication.ApplicationID;   
            SetIDUI(ID);

            Status =  handleApplicationStatus(DLApplication.ApplicationStatus);
            SetStatusUI( Status);

            Fees = DLApplication.PaidFees;
            SetFeesUI( Fees);

            Type = clsApplicationType.Find(DLApplication.ApplicationTypeID).Title;
            SettypeUI( Type);

            Applicant = clsPerson.Find(DLApplication.ApplicationPersonID).FullName;
            SetApplicantUI( Applicant);

            Date = DLApplication.ApplicationDate;
            SetDateUI( Date);

            StatusDate = DLApplication.lastStatusDate;
            SetStatusDateUI( StatusDate);

             CreatedBy = clsUser.Find(DLApplication.CreatedByUserID).UserName;
             SetCreatedByUI( CreatedBy);
        }
       
        public string handleApplicationStatus(byte ApplicationStatus)
        {
            switch (ApplicationStatus)
            {
                case (byte)GlobalEnums.enApplicationStatus.NewApplication:
                    return "New";
                case (byte)GlobalEnums.enApplicationStatus.CancledApplication:
                    return "Cancled";
                case (byte)GlobalEnums.enApplicationStatus.CompletedApplication:
                    return "Completed";
                default:
                    return "UnKnow";
            }
        }
       
        public void SetIDUI(int ID)
        {
            lbAppID.Text = ID.ToString();
        }
       
        public void SetStatusUI(string Status)
        {
            lbStatus.Text = Status;
        }  
        public void SetFeesUI(double Fees)
        {
            lbFees.Text = Fees.ToString();
        }
       
        public void SettypeUI(string Type)
        {
            lbType.Text = Type;
        }
       
        public void SetApplicantUI(string Applicant)
        {
            lbApplicant.Text = Applicant;

            lbApplicant.ForeColor = Color.Red;
        }
       
        public void SetDateUI(DateTime Date)
        {
            lbDate.Text = Date.ToString();
        }
       
        public void SetStatusDateUI(DateTime StatusDate)
        {
            lbStatusDate.Text = StatusDate.ToString();
        }
       
        public void SetCreatedByUI(string CreatedBy)
        {
            lbCreatedBy.Text = CreatedBy;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
