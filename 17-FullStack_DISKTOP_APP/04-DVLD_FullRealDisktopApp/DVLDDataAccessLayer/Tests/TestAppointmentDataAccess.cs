using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer.Tests
{
    public static class TestAppointmentDataAccess
    {
        public static bool GetTestAppointmentByID(int TestAppointmentID, ref int TestTypeID, ref int LDLApplicationID, ref DateTime AppointmentDate, ref double PaidFees, ref int CreatedByUserID ,ref bool IsLocked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    TestTypeID = (int)reader["TestTypeID"];
                    LDLApplicationID = (int)reader["LDLApplicationID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    IsLocked = Convert.ToBoolean(reader["IsLocked"]);
                    
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
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
        public static bool GetTestAppointmentByLDLApplicationID( int LDLApplicationID, int TestTypeID,  ref int TestAppointmentID, ref DateTime AppointmentDate, ref double PaidFees, ref int CreatedByUserID ,ref bool IsLocked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT Top 1 * FROM TestAppointments WHERE LDLApplicationID = @LDLApplicationID and TestTypeID = @TestTypeID ORDER BY AppointmentDate Desc";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    IsLocked = Convert.ToBoolean(reader["IsLocked"]);
                    
                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
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

        public static int AddNewTestAppointment( int TestTypeID, int LDLApplicationID, DateTime AppointmentDate, double PaidFees, int CreatedByUserID, bool IsLocked)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"INSERT INTO TestAppointments 
                            (TestTypeID,LDLApplicationID,AppointmentDate,PaidFees,CreatedByUserID,IsLocked)
                            VALUES 
                            (@TestTypeID,@LDLApplicationID,@AppointmentDate,@PaidFees,@CreatedByUserID,@IsLocked);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);


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

        public static bool UpdateTestAppointment(int TestAppointmentID, int TestTypeID, int LDLApplicationID, DateTime AppointmentDate, double PaidFees, int CreatedByUserID, bool IsLocked)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"Update TestAppointments  
                            set TestTypeID = @TestTypeID, 
                                LDLApplicationID = @LDLApplicationID, 
                                AppointmentDate = @AppointmentDate, 
                                PaidFees = @PaidFees, 
                                CreatedByUserID = @CreatedByUserID, 
                                IsLocked = @IsLocked


                                where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@AppointmentDate", AppointmentDate);
            command.Parameters.AddWithValue("@PaidFees", PaidFees);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);

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
        public static bool UpdateTestAppointmentStatus(int TestAppointmentID, bool IsLocked)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"Update TestAppointments  
                            set IsLocked = @IsLocked
                            where TestAppointmentID = @TestAppointmentID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@IsLocked", IsLocked);


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
        
        public static DataTable GetAllTestAppointments()
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM TestAppointmentsView"; //  ...

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
        public static DataTable GetAllTestAppointments(int LDLApplicationID, int TestTypeID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM TestAppointments where LDLApplicationID = @LDLApplicationID and TestTypeID = @TestTypeID"; //  ...

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);

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

        public static bool DeleteTestAppointment(int TestAppointmentID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "DELETE FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            int RowAffected = 0;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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

        public static bool IsTestAppointmentExists(int TestAppointmentID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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
        
        public static bool HasActiveTestAppoinment(int LDLApplicationID,int TestTypeID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM TestAppointments WHERE LDLApplicationID = @LDLApplicationID and TestTypeID = @TestTypeID and IsLocked = 0";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
        
        public static bool HasPrevTestAppoinment(int LDLApplicationID,int TestTypeID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM TestAppointments WHERE LDLApplicationID = @LDLApplicationID and TestTypeID = @TestTypeID";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

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
        
        public static bool IsLockedTestAppoinment(int TestAppointmentID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM TestAppointments WHERE TestAppointmentID = @TestAppointmentID and IsLocked = 1";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);

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
        
        public static bool FirstTestTestAppoinment(int LDLApplicationID, int TestTypeID, ref int TestAppointmentID, ref DateTime AppointmentDate, ref double PaidFees, ref int CreatedByUserID, ref bool IsLocked)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT Top 1 * FROM TestAppointments WHERE LDLApplicationID = @LDLApplicationID and TestTypeID = @TestTypeID ORDER BY AppointmentDate ";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@LDLApplicationID", LDLApplicationID);
            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    AppointmentDate = (DateTime)reader["AppointmentDate"];
                    IsLocked = Convert.ToBoolean(reader["IsLocked"]);

                    PaidFees = Convert.ToDouble(reader["PaidFees"]);
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



    }
}
