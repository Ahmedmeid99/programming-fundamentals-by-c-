using DVLDDataAccessLayer;
using System;

using System.Data;
using System.Data.SqlClient;

namespace DVLDBusinessLayer
{
    public class clsLocalDLApplication : clsApplication
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;
        
        // ApplicationID,... are inhertance from application     
        
        public int LocaLDLApplicationID { get; set; }
        public byte LicenseClassID { get; set; }
        


        // Default Constractor for AddNew Mode 
        public clsLocalDLApplication()
        {

            this.LocaLDLApplicationID = -1;
            this.LicenseClassID = 0;
            this.ApplicationID = -1;
            this.ApplicationPersonID = -1;
            this.ApplicationDate = DateTime.Now;
            this.lastStatusDate = DateTime.Now;
            this.ApplicationTypeID = 0;
            this.ApplicationStatus = 0;
            this.PassedTests = 0;
            this.PaidFees = -1;
            this.CreatedByUserID = -1;


            Mode = enMode.AddNew;

        }

        // Private Constractor for Update Mode 
        private clsLocalDLApplication(int ApplicationID, int ApplicationPersonID, DateTime ApplicationDate, byte ApplicationTypeID,DateTime lastStatusDate, byte ApplicationStatus, byte PassedTests, double PaidFees, int CreatedByUserID,int LocaLDLApplicationID,byte LicenseClassID)
        :base( ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID,lastStatusDate, ApplicationStatus, PassedTests, PaidFees, CreatedByUserID)
        {
            this.LocaLDLApplicationID = LocaLDLApplicationID;
            this.LicenseClassID = LicenseClassID;
            this.ApplicationID = ApplicationID;
           
            this.ApplicationPersonID = ApplicationPersonID;
            this.ApplicationDate = ApplicationDate;
            this.ApplicationTypeID = ApplicationTypeID;
            this.lastStatusDate = lastStatusDate;
            this.ApplicationStatus = ApplicationStatus;
            this.PassedTests = PassedTests;
            this.PaidFees = PaidFees;
            this.CreatedByUserID = CreatedByUserID;

            Mode = enMode.Update;

        }
                     
        public static int AddNewGlobalApplication(int ApplicationPersonID, DateTime ApplicationDate, byte ApplicationTypeID,DateTime lastStatusDate, byte ApplicationStatus, byte PassedTests, double PaidFees, int CreatedByUserID)
        {
            int ApplicationID = ApplicationDataAccess.AddNewApplication(ApplicationPersonID, ApplicationDate, ApplicationTypeID, lastStatusDate, ApplicationStatus, PassedTests, PaidFees, CreatedByUserID);

            return ApplicationID ;
        }
        private bool _AddNewLocalApplication()
        {
            // add this object to database
            // in AddNew Mode 
            // add Genral application then Find it to add localApplication 
            if (!IsExists(this.ApplicationPersonID, this.LicenseClassID))
            {
                this.ApplicationID = clsLocalDLApplication.AddNewGlobalApplication(this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, this.lastStatusDate, this.ApplicationStatus, this.PassedTests, this.PaidFees, this.CreatedByUserID);

                if (ApplicationID == -1)
                    return false;
            }

            if (!IsExists(this.LocaLDLApplicationID))
            {

                this.LocaLDLApplicationID = LocalDrivingLicenseAppDataAccess.AddNewApplication(this.ApplicationID, this.LicenseClassID);

                if (this.LocaLDLApplicationID == -1)
                    return false;
                else
                    return true;
            }

            return false;

        }
        private bool _UpdateLocalApplication()
        {
            // add this object to database
            if (ApplicationDataAccess.UpdateApplication(this.ApplicationID, this.ApplicationPersonID, this.ApplicationDate, this.ApplicationTypeID, this.lastStatusDate, this.ApplicationStatus, this.PassedTests, this.PaidFees, this.CreatedByUserID))
                return LocalDrivingLicenseAppDataAccess.UpdateApplication(this.LocaLDLApplicationID,this.ApplicationID, this.LicenseClassID);
           
            return false;
        }

        // find by ID , NationalNo
        public static clsLocalDLApplication Find(int LocaLDLApplicationID)
        {

            int ApplicationID = -1,ApplicationPersonID = -1, CreatedByUserID = -1;
            byte LicenseClassID = 0,ApplicationTypeID = 0, ApplicationStatus = 0, PassedTests = 0;
            double PaidFees = -1;
            DateTime ApplicationDate = DateTime.Now , lastStatusDate=DateTime.Now;


            if(LocalDrivingLicenseAppDataAccess.GetLocalApplicationByID(LocaLDLApplicationID, ref ApplicationID, ref LicenseClassID, ref ApplicationPersonID, ref ApplicationDate, ref ApplicationTypeID, ref lastStatusDate, ref ApplicationStatus, ref PassedTests, ref PaidFees, ref CreatedByUserID)) 
            {
                return new clsLocalDLApplication(ApplicationID, ApplicationPersonID, ApplicationDate, ApplicationTypeID, lastStatusDate, ApplicationStatus, PassedTests, PaidFees, CreatedByUserID ,LocaLDLApplicationID, LicenseClassID);
            }
            else 
                return null;
        }


        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLocalApplication())
                    {
                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return this._UpdateLocalApplication();

            }

            return false;
        }

        public static DataTable GetAllLocalApplications()
        {
            return LocalDrivingLicenseAppDataAccess.GetAllLocalDrivingLicenseApplications();
        }

        public static bool Delete(int LocaLDLApplicationID)
        {
            return LocalDrivingLicenseAppDataAccess.DeleteApplication(LocaLDLApplicationID);
        }
        
        public static bool IsExists(int LocaLDLApplicationID)
        {
            return LocalDrivingLicenseAppDataAccess.IsApplicationExists(LocaLDLApplicationID);
        }    
        public static bool IsExists(int ApplicationPersonID,byte LicenseClassID)
        {
            return LocalDrivingLicenseAppDataAccess.IsApplicationExists(ApplicationPersonID, LicenseClassID);
        }

       

    }
}
