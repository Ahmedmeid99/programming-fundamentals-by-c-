using DVLDBusinessLayer.Drivers;
using DVLDDataAccessLayer.License;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.Licenses
{
    public class clsDetainedLicense	:clsLicense
    {
        public enum enDetainMode { AddNew = 1, Update = 2 };
        public enDetainMode DetainMode = enDetainMode.AddNew;

        public int DetainID  {get;set;}
		public DateTime DetainedDate  {get;set;}
		public bool IsReleased  {get;set;}
		public double FineFees {get;set;}
		public int PersonID   {get;set;}

        public clsDetainedLicense ()
        {
            this.DetainID = -1;
            this.DetainedDate= DateTime.Now;
            this.IsReleased= false;
            this.FineFees= -1;
            this.PersonID= -1;

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

            this.DetainMode = enDetainMode.AddNew;
        }  
        
        private clsDetainedLicense (int DetainID, DateTime DetainedDate,bool IsReleased ,double FineFees,int PersonID, int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, double PaidFees, bool IsActive, bool IsDetained, byte IssueReason, int CreatedByUserID)
        {
            this.DetainID = DetainID;
            this.DetainedDate = DetainedDate;
            this.IsReleased = IsReleased;
            this.FineFees = FineFees;
            this.PersonID = PersonID;

            base.LicenseID = LicenseID;
            base.ApplicationInfo = clsApplication.FindApplication(ApplicationID);
            base.DriverInfo = clsDriver.Find(DriverID);
            base.LicenseClassInfo = clsLicenseClass.Find(LicenseClassID);
            base.IssueDate = IssueDate;
            base.ExpirationDate = ExpirationDate;
            base.Notes = Notes;
            base.PaidFees = PaidFees;
            base.IsActive = IsActive;
            base.IsDetained = IsDetained;
            base.IssueReason = IssueReason;
            base.UserInfo = clsUser.Find(CreatedByUserID);

            this.DetainMode = enDetainMode.Update;
        }

        // Add Detained License
        private bool _AddNewDetainedLicense()
        {
            // add this object to database
            this.DetainID = DetainedLicenseDataAccess.AddDetainedNewLicense(LicenseID, DetainedDate,IsReleased,FineFees,PersonID);

            return (this.DetainID != -1);

        }

        private bool _UpdateDetainedLicense()
        {
            // add this object to database
            return DetainedLicenseDataAccess.UpdateDetainedLicense(DetainID, LicenseID, DetainedDate, IsReleased, FineFees, PersonID);
        }
        // Find Detained License

        public static clsDetainedLicense FindDetainedLicense(int LicenseID )
        {
            int  DetainID= -1, PersonID = -1, ApplicationID = -1,DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now, DetainedDate = DateTime.Now;
            string Notes = "";
            double PaidFees = -1,FineFees  = -1;
            byte IssueReason = 0;
            bool IsActive = false, IsDetained = false,IsReleased  = false;

            // find LicenseID
            clsLicense License = clsLicense.Find(LicenseID);
            if (License == null)
                return null;

            ApplicationID = License.ApplicationInfo.ApplicationID;
            DriverID = License.DriverInfo.DriverID;
            LicenseClassID = License.LicenseClassInfo.LicenseClasseID;
            IssueDate = License.IssueDate;
            ExpirationDate = License.ExpirationDate;
            Notes = License.Notes;
            PaidFees = License.PaidFees;
            IsActive = License.IsActive;
            IsDetained = License.IsDetained;
            IssueReason = License.IssueReason;
            CreatedByUserID = License.UserInfo.UserID;

            if (DetainedLicenseDataAccess.GetDetainedLicenseByLicenseID(LicenseID ,ref DetainID , ref DetainedDate,ref IsReleased,ref FineFees,ref PersonID))

            {
                return new clsDetainedLicense(DetainID, DetainedDate, IsReleased, FineFees, PersonID, LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IsDetained, IssueReason, CreatedByUserID);
            }
            else
                return null;
        }

        public bool SaveDetainedLicense()
        {
            switch (DetainMode)
            {
                case enDetainMode.AddNew:
                    if (_AddNewDetainedLicense())
                    {

                        DetainMode = enDetainMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enDetainMode.Update:

                    return _UpdateDetainedLicense(); // add updateLicense Method

            }

            return false;
        }

        public static bool IsLicenseExists(int DetainID)
        {
            return DetainedLicenseDataAccess.IsLicenseExists(DetainID);
        }  

        public static DataTable GetAllDetainedLicenses()
        {
            return DetainedLicenseDataAccess.GetAllDetainedLicenses();
        }

    }
}
