using System;
using DVLDBusinessLayer;
using DVLDBusinessLayer.Tests;
using System.Windows.Forms;
using DVLD_WindowsForm.Properties;

namespace DVLD_WindowsForm.Tests.MainTests.Test
{
    public partial class TakeTestForm : Form
    {

        public enum enMode { AddNew = 1 };
        public enMode Mode = enMode.AddNew;

        private int _TestAppointmentID;
        private clsTestAppointment _TestAppointment; 

        private int _TestID;
        private clsTest _Test;

        private int _DLApplicationID;
        private clsLocalDLApplication _DLApplication;

        private int _TestTypeID;
        bool IsReTest = false;
        bool IsTestPasssed = false;

        //-----------------------------------
        //---------Delegation----------------
        //-----------------------------------
        public delegate void TestAddedEventHandler(object sender,EventArgs e) ;
        public event TestAddedEventHandler TestAdded ;

        // pass parameter in constractor
        public TakeTestForm(int DLApplicationID, int TestAppointmentID,int TestTypeID)
        {
            InitializeComponent();

            if (TestAppointmentID == -1)
            {
                this.Close();
                return;
            }  

            _TestTypeID = TestTypeID;
            _handlePictureTestType();
            
            _TestAppointmentID = TestAppointmentID;
            _TestAppointment = clsTestAppointment.Find(TestAppointmentID);
            

            _DLApplicationID = DLApplicationID;
            _DLApplication = clsLocalDLApplication.Find(_DLApplicationID);

            _Test = new clsTest();

            IsReTest = clsTestAppointment.HasPrevTestAppoinment(_DLApplicationID, _TestTypeID) &&
                        clsTestAppointment.FindFirstTest(_DLApplicationID, _TestTypeID).TestAppointmentID != _TestAppointmentID;

            IsTestPasssed = clsTest.IsExists(_TestAppointmentID, (int)GlobalEnums.enTestResult.Passed);
            
            _handleAddEditUI();
            
            _CheckTestStatus();

            _FillTestWithData();

            _FillControlsWithData();


        }
        private bool _CheckTestStatus()
        {
            bool Passed = false;
            if (IsTestPasssed)
            {
                Passed = true;
                lbMessageError.Text = "Person alresdy sat the test , appointment locked";
                lbMessageError.Visible = true;
                ucAddEidTestAppointment.SetDateUIEnabled(false);
            }
            else
            {
                Passed = false;
                lbMessageError.Text = "";
                lbMessageError.Visible = false;
                ucAddEidTestAppointment.SetDateUIEnabled(true);
            }
            return Passed;
        }

        private void _FillControlsWithData()
        {
            ucAddEidTestAppointment.FillControls(_DLApplication);

            ucAddEidTestAppointment.SetFeesUI(clsTestType.Find(_TestTypeID).Fees);

            ucAddEidTestAppointment.SetDateUI(_TestAppointment.AppointmentDate);
            ucAddEidTestAppointment.SetDateUIEnabled(false);
        }
     
        private void _handlePictureTestType()
        {
            if(_TestTypeID == (int) GlobalEnums.enTestType.VissionTest)
                pictureTestType.Image = Resources.Vision_512;
            else if(_TestTypeID == (int) GlobalEnums.enTestType.WrittenTest)
                pictureTestType.Image = Resources.Written_Test_512;
            else if(_TestTypeID == (int) GlobalEnums.enTestType.StreetTest)
                pictureTestType.Image = Resources.driving_test_512;
        }

        private byte _handelTestResult()
        {
            
            if(rdbtnPass.Checked)
            {
                return (byte)GlobalEnums.enTestResult.Passed;
            }
            else if(rdbtnFail.Checked)
            {
                return (byte)GlobalEnums.enTestResult.Faild;
            }

            return (byte)GlobalEnums.enTestResult.Faild;

        }
        
        private void _FillTestWithData()
        {
            _Test.TestAppointmentID = _TestAppointmentID;
            _Test.TestResult = _handelTestResult();
            _Test.Notes = txtDescription.Text;
            _Test.CreatedByUserID = Global.GlobalVars.CurrentUser.UserID;
            
        }
        private void _UpdateApplicationStatus()
        {
            if (_Test.TestResult == (byte)GlobalEnums.enTestResult.Faild)
            {
                _TestAppointment.IsLocked = true;

                // [Save LocalApplication]  
                if (!_TestAppointment.Save())
                    MessageBox.Show("Data Does not Saved Successfuly (Faild Test)");
            }
            else if (_Test.TestResult == (byte)GlobalEnums.enTestResult.Passed)
            {
                _TestAppointment.IsLocked = true;

                // [Save LocalApplication]  
                if (!_TestAppointment.Save())
                    MessageBox.Show("Data Does not Saved Successfuly (Faild Test)");


                if (_TestTypeID == (int)GlobalEnums.enTestType.VissionTest)
                    _DLApplication.PassedTests = 1;
                else if (_TestTypeID == (int)GlobalEnums.enTestType.WrittenTest)
                    _DLApplication.PassedTests = 2;
                else if (_TestTypeID == (int)GlobalEnums.enTestType.StreetTest)
                {
                    _DLApplication.PassedTests = 3;
                    _DLApplication.ApplicationStatus = (byte)GlobalEnums.enApplicationStatus.CompletedApplication;

                }

                // [Save LocalApplication]  
                if (_DLApplication.Save())
                    MessageBox.Show("Data Saved Successfuly (Passing Test)");
                else
                    MessageBox.Show("Data Does not Saved Successfuly (Passing Test)");

            }
            

        }
        private void _Save()
        {
            _FillTestWithData();

            if (_CheckTestStatus())
                return;

            if (_Test.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
                
                if (_TestAppointmentID > 0)
                {
                    _Test = clsTest.FindByTestAppointmentID(_TestAppointmentID);
                   
                    if (_Test != null)
                        _Test.TestResult = _handelTestResult();
                    else
                        MessageBox.Show("Test = null");

                    // Show Test If You need

                    // Update Application Based on TestResult 
                    _UpdateApplicationStatus();


                }
            }
            else
                MessageBox.Show("Error : Data is not Saved Successfuly");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _Save();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            TestAdded?.Invoke(this, e);
            this.Close();
        }

        private void _handleAddEditUI()
        {

            if (!IsReTest)
                ucAddEidTestAppointment.SetTrialCountUI(0);
            else
                ucAddEidTestAppointment.SetTrialCountUI(1);
        }
    }
}
