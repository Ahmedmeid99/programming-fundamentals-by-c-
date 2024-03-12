using System;

using System.Data;
using DVLDDataAccessLayer;

namespace DVLDBusinessLayer
{
    public class clsCountry
    {
        // get & set properties
        public int CountryID { get; set; }
        public string CountryName { get; set; }

        enum enMode { AddNew = 1, Update = 2 }
        enMode Mode = enMode.AddNew;

        // default constractor 
        public clsCountry()
        {
            CountryID = -1;
            CountryName = "";
           
            Mode = enMode.AddNew;
        }

        // private constractor 
        public clsCountry(int CountryID, string CountryName)
        {
            this.CountryID = CountryID;
            this.CountryName = CountryName;
           
            Mode = enMode.Update;
        }

        public static clsCountry Find(string Name)
        {
            // call DataAccess function 

            int CountryID = -1;
            
            if (clsCountryDataAccess.GetCountryByName(Name, ref CountryID))
                return new clsCountry(CountryID, Name);
            else
                return null;
        }
       
        public static clsCountry Find(int ID)
        {
            // call DataAccess function 

            string CountryName = "";
            
            if (clsCountryDataAccess.GetCountryByID(ID, ref CountryName))
                return new clsCountry(ID, CountryName);
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
