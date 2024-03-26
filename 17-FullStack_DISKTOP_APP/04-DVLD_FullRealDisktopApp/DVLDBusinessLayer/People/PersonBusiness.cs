using System;
using System.Data;

using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsPerson
    {
        public enum enMode { AddNew = 0, Update = 1 };
        public enMode Mode = enMode.AddNew;

        public int PersonID     {get;set;}
        public string FirstName   {get;set;}
        public string SecondName  {get;set;}
        public string ThirdName {get; set;}
        public string LastName  {get; set;}
        public string Gendor { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone  {get; set;}
        public string Email  {get; set;}
        public string Address {get; set;}
        public int CountryID  {get; set;}
        public string NationalNo  {get; set;}
        public string ImagePath { get; set; }


        // Default Constractor for AddNew Mode 
        public clsPerson()
        {

            this.PersonID = -1;
            this.FirstName = "";
            this.SecondName = "";
            this.ThirdName = "";
            this.LastName = "";
            this.Gendor = "";
            this.DateOfBirth = DateTime.Now;
            this.Phone = "";
            this.Email = "";
            this.Address = "";
            this.CountryID = -1;
            this.NationalNo = "";
            this.ImagePath = "";

            Mode = enMode.AddNew;
           
        }

        // Private Constractor for Update Mode 
        private clsPerson(int PersonID, string FirstName,string SecondName,string ThirdName,string LastName,
                                        string Gendor,DateTime DateOfBirth,string Phone,string Email,string Address
                                                            ,int CountryID,string NationalN,string ImagePath)
        {

            this.PersonID = PersonID;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.Gendor = Gendor;
            this.DateOfBirth = DateOfBirth;
            this.Phone = Phone;
            this.Email = Email;
            this.Address = Address;
            this.CountryID = CountryID;
            this.NationalNo = NationalN;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;

        }
        
        private bool _AddNewContact ()
        {
            // add this object to database
            // in AddNew Mode 
            this.PersonID = clsPersonDataAccess.AddNewPerson( this.FirstName,  this.SecondName,  this.ThirdName,  this.LastName,
                this.Gendor,  this.DateOfBirth,  this.Phone,  this.Email,  this.Address,  this.CountryID,  this.NationalNo,  this.ImagePath);

            return (this.PersonID != -1);
                
        } 
        private bool _UpdateContact()
        {
            // add this object to database
            return clsPersonDataAccess.UpdatePerson(this.PersonID, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.Gendor, this.DateOfBirth, this.Phone, this.Email, this.Address, this.CountryID, this.NationalNo, this.ImagePath);
        }
        // find by ID , NationalNo
        public static clsPerson Find(int ID)
        {
            string FirstName ="", SecondName="",ThirdName ="",LastName  ="",
                   Gendor ="", Phone ="", Email ="",  Address ="",
                   NationalN ="", ImagePath = "";

            DateTime DateOfBirth = DateTime.Now;

            int CountryID = -1;

            if (clsPersonDataAccess.GetPersonByID(ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Gendor, ref DateOfBirth, ref Phone, ref Email, ref Address, ref CountryID, ref NationalN, ref ImagePath))
            {
                return new clsPerson(ID, FirstName, SecondName, ThirdName, LastName,
                                       Gendor, DateOfBirth, Phone, Email, Address
                                                          , CountryID, NationalN, ImagePath);
            }
            else
                return null;
        }

        public static clsPerson Find(string NationalN)
        {
            string FirstName = "", SecondName = "", ThirdName = "", LastName = "",
                   Gendor = "", Phone = "", Email = "", Address = "", ImagePath = "";

            DateTime DateOfBirth = DateTime.Now;

            int CountryID = -1 ,ID = -1;

            if (clsPersonDataAccess.GetPersonByNationalNo(NationalN, ref ID, ref FirstName, ref SecondName, ref ThirdName, ref LastName,
                ref Gendor, ref DateOfBirth, ref Phone, ref Email, ref Address, ref CountryID, ref ImagePath))
            {
                return new clsPerson(ID, FirstName, SecondName, ThirdName, LastName,
                                       Gendor, DateOfBirth, Phone, Email, Address
                                                          , CountryID, NationalN, ImagePath);
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

        public static DataTable GetAllPeople()
        {
            return clsPersonDataAccess.GetAllPeople();
        }

        public static bool Delete(int ID)
        {
            return clsPersonDataAccess.DeletePerson(ID);
        }


        public static bool IsExists(int ID)
        {
           return clsPersonDataAccess.IsPersonExists(ID);
        }

        public static bool IsExists(string NationalNo)
        {
            return clsPersonDataAccess.IsPersonExists(NationalNo);
        }


    }
}