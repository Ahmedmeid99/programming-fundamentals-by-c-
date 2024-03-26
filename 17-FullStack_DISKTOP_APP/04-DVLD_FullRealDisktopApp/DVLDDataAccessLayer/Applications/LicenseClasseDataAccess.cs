using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLDDataAccessLayer
{
    public static class LicenseClasseDataAccess
    {
        public static bool GetLicenseClasseByID(int LicenseClasseID,ref string ClassName,ref string ClassDescription,ref byte MinimumAllowedAge,ref byte DefaultValidityLength,ref double ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE LicenseClasseID = @LicenseClasseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClasseID", LicenseClasseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    
                    MinimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                    ClassName =(string) reader["ClassName"] ;
                    ClassFees = Convert.ToDouble(reader["ClassFees"]);
                    ClassDescription = Convert.ToString(reader["ClassDescription"]);
                    DefaultValidityLength =Convert.ToByte(reader["DefaultValidityLength"]);
                    reader.Close();
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }
        public static bool GetLicenseClasseByName( string ClassName,ref int LicenseClasseID,ref string ClassDescription,ref byte MinimumAllowedAge,ref byte DefaultValidityLength,ref double ClassFees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses WHERE ClassName = @ClassName";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ClassName", ClassName);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;


                    LicenseClasseID = (int)reader["LicenseClasseID"];
                    ClassDescription = (string)reader["ClassDescription"];
                    MinimumAllowedAge = Convert.ToByte(reader["MinimumAllowedAge"]);
                    DefaultValidityLength = (byte)reader["DefaultValidityLength"];
                    ClassFees = Convert.ToDouble(reader["ClassFees"]);
                    reader.Close();
                }
                else
                {
                    // The record was not found
                    isFound = false;
                }

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static bool UpdateLicenseClasse(int LicenseClasseID, string ClassName, string ClassDescription, byte MinimumAllowedAge,  byte DefaultValidityLength, double ClassFees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"Update LicenseClasses  
                            set ClassName = @ClassName, 
                                ClassDescription = @ClassDescription,
                                MinimumAllowedAge = @MinimumAllowedAge
                                DefaultValidityLength = @DefaultValidityLength
                                ClassFees = @ClassFees

                                where LicenseClasseID = @LicenseClasseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseClasseID", LicenseClasseID);
            command.Parameters.AddWithValue("@ClassName", ClassName);
            command.Parameters.AddWithValue("@ClassDescription", ClassDescription);
            command.Parameters.AddWithValue("@MinimumAllowedAge", MinimumAllowedAge);
            command.Parameters.AddWithValue("@DefaultValidityLength", DefaultValidityLength);
            command.Parameters.AddWithValue("@ClassFees", ClassFees);


            try
            {
                connection.Open();

                rowsAffected = command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }

            finally
            {
                connection.Close();
            }

            return (rowsAffected > 0);
        }

        public static DataTable GetAllLicenseClasses()
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM LicenseClasses";

            SqlCommand command = new SqlCommand(query, connection);

            DataTable dt = new DataTable();
            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows)

                {
                    dt.Load(reader);
                }
                reader.Close();


            }
            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return dt;

        }

    }

}
