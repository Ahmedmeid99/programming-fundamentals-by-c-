using System;
using System.Data;
using ContactsDataAccessLayer;


namespace ContactBusinessLayer
{
    public class clsCountry
    {
        // get & set properties
       public int CountryID { get; set; }
       public string CountryName { get; set; }
       public string Code { get; set; }
       public string PhoneCode { get; set; }
        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode = enMode.AddNew;

        // default constractor 
        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
            Code = "";
            PhoneCode = "";

            Mode = enMode.AddNew;
        }

        // private constractor 
        public clsCountry(int CountryID, string CountryName,string Code, string PhoneCode)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
            this.Code = Code;
            this.PhoneCode = PhoneCode;

            Mode = enMode.Update;
        }

        public static clsCountry FindByName(string Name)
        {
            // call DataAccess function 

            int CountryID = -1;
            string Code = "";
            string PhoneCode = "";

            if (clsCountryDataAccess.GetCountryByName(Name ,ref CountryID,ref Code, ref PhoneCode ))
                return new clsCountry(CountryID, Name, Code, PhoneCode);
            else
                return null;
        }
        public static clsCountry FindByID(int ID)
        {
            // call DataAccess function 

            string CountryName = "";
            string Code = "";
            string PhoneCode = "";

            if (clsCountryDataAccess.GetCountryByID(ID ,ref CountryName ,ref Code, ref PhoneCode ))
                return new clsCountry(ID, CountryName, Code, PhoneCode);
            else
                return null;
        }

        public static bool IsCountyExists(string Name)
        {
            return clsCountryDataAccess.IsCountyExists(Name);
        }
    
        public static DataTable GetAllCountries()
        {
            return clsCountryDataAccess.GetAllCountries();
        }




    }
}
