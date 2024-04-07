using System;
using System.Data.SqlClient;
using System.Data;


namespace DVLDDataAccessLayer
{
    public static class TestTypeDataAccess
    {
        public static bool GetTestTypeID(int TestTypeID, ref string Title, ref string Description, ref double Fees)
        {
            bool isFound = false;

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes WHERE TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    // The record was found
                    isFound = true;


                    Title = (string)reader["Title"];
                    Description = (string)reader["Description"];
                    Fees = Convert.ToDouble(reader["Fees"]);
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

        public static bool UpdateTestType(int TestTypeID, string Title, string Description, double Fees)
        {

            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = @"Update TestTypes  
                            set Title = @Title, 
                                Description = @Description,
                                Fees = @Fees

                                where TestTypeID = @TestTypeID";

            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@TestTypeID", TestTypeID);
            command.Parameters.AddWithValue("@Title", Title);
            command.Parameters.AddWithValue("@Description", Description);
            command.Parameters.AddWithValue("@Fees", Fees);


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

        public static DataTable GetAllTestTypes()
        {

            SqlConnection connection = new SqlConnection(clsSettings.ConnectionString);

            string query = "SELECT * FROM TestTypes";

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
