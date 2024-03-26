using System;

using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer
{
    public class clsCountryDataAccess
    {

        public static bool GetCountryByName(string CountryName, ref int CountryID)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            String query = "SELECT * FROM  Countries Where CountryName = @CountryName";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    CountryID = (int)reader["CountryID"];
                    
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception Ex)
            {
                // throw An Error
                // IsFound = false;
            }
            finally
            {
                connection.Close();

            }
            
            return IsFound;
        }


        public static bool IsCountyExists(string Name)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
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
            catch (Exception Ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;

        }


        public static DataTable GetAllCountries()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM Countries";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }

                reader.Close();
                connection.Close();

            }

            catch (Exception ex)
            {
                // Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        public static bool GetCountryByID(int CountryID, ref string CountryName)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            String query = "SELECT * FROM  Countries Where CountryID = @CountryID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@CountryID", CountryID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;

                    CountryName = (string)reader["CountryName"];
                   
                }
                else
                {
                    IsFound = false;
                }
                reader.Close();
            }
            catch (Exception Ex)
            {
                // throw An Error
                // IsFound = false;
            }
            finally
            {
                connection.Close();

            }

            return IsFound;
        }




    }
}
