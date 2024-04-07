using System;

using System.Data;
using System.Data.SqlClient;

namespace DVLDDataAccessLayer.Tests
{
    public static class TestDataAccess
    {
        public static bool GetTestByID(int TestID, ref int TestAppointmentID, ref string Notes, ref int CreatedByUserID, ref byte TestResult)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM Tests WHERE TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;

                    TestAppointmentID = (int)reader["TestAppointmentID"];
                    TestResult =(byte) reader["TestResult"];

                    Notes =(string) reader["Notes"];
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
        public static bool GetTestByAppointmentID(int TestAppointmentID , ref int TestID, ref string Notes, ref int CreatedByUserID, ref byte TestResult)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM Tests WHERE TestAppointmentID = @TestAppointmentID";

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

                    TestID = (int)reader["TestID"];
                    TestResult =(byte) reader["TestResult"];

                    Notes =(string) reader["Notes"];
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

        public static int AddNewTest(int TestAppointmentID, string Notes, int CreatedByUserID, byte TestResult)
        {
            //this function will return the new contact id if succeeded and -1 if not.

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"INSERT INTO Tests 
                            (TestAppointmentID,Notes,CreatedByUserID,TestResult)
                            VALUES 
                            (@TestAppointmentID,@Notes,@CreatedByUserID,@TestResult);
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@TestResult", TestResult);


            try
            {
                connection.Open();

                object result = command.ExecuteScalar();  // to get the TestID just added
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

        public static bool UpdateTest(int TestID, int TestAppointmentID, string Notes, int CreatedByUserID, byte TestResult)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"Update Tests  
                            set TestAppointmentID = @TestAppointmentID, 
                                Notes = @Notes, 
                                CreatedByUserID = @CreatedByUserID, 
                                TestResult = @TestResult


                                where TestID = @TestID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);
            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@Notes", Notes);
            command.Parameters.AddWithValue("@CreatedByUserID", CreatedByUserID);
            command.Parameters.AddWithValue("@TestResult", TestResult);

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
        public static DataTable GetAllTests()
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM Tests"; //  TestsView

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

        public static bool DeleteTest(int TestID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "DELETE FROM Tests WHERE TestID = @TestID";

            int RowAffected = 0;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

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

        public static bool IsTestExists(int TestID)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM Tests WHERE TestID = @TestID";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestID", TestID);

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
      public static bool IsTestExists(int TestAppointmentID, byte TestResult)
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);
            string query = "SELECT FOUND = 1 FROM Tests WHERE TestAppointmentID = @TestAppointmentID and TestResult = @TestResult";

            bool IsFound = false;
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestAppointmentID", TestAppointmentID);
            command.Parameters.AddWithValue("@TestResult", TestResult);

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
