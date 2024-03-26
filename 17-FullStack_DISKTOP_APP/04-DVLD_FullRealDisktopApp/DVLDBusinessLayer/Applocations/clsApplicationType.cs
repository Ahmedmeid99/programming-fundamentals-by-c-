using System;

using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsApplicationType
    {
        public enum enMode { Update = 1 };
        public enMode Mode = enMode.Update;

        public int ApplicationTypeID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public double Fees { get; set; }
        


        // Default Constractor for AddNew Mode 
        private clsApplicationType(int ApplicationTypeID,string Title, string Description, double Fees)
        {

            this.ApplicationTypeID = ApplicationTypeID;
            this.Title = Title;
            this.Description = Description;
            this.Fees =Fees;

            Mode = enMode.Update;

        }

        // Private Constractor for Update Mode 
        
        private bool _UpdateAppType()
        {
            // add this object to database
            return ApplicationTypeDataAccess.UpdateAppType(ApplicationTypeID,Title,Description,Fees);
        }
        // find by ID , NationalNo
        public static clsApplicationType Find(int ApplicationTypeID)
        {
            string Description = "", Title = "";

            double Fees = -1;

            if (ApplicationTypeDataAccess.GetAppTypeID(ApplicationTypeID,ref Title,ref Description,ref Fees))
            {
                return new clsApplicationType(ApplicationTypeID, Title, Description, Fees);
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
            return ApplicationTypeDataAccess.GetAllAppTypes();
        }

    }
}
