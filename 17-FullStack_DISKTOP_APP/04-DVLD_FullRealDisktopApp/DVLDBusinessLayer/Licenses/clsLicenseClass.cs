using System;
using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsLicenseClass
    {
        public enum enMode {AddNew = 1 ,Update = 2 };
        public enMode Mode = enMode.AddNew;

        public int LicenseClasseID { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public byte MinimumAllowedAge { get; set; }
        public byte DefaultValidityLength { get; set; }
        public double ClassFees { get; set; }


        public clsLicenseClass()
        {
            this.LicenseClasseID = -1;
            this.ClassName = "";
            this.ClassDescription = "";
            this.MinimumAllowedAge = 0;
            this.DefaultValidityLength = 0;
            this.ClassFees = -1;

            Mode = enMode.AddNew;

        }

        // Default Constractor for AddNew Mode 
        private clsLicenseClass(int LicenseClasseID, string ClassName,string ClassDescription,byte MinimumAllowedAge,byte DefaultValidityLength,double ClassFees)
        {
            this.LicenseClasseID = LicenseClasseID;
            this.ClassName = ClassName;
            this.ClassDescription = ClassDescription;
            this.MinimumAllowedAge = MinimumAllowedAge;
            this.DefaultValidityLength = DefaultValidityLength;
            this.ClassFees = ClassFees;

            Mode = enMode.Update;

        }

        // Private Constractor for Update Mode 

        private bool _UpdateAppType()
        {
            // add this object to database
            return LicenseClasseDataAccess.UpdateLicenseClasse( LicenseClasseID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
        }
        // find by ID , NationalNo
        public static clsLicenseClass Find(int LicenseClasseID)
        {
            string ClassName = "", ClassDescription = "";
            double ClassFees = -1;
            byte DefaultValidityLength = 0, MinimumAllowedAge = 0;

            if (LicenseClasseDataAccess.GetLicenseClasseByID(LicenseClasseID,ref ClassName,ref ClassDescription,ref MinimumAllowedAge,ref DefaultValidityLength,ref ClassFees))
            {
                return new clsLicenseClass(LicenseClasseID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
                return null;
        }

        public static clsLicenseClass Find(string ClassName)
        {
            string  ClassDescription = "";
            double ClassFees = -1;
            int LicenseClasseID = -1;
            byte DefaultValidityLength = 0, MinimumAllowedAge = 0;

            if (LicenseClasseDataAccess.GetLicenseClasseByName(ClassName , ref LicenseClasseID , ref ClassDescription, ref MinimumAllowedAge, ref DefaultValidityLength, ref ClassFees))
            {
                return new clsLicenseClass(LicenseClasseID, ClassName, ClassDescription, MinimumAllowedAge, DefaultValidityLength, ClassFees);
            }
            else
                return null;
        }


        public bool Save()
        {
            switch (Mode)
            {

                case enMode.Update:

                    return this._UpdateAppType();

            }

            return false;
        }

        public static DataTable GetAllAppTypes()
        {
            return LicenseClasseDataAccess.GetAllLicenseClasses();
        }

    }
}
