using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DVLDDataAccessLayer.License
{
    public static class ReleasedLicenseDataAccess
    {
        public static int AddReleasedNewLicense(int DetainID,int LicenseID,double PaidFees,DateTime ReleasedDate,int ReleaseApplicationID  )
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"INSERT INTO ReleasedLicenses 
                            (DetainID,LicenseID,PaidFees,ReleasedDate,ReleaseApplicationID)
                            VALUES 
                            (@DetainID,@LicenseID,@PaidFees,@ReleasedDate,@ReleaseApplicationID)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DetainID", DetainID);
            command.Parameters.AddWithValue("@LicenseID", LicenseID);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@ReleasedDate", ReleasedDate);
            command.Parameters.AddWithValue("@ReleaseApplicationID", ReleaseApplicationID);

            try
            {
                connection.Open();

                object result = command.ExecuteScalar();  // to get the TestAppointmentID just added
                connection.Close();

                if (result != null && int.TryParse(result.ToString(), out int insertedID))
                {
                    Console.WriteLine(insertedID);
                    return insertedID;
                }
                else
                {
                    return -1;
                }
            }

            catch (Exception ex)
            {
                //Console.WriteLine("Error: " + ex.Message);

            }

            return -1;
        }

        public static bool GetRelesedLicenseByLicenseID(int LicenseID,ref int ReleaseID,ref int DetainID,ref double PaidFees,ref DateTime ReleasedDate,ref int ReleaseApplicationID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM ReleasedLicenses WHERE LicenseID = @LicenseID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LicenseID", LicenseID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;


                    ReleaseID = (int)reader["ReleaseID"];
                    DetainID = (int)reader["DetainID"];
                    ReleasedDate= (DateTime)reader["ReleasedDate"];
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    ReleaseApplicationID = (int)reader["ReleaseApplicationID"];

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


    }
}
