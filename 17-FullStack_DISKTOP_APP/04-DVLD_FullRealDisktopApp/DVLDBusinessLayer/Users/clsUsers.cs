using System;
using System.Data;

using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsUser
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int UserID  {get;set;}
        public int PersonID  {get;set;}
        public string UserName { get; set; }
        public string Password { get; set; } 
        public int Permission { get; set; }
        public bool Active { get; set; }


        // Default Constractor for AddNew Mode 
        public clsUser()
        {

            this.UserID = -1;
            this.PersonID = -1;
            this.UserName = "";
            this.Password = "";
            this.Permission = 0;
            this.Active = true;

            Mode = enMode.AddNew;
           
        }

        // Private Constractor for Update Mode 
        private clsUser(int UserID,int PersonID,string UserName, string Password,int Permission,bool Active)
        {

            this.UserID = UserID;
            this.PersonID = PersonID;
            this.UserName = UserName;
            this.Password = Password;     
            this.Permission = Permission;
            this.Active = Active;

            Mode = enMode.Update;

        }
        
        private bool _AddNewContact ()
        {
            // add this object to database
            // in AddNew Mode 
            this.UserID = clsUserDataAccess.AddNewUser(this.PersonID,this.UserName, this.Password,this.Permission, this.Active);

            return (this.PersonID != -1);
                
        } 
        private bool _UpdateContact()
        {
            // add this object to database
            return clsUserDataAccess.UpdateUser(this.UserID, this.PersonID,this.UserName, this.Password,this.Permission, this.Active);
        }
        // find by ID , NationalNo
        public static clsUser Find(int UserID)
        {
            string  UserName = "", Password = "";

            int  PersonID = -1, Permission = 0 ;
            bool Active = true;

            if (clsUserDataAccess.GetUserByID(UserID,ref PersonID,ref UserName, ref Password,ref Permission, ref Active))
            {
                return new clsUser(UserID,PersonID, UserName, Password, Permission, Active);
            }
            else
                return null;
        }

        public static clsUser FindPerson(int PersonID)
        {
            string UserName = "", Password = "";

            int UserID = -1, Permission = 0;
            bool Active = true;

            if (clsUserDataAccess.GetUserByPersonID(PersonID, ref  UserID, ref UserName, ref Password, ref Permission, ref Active))
            {
                return new clsUser(UserID, PersonID, UserName, Password, Permission, Active);
            }
            else
                return null;
        }

        public static clsUser Find(string UserName,string Password)
        {
            

            int UserID = -1 , PersonID = -1, Permission = 0;
            
            bool Active = true;
            
            if (clsUserDataAccess.GetUserByUserNPassword(UserName, Password,ref UserID, ref PersonID,ref Permission, ref Active))
            {
                return new clsUser(UserID, PersonID, UserName, Password, Permission, Active);
            }
            else
                return null;
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.AddNew:
                    if (_AddNewContact())
                    {

                        Mode = enMode.Update;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case enMode.Update:

                    return this._UpdateContact();

            }

            return false;
        }

        public static DataTable GetAllUsers()
        {
            return clsUserDataAccess.GetAllUsers();
        }

        public static bool Delete(int UserID)
        {
            return clsUserDataAccess.DeleteUser(UserID);
        }


        public static bool IsExists(int UserID)
        {
           return clsUserDataAccess.IsUserExists(UserID);
        }

        

        
       
    }
}