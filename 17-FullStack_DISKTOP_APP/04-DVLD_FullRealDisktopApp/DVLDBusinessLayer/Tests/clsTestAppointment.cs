using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using DVLDDataAccessLayer;
using DVLDDataAccessLayer.Tests;

namespace DVLDBusinessLayer.Tests
{
    public class clsTestAppointment
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int TestAppointmentID {get;set;}
        public int TestTypeID {get;set;}
        public int LDLApplicationID {get;set;}
        public DateTime AppointmentDate {get;set;}
        public double PaidFees {get;set;}
        public int CreatedByUserID {get;set;}
        public bool IsLocked { get;set; }

        public clsTestAppointment()
        {
            this.TestAppointmentID = -1;
            this.TestTypeID = -1;
            this.LDLApplicationID = -1;
            this.AppointmentDate = DateTime.Now;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;
            this.IsLocked = false;

            Mode = enMode.AddNew;
        }    
        public clsTestAppointment(int TestAppointmentID, int TestTypeID,int LDLApplicationID,DateTime AppointmentDate,double PaidFees,int CreatedByUserID,bool IsLocked)
        {

            this.TestAppointmentID = TestAppointmentID;
            this.TestTypeID = TestTypeID;
            this.LDLApplicationID = LDLApplicationID;
            this.AppointmentDate =AppointmentDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;
            this.IsLocked =IsLocked;

            Mode = enMode.Update;
        }

        private bool _AddNewTestAppointment()
        {
            // add this object to database
            // in AddNew Mode 
            this.TestAppointmentID = TestAppointmentDataAccess.AddNewTestAppointment(this.TestTypeID, this.LDLApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);

            return (this.TestAppointmentID != -1);

        }
        
        private bool _UpdateTestAppointment()
        {
            // add this object to database
            return TestAppointmentDataAccess.UpdateTestAppointment(this.TestAppointmentID, this.TestTypeID, this.LDLApplicationID, this.AppointmentDate, this.PaidFees, this.CreatedByUserID, this.IsLocked);
        }
        
        public static clsTestAppointment Find(int TestAppointmentID)
        {
            int  TestTypeID = -1,LDLApplicationID = -1,CreatedByUserID = -1;
            double PaidFees = -1;

            DateTime AppointmentDate = DateTime.Now;

            bool IsLocked = false;

            if (TestAppointmentDataAccess.GetTestAppointmentByID(TestAppointmentID,ref TestTypeID,ref LDLApplicationID,ref AppointmentDate,ref PaidFees,ref CreatedByUserID,ref IsLocked))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LDLApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            }
            else
                return null;
        } 
        public static clsTestAppointment Find(int LDLApplicationID,int TestTypeID)
        {
            int TestAppointmentID = -1,CreatedByUserID = -1;
            double PaidFees = -1;

            DateTime AppointmentDate = DateTime.Now;

            bool IsLocked = false;

            if (TestAppointmentDataAccess.GetTestAppointmentByLDLApplicationID( LDLApplicationID,TestTypeID ,ref TestAppointmentID,ref AppointmentDate,ref PaidFees,ref CreatedByUserID,ref IsLocked))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LDLApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            }
            else
                return null;
        }
        public static clsTestAppointment FindFirstTest(int LDLApplicationID,int TestTypeID)
        {
            int TestAppointmentID = -1,CreatedByUserID = -1;
            double PaidFees = -1;

            DateTime AppointmentDate = DateTime.Now;

            bool IsLocked = false;

            if (TestAppointmentDataAccess.FirstTestTestAppoinment( LDLApplicationID,TestTypeID ,ref TestAppointmentID,ref AppointmentDate,ref PaidFees,ref CreatedByUserID,ref IsLocked))
            {
                return new clsTestAppointment(TestAppointmentID, TestTypeID, LDLApplicationID, AppointmentDate, PaidFees, CreatedByUserID, IsLocked);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewTestAppointment())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return this._UpdateTestAppointment();

            }

            return false;
        }

        public static DataTable GetAllTestAppointments()
        {
            return TestAppointmentDataAccess.GetAllTestAppointments();
        }  
        public static DataTable GetAllTestAppointments(int LDLAppID,int TestTypeID)
        {
            return TestAppointmentDataAccess.GetAllTestAppointments(LDLAppID, TestTypeID);
        }  
        

        public static bool Delete(int ID)
        {
            return TestAppointmentDataAccess.DeleteTestAppointment(ID);
        }


        public static bool IsExists(int ID)
        {
            return TestAppointmentDataAccess.IsTestAppointmentExists(ID);
        }     
        
        public static bool HasActiveTestAppoinment(int LDLApplicationID,int TestTypeID)
        {
            return TestAppointmentDataAccess.HasActiveTestAppoinment(LDLApplicationID, TestTypeID);
        }
           
        public static bool HasPrevTestAppoinment(int LDLApplicationID,int TestTypeID)
        {
            return TestAppointmentDataAccess.HasPrevTestAppoinment(LDLApplicationID, TestTypeID);
        } 
        public static bool IsLockedTest(int TestAppointmentID)
        {
            return TestAppointmentDataAccess.IsLockedTestAppoinment(TestAppointmentID);
        }    
       

        


    }
}
