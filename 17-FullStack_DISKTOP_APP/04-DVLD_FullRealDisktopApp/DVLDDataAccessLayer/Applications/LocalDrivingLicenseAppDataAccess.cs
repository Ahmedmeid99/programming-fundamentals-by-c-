using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLDDataAccessLayer
{
    public static class LocalDrivingLicenseAppDataAccess
    {
        public static bool GetLocalApplicationByID(int LocalDLAppID,ref int ApplicationID,ref byte LicenseClassID, ref int ApplicationPersonID, ref DateTime ApplicationDate, ref byte ApplicationTypeID, ref DateTime lastStatusDate, ref byte ApplicationStatus, ref double PaidFees, ref int CreatedByUserID)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM LocalDLAppFullInfo WHERE LocalDrivingLicenseApplicationID = @LocalDLAppID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDLAppID", LocalDLAppID);
          

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    ApplicationID = (int)reader["ApplicationID"];
                    ApplicationPersonID = (int)reader["ApplicationPersonID"];
                    ApplicationDate = (DateTime)reader["ApplicationDate"];
                    lastStatusDate = (DateTime)reader["lastStatusDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
                    LicenseClassID = Convert.ToByte(reader["LicenseClassID"]);
                    ApplicationTypeID = Convert.ToByte(reader["ApplicationTypeID"]);
                    ApplicationStatus = Convert.ToByte(reader["ApplicationStatus"]);

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

        public static int AddNewApplication( int ApplicationID, byte LicenseClassID)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"INSERT INTO LocalDrivingLicenseApplications 
                            (ApplicationID,LicenseClassID)
                            VALUES 
                            (@ApplicationID,@LicenseClassID);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
       


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();  // to get the ApplicationID just added
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

        public static bool UpdateApplication(int LocalDLAppID, int ApplicationID, byte LicenseClassID)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"Update LocalDrivingLicenseApplications  
                            set ApplicationID = @ApplicationID, 
                                LicenseClassID = @LicenseClassID
                               

                                where LocalDrivingLicenseApplicationID = @LocalDLAppID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@LocalDLAppID", LocalDLAppID);
            command.Parameters.AddWithValue("@ApplicationID", ApplicationID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);
            

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

      
        public static DataTable GetAllLocalDrivingLicenseApplications()
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM LocalDLAppImportantInfo"; //  ...

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

        public static bool DeleteApplication(int LocalDLAppID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "DELETE FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDLAppID";

            int RowAffected = 0;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LocalDLAppID", LocalDLAppID);

            try
            {
                connection.Open();
                RowAffected = command.ExecuteNonQuery();

            }
            catch (Exception Ex)
            {
                // Catch Error
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        public static bool IsApplicationExists(int LocalDLAppID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM LocalDrivingLicenseApplications WHERE LocalDrivingLicenseApplicationID = @LocalDLAppID";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationID", LocalDLAppID);

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
         public static bool IsApplicationExists(int ApplicationPersonID, byte LicenseClassID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM LocalDLAppFullInfo WHERE ApplicationPersonID = @ApplicationPersonID and LicenseClassID = @LicenseClassID";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@ApplicationPersonID", ApplicationPersonID);
            command.Parameters.AddWithValue("@LicenseClassID", LicenseClassID);

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

        // check if localApplication Exists (ApplicationType,NationalNo)
       
    }
}
