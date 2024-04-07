using System;
using System.Data;
using DVLDDataAccessLayer;
using DVLDDataAccessLayer.Dreiver;


namespace DVLDBusinessLayer.Drivers
{
    public class clsDriver
    {
        public enum enMode { AddNew = 1, Update = 2 };
        public enMode Mode = enMode.AddNew;

        public int DriverID { get; set; }
        public clsPerson PersonInfo { get; set; }
        public clsUser UserInfo { get; set; }
        public DateTime CreatedDate { get; set; }




        // Default Constractor for AddNew Mode 
        public clsDriver()
        {
            this.DriverID = -1;
            this.PersonInfo = new clsPerson();
            this.UserInfo = new clsUser();
            this.CreatedDate = DateTime.Now;

            Mode = enMode.AddNew;

        }    
        // Private Constractor for Update Mode 
        private clsDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {

            this.DriverID = DriverID;
            this.PersonInfo = clsPerson.Find(PersonID);
            this.UserInfo = clsUser.Find(CreatedByUserID);
            this.CreatedDate = CreatedDate;

            Mode = enMode.Update;
        }

        private bool _AddNewDriver()
        {
            // add this object to database
            // in AddNew Mode 
            this.DriverID = DriverDataAccess.AddNewDriver(this.DriverID, this.PersonInfo.PersonID, this.UserInfo.UserID, CreatedDate);

            return (this.DriverID != -1);

        }


        private bool _UpdateDriver()
        {
            // add this object to database
            return DriverDataAccess.UpdateDriver(DriverID, PersonInfo.PersonID, UserInfo.UserID, CreatedDate);
        }
        // find by ID , NationalNo
        public static clsDriver Find(int DriverID)
        {
            int PersonID = -1, CreatedByUserID = -1;

            DateTime CreatedDate = DateTime.Now;

            if (DriverDataAccess.GetDriverByID(DriverID, ref PersonID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }      
        public static clsDriver FindPerson(int PersonID )
        {
            int  DriverID= -1, CreatedByUserID = -1;

            DateTime CreatedDate = DateTime.Now;

            if (DriverDataAccess.GetDriverByPersonID( PersonID, ref DriverID, ref CreatedByUserID, ref CreatedDate))
            {
                return new clsDriver(DriverID, PersonID, CreatedByUserID, CreatedDate);
            }
            else
                return null;
        }



        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewDriver())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.Update:

                    return this._UpdateDriver();

            }

            return false;
        }

        public static DataTable GetAllDrivers()
        {
            return DriverDataAccess.GetAllDrivers();
        }   
        
        public static bool IsExists(int DriverID)
        {
            return DriverDataAccess.IsDriverExists(DriverID);
        } 
        public static bool IsPersonExists(int PersonID)
        {
            return DriverDataAccess.IsPersonDriverExists(PersonID);
        }      
        
        public static bool Delete(int DriverID)
        {
            return DriverDataAccess.DeleteDriver(DriverID);
        }
    }
}
