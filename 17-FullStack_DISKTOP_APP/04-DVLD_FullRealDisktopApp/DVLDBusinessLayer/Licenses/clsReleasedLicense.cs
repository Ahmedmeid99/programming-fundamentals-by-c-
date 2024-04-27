using DVLDBusinessLayer.Drivers;
using DVLDDataAccessLayer.License;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.Licenses
{
    public class clsReleasedLicense : clsLicense
    {
        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode = enMode.AddNew;

        public int ReleaseID { get; set; }
		public int DetainID {get;set;}
		public double PaidFineFees { get;set; } // PaidFees
        public DateTime ReleasedDate {get;set;} 
		public int ReleaseApplicationID {get;set;}

        public clsReleasedLicense()
        {
            this.ReleaseID = -1;
            this.DetainID = -1;
            this.PaidFineFees = -1;
            this.ReleasedDate = DateTime.Now;
            this.ReleaseApplicationID = -1;

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

            this.Mode = enMode.AddNew;
        }   
        private clsReleasedLicense(int ReleaseID, int DetainID,double PaidFineFees,DateTime ReleasedDate,int ReleaseApplicationID, int LicenseID, int ApplicationID, int DriverID, int LicenseClassID, DateTime IssueDate, DateTime ExpirationDate, string Notes, double PaidFees, bool IsActive, bool IsDetained, byte IssueReason, int CreatedByUserID)
        {
            this.ReleaseID = ReleaseID;
            this.DetainID = DetainID;
            this.PaidFineFees = PaidFineFees;
            this.ReleasedDate = ReleasedDate;
            this.ReleaseApplicationID = ReleaseApplicationID;

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

            this.Mode = enMode.Update;
        }

        // Add Released License
        private bool _AddNewReleasedLicense()
        {
            // add this object to database
            this.ReleaseID = ReleasedLicenseDataAccess.AddReleasedNewLicense( DetainID,LicenseID, PaidFineFees, ReleasedDate, ReleaseApplicationID);

            return (this.DetainID != -1);

        }

        public static clsReleasedLicense FindDetainedLicense(int LicenseID)
        {
            int DetainID = -1, ApplicationID = -1, DriverID = -1, LicenseClassID = -1, CreatedByUserID = -1, ReleaseID = -1, ReleaseApplicationID = -1;
            DateTime IssueDate = DateTime.Now, ExpirationDate = DateTime.Now, ReleasedDate = DateTime.Now;
            string Notes = "";
            double PaidFineFees = -1, PaidFees = -1;
            byte IssueReason = 0;
            bool IsActive = false, IsDetained = false;

            // find LicenseID
            clsLicense License = clsLicense.Find(LicenseID);
            if (License == null)
                return null;

            if (ReleasedLicenseDataAccess.GetRelesedLicenseByLicenseID( LicenseID,ref ReleaseID,ref DetainID,ref PaidFineFees,ref ReleasedDate,ref ReleaseApplicationID))

            {
                return new clsReleasedLicense(DetainID, LicenseID, PaidFineFees, ReleasedDate, ReleaseApplicationID, LicenseID, ApplicationID, DriverID, LicenseClassID, IssueDate, ExpirationDate, Notes, PaidFees, IsActive, IsDetained, IssueReason, CreatedByUserID);
            }
            else
                return null;
        }

        public bool SaveDetainedLicense()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewReleasedLicense())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return false; // add updateLicense Method

            }

            return false;
        }
    }
}
