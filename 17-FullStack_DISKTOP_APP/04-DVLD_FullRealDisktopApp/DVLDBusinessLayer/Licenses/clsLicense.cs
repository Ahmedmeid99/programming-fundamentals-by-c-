using DVLDBusinessLayer.Drivers;
using DVLDDataAccessLayer.Dreiver;
using DVLDDataAccessLayer.License;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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
        public bool IsDetained { get; set; }
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
            this.IsDetained = false;
            this.IssueReason = 0;
            this.UserInfo = new clsUser();

            Mode = enMode.AddNew;

        }
        // Private Constractor for Update Mode 
        private clsLicense(int LicenseID, int ApplicationID,int DriverID,int LicenseClassID,DateTime IssueDate,DateTime ExpirationDate,string Notes,double PaidFees,bool IsActive,bool IsDetained, byte IssueReason,int CreatedByUserID)
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
            this.IsDetained = IsDetained;
            this.IssueReason = IssueReason;
            this.UserInfo =clsUser.Find(CreatedByUserID);

            Mode = enMode.Update;

        }

        private bool _AddNewLicense()
        {
            // add this object to database
            // in AddNew Mode 
            this.LicenseID = LicenseDataAccess.AddNewLicense(this.ApplicationInfo.ApplicationID, this.DriverInfo.DriverID, this.LicenseClassInfo.LicenseClasseID,this.IssueDate, this.ExpirationDate, this.Notes,this.PaidFees, this.IsActive, this.IsDetained, this.IssueReason, this.UserInfo.UserID);

            return (this.LicenseID != -1);

        }

        private bool _UpdateLicense()
        {
            // add this object to database
            return LicenseDataAccess.UpdateLicense(LicenseID, ApplicationInfo.ApplicationID,DriverInfo.DriverID,LicenseClassInfo.LicenseClasseID,IssueDate,ExpirationDate,Notes,PaidFees,IsActive, IsDetained, IssueReason,UserInfo.UserID);
        }
        // find by ID , ApplicationID
        public static clsLicense Find(int LicenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now , ExpirationDate = DateTime.Now ;
            string Notes = ""  ;
            double PaidFees = -1;
            byte IssueReason = 0;
            bool IsActive = false, IsDetained = false;

            if (LicenseDataAccess.GetLicenseByID(LicenseID,ref  ApplicationID,ref DriverID,ref LicenseClassID,ref IssueDate,ref ExpirationDate,ref Notes,ref PaidFees,ref IsActive,ref IsDetained,ref IssueReason,ref CreatedByUserID))

            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IsDetained, IssueReason, CreatedByUserID);
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
            bool IsActive = false, IsDetained = false;

            if (LicenseDataAccess.GetLicenseByApplicationID(ApplicationID ,ref LicenseID,ref DriverID,ref LicenseClassID,ref IssueDate,ref ExpirationDate,ref Notes,ref PaidFees,ref IsActive,ref IsDetained, ref IssueReason,ref CreatedByUserID))

            {
                return new clsLicense(LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IsDetained, IssueReason, CreatedByUserID);
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
        public static bool IsExpire(int LicenseID)
        {
            return LicenseDataAccess.IsLicenseExpire(LicenseID);
        } 
        public static bool IsApplicationExists(int ApplicationID)
        {
            return LicenseDataAccess.IsApplicationExists(ApplicationID);
        }
       
        public static bool Delete(int LicenseID)
        {
            return LicenseDataAccess.DeleteLicense(LicenseID);
        }

        public bool DeactivateCurrentLicense()
        {
            return (LicenseDataAccess.DeactivateLicense(this.LicenseID));
        }

        public clsLicense Renew(string Notes,int CreatedByUserID)
        {
            // create new application
            clsApplication Application = new clsApplication();

            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (byte)GlobalEnums.enApplicationType.ReNewDrivingLicense;
            Application.ApplicationStatus = (byte)GlobalEnums.enApplicationStatus.CompletedApplication;
            Application.lastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((int)GlobalEnums.enApplicationType.ReNewDrivingLicense).Fees;
            Application.CreatedByUserID = CreatedByUserID;
            Application.ApplicationPersonID = this.DriverInfo.PersonInfo.PersonID;

            if (!Application.SaveApplication())
            {
                return null;
            }

            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationInfo =clsApplication.FindApplication(Application.ApplicationID);
            NewLicense.DriverInfo = this.DriverInfo;
            NewLicense.LicenseClassInfo = this.LicenseClassInfo;
            NewLicense.IssueDate = DateTime.Now;

            int DefaultValidityLength = this.LicenseClassInfo.DefaultValidityLength;

            NewLicense.ExpirationDate = DateTime.Now.AddYears(DefaultValidityLength);
            NewLicense.Notes = Notes;
            NewLicense.PaidFees = this.LicenseClassInfo.ClassFees;
            NewLicense.IsActive = true;
            NewLicense.IssueReason = (byte)GlobalEnums.enApplicationType.ReNewDrivingLicense;
            NewLicense.UserInfo = clsUser.Find(CreatedByUserID);


            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense();

            return NewLicense;
            
        }

        public clsLicense Replace(GlobalEnums.enApplicationType ApplicationTypeID, int CreatedByUserID )
        {
            if (this.IsActive == false) 
            {
                return null;
            }

            // create new application
            clsApplication Application = new clsApplication();

            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (byte)ApplicationTypeID;
            Application.ApplicationStatus = (byte)GlobalEnums.enApplicationStatus.CompletedApplication;
            Application.lastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((int)ApplicationTypeID).Fees; // Apptype
            Application.CreatedByUserID = CreatedByUserID;
            Application.ApplicationPersonID = this.DriverInfo.PersonInfo.PersonID;

            if (!Application.SaveApplication())
            {
                return null;
            }


            clsLicense NewLicense = new clsLicense();

            NewLicense.ApplicationInfo = clsApplication.FindApplication(Application.ApplicationID);
            NewLicense.DriverInfo = this.DriverInfo;
            NewLicense.LicenseClassInfo = this.LicenseClassInfo;
            NewLicense.IssueDate = DateTime.Now;
            NewLicense.ExpirationDate = this.ExpirationDate;
            NewLicense.Notes = this.Notes;
            NewLicense.PaidFees = clsApplicationType.Find((int)ApplicationTypeID).Fees; // no fees for the license because it's a replacement. 
            NewLicense.IsActive = true;
            NewLicense.IssueReason = (byte)ApplicationTypeID;  // Apptype
            NewLicense.UserInfo = clsUser.Find(CreatedByUserID);


            if (!NewLicense.Save())
            {
                return null;
            }

            //we need to deactivate the old License.
            DeactivateCurrentLicense();

            return NewLicense;

        }
    
        public clsDetainedLicense Detain(double FineFees,int CreatedByUserID)
        {
            

            // LicenseID, DetainedDate,IsReleased,FineFees,PersonID

            // try save
            clsDetainedLicense DetainLicense = new clsDetainedLicense();

            DetainLicense.LicenseID = this.LicenseID;
            DetainLicense.DetainedDate = DateTime.Now;
            DetainLicense.IsReleased = false;
            DetainLicense.FineFees = FineFees;
            DetainLicense.PersonID = this.DriverInfo.PersonInfo.PersonID;


            DetainLicense.ApplicationInfo = this.ApplicationInfo;
            DetainLicense.DriverInfo = this.DriverInfo;
            DetainLicense.LicenseClassInfo = this.LicenseClassInfo;
            DetainLicense.IssueDate = this.IssueDate;
            DetainLicense.ExpirationDate = this.ExpirationDate;
            DetainLicense.Notes = this.Notes;
            DetainLicense.PaidFees = this.PaidFees; // no fees for the license because it's a replacement. 
            DetainLicense.IsActive = this.IsActive;
            DetainLicense.IssueReason = this.IssueReason;  
            DetainLicense.UserInfo = clsUser.Find(CreatedByUserID);
            DetainLicense.IsDetained = true;



            if (!DetainLicense.SaveDetainedLicense())
            {
                return null;
            }

            Mode = enMode.Update;
            this.IsDetained = true;

            if (!this.Save())
                return null;

            return DetainLicense;

        }

        public clsReleasedLicense Release(int DetainID, double FineFees,int CreatedByUserID)
        {
            if (this.IsDetained != true)
                return null;

            // create new application
            clsApplication Application = new clsApplication();
            GlobalEnums.enApplicationType ApplicationTypeID = GlobalEnums.enApplicationType.ReleaseDetainedLicense;

            Application.ApplicationDate = DateTime.Now;
            Application.ApplicationTypeID = (byte)ApplicationTypeID;
            Application.ApplicationStatus = (byte)GlobalEnums.enApplicationStatus.CompletedApplication;
            Application.lastStatusDate = DateTime.Now;
            Application.PaidFees = clsApplicationType.Find((int)ApplicationTypeID).Fees; // Apptype
            Application.CreatedByUserID = CreatedByUserID;
            Application.ApplicationPersonID = this.DriverInfo.PersonInfo.PersonID;

            if (!Application.SaveApplication())
            {
                return null;
            }
            // LicenseID, ReleaseID,DetainID,PaidFineFees,ReleasedDate,ReleaseApplicationID


            // try save
            clsReleasedLicense ReleasedLicense = new clsReleasedLicense();

            ReleasedLicense.DetainID = DetainID;
            ReleasedLicense.LicenseID = this.LicenseID;
            ReleasedLicense.ReleasedDate = DateTime.Now;
            ReleasedLicense.PaidFineFees = FineFees;
            ReleasedLicense.ReleaseApplicationID = Application.ApplicationID;


            ReleasedLicense.ApplicationInfo = clsApplication.FindApplication(Application.ApplicationID); ;
            ReleasedLicense.DriverInfo = this.DriverInfo;
            ReleasedLicense.LicenseClassInfo = this.LicenseClassInfo;
            ReleasedLicense.IssueDate = this.IssueDate;
            ReleasedLicense.ExpirationDate = this.ExpirationDate;
            ReleasedLicense.Notes = this.Notes;
            ReleasedLicense.PaidFees = this.PaidFees; // no fees for the license because it's a replacement. 
            ReleasedLicense.IsActive = this.IsActive; // ERROR <<
            ReleasedLicense.IssueReason = (byte)GlobalEnums.enApplicationType.ReleaseDetainedLicense;
            ReleasedLicense.UserInfo = clsUser.Find(CreatedByUserID) ;
            ReleasedLicense.IsDetained = false;



            if (!ReleasedLicense.SaveDetainedLicense())  // add
            {
                return null;
            }

            // update License row
            Mode = enMode.Update;
            this.IsDetained = false;
            if (!this.Save())
                return null;

            // update DetainedLicense row
            clsDetainedLicense DetainedLicense = clsDetainedLicense.FindDetainedLicense(ReleasedLicense.LicenseID);
            DetainedLicense.IsReleased = true;

            if (!DetainedLicense.SaveDetainedLicense())
                return null;

            return ReleasedLicense;
        }


    }
}
