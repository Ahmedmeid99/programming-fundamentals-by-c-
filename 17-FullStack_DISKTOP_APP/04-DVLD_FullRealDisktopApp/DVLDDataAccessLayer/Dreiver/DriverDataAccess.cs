using System;
using System.Data;
using System.Data.SqlClient;


namespace DVLDDataAccessLayer.Dreiver
{
    public static class DriverDataAccess
    {
        public static bool GetDriverByID(int DriverID, ref int PersonID, ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM Drivers WHERE DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;


                    PersonID = (int)reader["PersonID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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
        public static bool GetDriverByPersonID(int PersonID , ref int DriverID , ref int CreatedByUserID, ref DateTime CreatedDate)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM Drivers WHERE PersonID = @PersonID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;


                    DriverID = (int)reader["DriverID"];
                    CreatedDate = (DateTime)reader["CreatedDate"];
                    CreatedByUserID = (int)reader["CreatedByUserID"];

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

        public static bool UpdateDriver(int DriverID,int PersonID,int CreatedByUserID,DateTime CreatedDate)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"Update Drivers  
                            set PersonID = @PersonID, 
                                CreatedDate = @CreatedDate,
                                CreatedByUserID = @CreatedByUserID

                                where DriverID = @DriverID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);


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

        public static DataTable GetAllDrivers()
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM DriversView";

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

        public static int AddNewDriver(int DriverID, int PersonID, int CreatedByUserID, DateTime CreatedDate)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"INSERT INTO Drivers 
                            (PersonID,CreatedByUserID,CreatedDate)
                            VALUES 
                            (@PersonID,@CreatedByUserID,@CreatedDate);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);
            command.Parameters.AddWithValue("@PersonID", PersonID);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@CreatedDate", CreatedDate);
            


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

        public static bool DeleteDriver(int DriverID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "DELETE FROM Drivers WHERE DriverID = @DriverID";

            int RowAffected = 0;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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

        public static bool IsDriverExists(int DriverID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM Drivers WHERE DriverID = @DriverID";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@DriverID", DriverID);

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
        public static bool IsPersonDriverExists(int PersonID)
        {
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM Drivers WHERE PersonID = @PersonID";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@PersonID", PersonID);

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


    }
}
