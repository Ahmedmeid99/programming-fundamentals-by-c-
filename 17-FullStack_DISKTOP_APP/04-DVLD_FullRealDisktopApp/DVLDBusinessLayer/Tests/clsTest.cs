using System;

using System.Data;
using DVLDBusinessLayer;
using DVLDDataAccessLayer.Tests;

namespace DVLDBusinessLayer.Tests
{
    public class clsTest
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestID { get; set; }
        public int TestAppointmentID { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public byte TestResult { get; set; }

        public clsTest()
        {
            TestID = -1;
            TestAppointmentID = -1;
            Notes = "";
            CreatedByUserID = -1;
            TestResult = 0;

            Mode = enMode.AddNew;
        }    
        
        public clsTest(int TestID, int TestAppointmentID,string Notes,int CreatedByUserID,byte TestResult)
        {
            this.TestID = TestID;
            this.TestAppointmentID = TestAppointmentID;
            this.Notes = Notes;
            this.CreatedByUserID = CreatedByUserID;
            this.TestResult =TestResult;

            Mode = enMode.Update;
        }

        private bool _AddNewTest()
        {
            // add this object to database
            // in AddNew Mode 
            this.TestID = TestDataAccess.AddNewTest(this.TestAppointmentID, this.Notes, this.CreatedByUserID, this.TestResult);

            return (this.TestID != -1);

        }

        private bool _UpdateTest()
        {
            // add this object to database
            return TestDataAccess.UpdateTest(this.TestID, this.TestAppointmentID, this.Notes, this.CreatedByUserID, this.TestResult);
        }

        public static clsTest Find(int TestID)
        {
            int TestAppointmentID = -1, CreatedByUserID = -1;
            string Notes = "";

            byte TestResult = 0;

            if (TestDataAccess.GetTestByID(TestID, ref TestAppointmentID, ref Notes, ref CreatedByUserID, ref TestResult ))
            {
                return new clsTest(TestID, TestAppointmentID, Notes, CreatedByUserID,  TestResult);
            }
            else
                return null;
        }  
        public static clsTest FindByTestAppointmentID(int TestAppointmentID)
        {
            int TestID = -1, CreatedByUserID = -1;
            string Notes = "";

            byte TestResult = 0;

            if (TestDataAccess.GetTestByAppointmentID(TestAppointmentID ,ref TestID , ref Notes, ref CreatedByUserID, ref TestResult ))
            {
                return new clsTest(TestID, TestAppointmentID, Notes, CreatedByUserID,  TestResult);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTest())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return this._UpdateTest();

            }

            return false;
        }

        public static DataTable GetAllTests()
        {
            return TestDataAccess.GetAllTests();
        }

        public static bool Delete(int TestID)
        {
            return TestDataAccess.DeleteTest(TestID);
        }


        public static bool IsExists(int TestID)
        {
            return TestDataAccess.IsTestExists(TestID);
        }  
        public static bool IsExists(int TestAppointmentID, byte TestResult)
        {
            return TestDataAccess.IsTestExists(TestAppointmentID, TestResult);
        }

    }
}
