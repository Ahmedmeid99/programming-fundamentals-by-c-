using System;

using System.Data;
using System.Data.SqlClient;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        public int ApplicationID  {get;set;}
        public int ApplicationPersonID  {get;set;}
        public DateTime ApplicationDate {get;set;}
        public byte ApplicationTypeID  {get;set;}
        public DateTime lastStatusDate { get;set;}
        public byte ApplicationStatus {get;set;}
        public byte PassedTests {get;set;}
        public double PaidFees {get;set;}
        public int CreatedByUserID { get; set; }


        // Default Constractor for AddNew Mode 
        public clsApplication()
        {

            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.ApplicationTypeID = 0;
            this.lastStatusDate = DateTime.Now;
            this.ApplicationStatus = 0;
            this.PassedTests = 0;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;

            Mode = enMode.AddNew;

        }

        // Private Constractor for Update Mode 
        public clsApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, byte ApplicationTypeID, DateTime lastStatusDate, byte ApplicationStatus, byte PassedTests, double PaidFees, int CreatedByUserID)
        {

            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus =ApplicationStatus;
            this.PassedTests = PassedTests;
            this.lastStatusDate = lastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;

        }

        public static bool CancelApplication(int ApplicationPersonID, byte ApplicationStatus, byte PassedTests)
        {
            // * if this Application status is complet dont cancle it
            if (PassedTests == (byte)GlobalEnums.enApplicationStatus.CompletedApplication)
                return false;

            return ApplicationDataAccess.UpdateApplicationStatus(ApplicationPersonID, ApplicationStatus);
        }

        public static clsApplication FindApplication(int ApplicationID)
        {

            int ApplicationPersonID = -1, CreatedByUserID = -1;
            byte  ApplicationTypeID = 0, ApplicationStatus = 0, PassedTests = 0;
            double PaidFees = -1;
            DateTime ApplicationDate = DateTime.Now, lastStatusDate = DateTime.Now;


            if (ApplicationDataAccess.GetApplicationByID(ApplicationID,ref ApplicationPersonID,ref ApplicationDate,ref ApplicationTypeID,ref lastStatusDate,ref ApplicationStatus,ref PassedTests,ref PaidFees,ref CreatedByUserID))
            {
                return new clsApplication(ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID, lastStatusDate, ApplicationStatus, PassedTests, PaidFees, CreatedByUserID);
            }
            else
                return null;
        }

        public bool AddNewApplication()
        {
            this.ApplicationID = ApplicationDataAccess.AddNewApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, this.lastStatusDate, this.ApplicationStatus, this.PassedTests, this.PaidFees, this.CreatedByUserID);

            return (ApplicationID != -1);
        }
        public bool UpdateApplication()
        {
            // add this object to database
            return ApplicationDataAccess.UpdateApplication(this.ApplicationID ,this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, this.lastStatusDate, this.ApplicationStatus, this.PassedTests, this.PaidFees, this.CreatedByUserID);
        }

        public bool SaveApplication()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (AddNewApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return this.UpdateApplication();

            }

            return false;
        }



    }
}
