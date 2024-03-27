using System;

using System.Data;
using System.Data.SqlClient;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplication
    {
        public int ApplicationID  {get;set;}
        public int ApplicationPersonID  {get;set;}
        public DateTime ApplicationDate {get;set;}
        public byte ApplicationTypeID  {get;set;}
        public DateTime lastStatusDate { get;set;}
        public byte ApplicationStatus {get;set;}
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
            this.PaidFees = -1;
            this.CreatedByUserID = -1;

        }

        // Private Constractor for Update Mode 
        public clsApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, byte ApplicationTypeID, DateTime lastStatusDate, byte ApplicationStatus, double PaidFees, int CreatedByUserID)
        {

            this.ApplicationID = ApplicationID;
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.ApplicationStatus =ApplicationStatus;
            this.lastStatusDate = lastStatusDate;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

        }

        public static bool CancelApplication(int ApplicationPersonID, byte ApplicationStatus)
        {
            return ApplicationDataAccess.UpdateApplicationStatus(ApplicationPersonID, ApplicationStatus);
        }




    }
}
