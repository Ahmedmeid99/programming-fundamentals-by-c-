using DVLDBusinessLayer.Drivers;
using DVLDDataAccessLayer.Dreiver;
using DVLDDataAccessLayer.License;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.Licenses
{
    public class clsLicense
    {
        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode = enMode.AddNew;

        public int LicenseID { get; set; }
        public clsApplication ApplicationInfo { get; set; }
        public clsDriver DriverInfo { get; set; }
        public clsLicenseClass LicenseClassInfo { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string Notes { get; set; }
        public double PaidFees { get; set; }
        public bool IsActive { get; set; }
        public byte IssueReason { get; set; }
        public clsUser UserInfo{ get; set; }
        

        // Default Constractor for AddNew Mode 
        public clsLicense()
        {
            this.LicenseID = -1;
            this.ApplicationInfo = new clsApplication();
            this.DriverInfo = new clsDriver();
            this.LicenseClassInfo = new clsLicenseClass();
            this.IssueDate = DateTime.Now;
            this.ExpirationDate = DateTime.Now;
            this.Notes = "";
            this.PaidFees = -1;
            this.IsActive = true;
            this.IssueReason = 0;
            this.UserInfo = new clsUser();

            Mode = enMode.AddNew;

        }
        // Private Constractor for Update Mode 
        private clsLicense(int LicenseID, int ApplicationID,int DriverID,int LicenseClassID,DateTime IssueDate,DateTime ExpirationDate,string Notes,double PaidFees,bool IsActive,byte IssueReason,int CreatedByUserID)
        {   
            this.LicenseID = LicenseID;
            this.ApplicationInfo =clsApplication.FindApplication(ApplicationID);
            this.DriverInfo =clsDriver.Find(DriverID);
            this.LicenseClassInfo =clsLicenseClass.Find(LicenseClassID);
            this.IssueDate = IssueDate;
            this.ExpirationDate = ExpirationDate;
            this.Notes = Notes;
            this.PaidFees = PaidFees;
            this.IsActive = IsActive;
            this.IssueReason = IssueReason;
            this.UserInfo =clsUser.Find(CreatedByUserID);

            Mode = enMode.Update;

        }

        private bool _AddNewLicense()
        {
            // add this object to database
            // in AddNew Mode 
            this.LicenseID = LicenseDataAccess.AddNewLicense(this.ApplicationInfo.ApplicationID, this.DriverInfo.DriverID, this.LicenseClassInfo.LicenseClasseID,this.IssueDate, this.ExpirationDate, this.Notes,this.PaidFees, this.IsActive, this.IssueReason, this.UserInfo.UserID);

            return (this.LicenseID != -1);

        }

        private bool _UpdateLicense()
        {
            // add this object to database
            return LicenseDataAccess.UpdateLicense(LicenseID, ApplicationInfo.ApplicationID,DriverInfo.DriverID,LicenseClassInfo.LicenseClasseID,IssueDate,ExpirationDate,Notes,PaidFees,IsActive,IssueReason,UserInfo.UserID);
        }
        // find by ID , ApplicationID
        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now , ExpirationDate = DateTime.Now ;
            string Notes = ""  ;
            double PaidFees = -1;
            byte IssueReason = 0;
            bool IsActive = false;

            if (LicenseDataAccess.GetLicenseByID(LicenseID,ref  ApplicationID,ref DriverID,ref LicenseClassID,ref IssueDate,ref ExpirationDate,ref Notes,ref PaidFees,ref IsActive,ref IssueReason,ref CreatedByUserID))

            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
                return null;
        }      
        
        public static clsLicense FindByApplicationID(int ApplicationID )
        {
            int LicenseID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now , ExpirationDate = DateTime.Now ;
            string Notes = ""  ;
            double PaidFees = -1;
            byte IssueReason = 0;
            bool IsActive = false;

            if (LicenseDataAccess.GetLicenseByApplicationID(ApplicationID ,ref LicenseID,ref DriverID,ref LicenseClassID,ref IssueDate,ref ExpirationDate,ref Notes,ref PaidFees,ref IsActive,ref IssueReason,ref CreatedByUserID))

            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IssueReason, CreatedByUserID);
            }
            else
                return null;
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return this._UpdateLicense();

            }

            return false;
        }

        public static DataTable GetAllLicenses()
        {
            return LicenseDataAccess.GetAllLicenses();
        }
          
        public static DataTable GetAllDriverLicenses(int DriverID)
        {
            return LicenseDataAccess.GetAllDriverLicenses(DriverID);
        }

        public static bool IsExists(int LicenseID)
        {
            return LicenseDataAccess.IsLicenseExists(LicenseID);
        } 
        public static bool IsApplicationExists(int ApplicationID)
        {
            return LicenseDataAccess.IsApplicationExists(ApplicationID);
        }
       
        public static bool Delete(int LicenseID)
        {
            return LicenseDataAccess.DeleteLicense(LicenseID);
        }
    }
}
