using System;
using System.Data.SqlClient;


namespace ContactsDataAccessLayer
{
    public class clsCountryDataAccess
    { 
       
        public static bool GetCountryByName(string CountryName,ref int CountryID,ref string Code, ref string PhoneCode)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            String query = "SELECT * FROM  Countries Where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if(reader.Read())
                {
                    IsFound = true;

                    CountryID = (int)reader["CountryID"];
                    Code = (string)reader["Code"];
                    PhoneCode = (string)reader["PhoneCode"];
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }catch(Exception Ex)
            {
                // throw An Error
               // IsFound = false;
            }finally
            {
                connection.Close();

            }
            // IS Country Exists
            // SELECT Found = 1
            // FROM Countries Where CountryName = 'United States'

            // Find by name
            // SELECT*
            // FROM  Countries Where CountryName = 'United States'
            return IsFound;
        }

    
        public static bool IsCountyExists(string Name)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsDataAccessSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM Countries WHERE CountryName= @CountryName";
            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", Name);
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                IsFound = reader.HasRows;

                reader.Close();
            }
            catch(Exception Ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }
    
    
    
    
    
    
    }
}
