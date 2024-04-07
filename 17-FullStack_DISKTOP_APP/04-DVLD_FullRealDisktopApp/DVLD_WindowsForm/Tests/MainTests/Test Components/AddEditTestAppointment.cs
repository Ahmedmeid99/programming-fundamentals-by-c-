using System;
using DVLDBusinessLayer;
using DVLDBusinessLayer.Tests;
using DVLD_WindowsForm.Properties;

using System.Windows.Forms;

namespace DVLD_WindowsForm.Tests.MainTests.Test
{
    public partial class AddEditTestAppointment : Form
    {
        

        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        private int _TestAppointmentID;
        private clsTestAppointment _TestAppointment;
        private int _DLApplicationID;
        private clsLocalDLApplication _DLApplication;

        int _TestTypeID  ;
        bool IsReTest = false;
        bool IsTestPasssed = false;

        //-----------------------------------
        //---------Delegation----------------
        //-----------------------------------
        public delegate void TestAppointmentAddedEventHandler(object sender, EventArgs e);
        public event TestAppointmentAddedEventHandler TestAppointmentAdded;

        // pass parameter in constractor
        public AddEditTestAppointment(int DLApplicationID, int TestAppointmentID,int TestTypeID)
        {
            InitializeComponent();


            if (TestAppointmentID == -1)
            {
                // Add Mode
                _TestAppointment = new clsTestAppointment();

                Mode = enMode.AddNew;

            }
            else
            {
                _TestAppointment = clsTestAppointment.Find(TestAppointmentID);
                // update UI Modes
                ucAddEidTestAppointment.SetDateUI(_TestAppointment.AppointmentDate);
                // Update Mode
                Mode = enMode.Update;

            }
            _DLApplicationID = DLApplicationID;
            _DLApplication = clsLocalDLApplication.Find(_DLApplicationID);

            _TestAppointmentID = TestAppointmentID;

            _TestTypeID = TestTypeID;
            _handlePictureTestType();

            IsReTest = clsTestAppointment.HasPrevTestAppoinment(_DLApplicationID, TestTypeID) &&
                        clsTestAppointment.FindFirstTest(_DLApplicationID, TestTypeID).TestAppointmentID != _TestAppointmentID;

            IsTestPasssed = clsTest.IsExists(_TestAppointmentID, (int)GlobalEnums.enTestResult.Passed);

            handleAddEditUI();

            // fill controls with data  1,2

            _FillTestAppoinmentWithData();

            _FillControlsWithData();


        }

        private void _FillControlsWithData()
        {

            ucAddEidTestAppointment.FillControls(_DLApplication);

            ucAddEidTestAppointment.SetFeesUI(clsTestType.Find(_TestTypeID).Fees);

            ucAddEidTestAppointment.SetDateUI(_TestAppointment.AppointmentDate);

            // if has prev Test throw DLApplication as parameter to 2

            if (IsReTest)
            {
                ucRetakeTest.FillControls(_DLApplication);
                ucRetakeTest.SetTotalFeesUI(clsTestType.Find(_TestTypeID).Fees, true);
                ucRetakeTest.SetReTestAppIDUI(_TestAppointmentID);
            }
            else
                ucRetakeTest.SetTotalFeesUI(clsTestType.Find(_TestTypeID).Fees, false);



        }
        private void _FillTestAppoinmentDate()
        {
            _TestAppointment.AppointmentDate = ucAddEidTestAppointment.Date;
        }


        private void _FillTestAppoinmentWithData()
        {
            if (Mode == enMode.AddNew)
            {
                _TestAppointment.TestTypeID = _TestTypeID;
                _TestAppointment.LDLApplicationID = _DLApplicationID;
                _TestAppointment.PaidFees = ucRetakeTest.TotalFees;  // Total Fees  NeedHandel <<-
                _TestAppointment.CreatedByUserID = Global.GlobalVars.CurrentUser.UserID;
                _TestAppointment.IsLocked = false;
                
                _FillTestAppoinmentDate();
            }
            else if (Mode == enMode.Update)
            {
                _FillTestAppoinmentDate();
            }
        }
        private void _handlePictureTestType()
        {
            if (_TestTypeID == (int)GlobalEnums.enTestType.VissionTest)
                pictureTestType.Image = Resources.Vision_512;
            else if (_TestTypeID == (int)GlobalEnums.enTestType.WrittenTest)
                pictureTestType.Image = Resources.Written_Test_512;
            else if (_TestTypeID == (int)GlobalEnums.enTestType.StreetTest)
                pictureTestType.Image = Resources.driving_test_512;
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
        private void _Save()
        {
            _FillTestAppoinmentWithData();

            if (_CheckTestStatus())
                return;

            if (_TestAppointment.Save())
            {
                MessageBox.Show("Data Saved Successfuly");
                if (_TestAppointmentID <= 0)
                {
                    _TestAppointment = clsTestAppointment.Find(_DLApplicationID, _TestTypeID);

                    if (_TestAppointment != null)
                    {
                        _TestAppointmentID = _TestAppointment.TestAppointmentID; // find using DLAppID , ClassType
                    }
                    // SET  _TestAppointmentID IN UI
                    if (IsReTest && _TestAppointmentID != -1)
                        ucRetakeTest.SetReTestAppIDUI(_TestAppointmentID);
                }
                // Update new Mode i UI
                Mode = enMode.Update;
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
            TestAppointmentAdded?.Invoke(this, e);
            this.Close();
        }

        private void handleAddEditUI()
        {

            if (!IsReTest)
            {
                ucRetakeTest.Enabled = false;
                ucAddEidTestAppointment.SetTrialCountUI(0);

            }
            else
            {
                ucRetakeTest.Enabled = true;
                ucAddEidTestAppointment.SetTrialCountUI(1);
            }
        }
    }
}
