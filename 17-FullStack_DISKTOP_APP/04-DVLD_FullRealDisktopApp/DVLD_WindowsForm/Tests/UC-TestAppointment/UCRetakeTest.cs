using System;
using System.Data;
using DVLDBusinessLayer;

using System.Windows.Forms;

namespace DVLD_WindowsForm.Tests.UC_TestAppointment
{
    public partial class UCRetakeTest : UserControl
    {
        public int ReTestAppID { get; set; }
        public double TotalFees { get; set; }   // Fees + ReTestFees
        public double ReTestFees { get; set; }

        public UCRetakeTest()
        {
            InitializeComponent();
        }

        public void FillControls(clsLocalDLApplication DLApplication)
        {      
            if (DLApplication == null)
                return;

            //ReTestAppID = 0; // will added after save Re-TestAppointment succefully
            // SetReTestAppIDUI()

            ReTestFees = clsApplicationType.Find((int)GlobalEnums.enApplicationType.ReTakeTest).Fees;
            SetReTestFeesUI(ReTestFees);
            
            // GET Fees from classType vehicleType +  ReTestFees BUG <<-
           
        }


        public void SetReTestAppIDUI(int ReTestAppID)
        {
            lbReTestAppID.Text = ReTestAppID.ToString();
        }
        public void SetTotalFeesUI(double TestFees,bool IsReTest)
        {

            if (IsReTest)
            {
                this.TotalFees = TestFees + this.ReTestFees;
                lbTotalFees.Text = this.TotalFees.ToString();
            }
            else 
                this.TotalFees = TestFees;



        }  
       
        private void SetReTestFeesUI(double ReTestFees)
        {
            lbReTestFees.Text = ReTestFees.ToString();

        }


    }
}
