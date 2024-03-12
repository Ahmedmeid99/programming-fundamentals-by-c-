using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
namespace Connect_C__SQL
{
    internal class Program
    {
        static string ConnectionString = "Server=.;Database=ContactsDB;User Id=sa;Password=sa123456;";
        

        static void PrintAllContacts()
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string Query = "SELECT * FROM Contacts";

            SqlCommand Command = new SqlCommand(Query, Connection);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                while(Reader.Read())
                {
                    int ContactID = (int)Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine($"ContactID:{ContactID}");
                    Console.WriteLine($"FirstName:{FirstName}");
                    Console.WriteLine($"LastName:{LastName}");
                    Console.WriteLine($"Email:{Email}");
                    Console.WriteLine($"Phone:{Phone}");
                    Console.WriteLine($"Address:{Address}");
                    Console.WriteLine($"CountryID:{CountryID}");
                    Console.WriteLine();
                }

                Reader.Close();
                Connection.Close();
            }
            catch(Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
        }

        static void PrintAllContactsWithFirstNameAndCountry(string firstName,int countryID)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string Query = "SELECT * FROM Contacts WHERE FirstName = @firstName AND CountryID = @countryID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@firstName", firstName);
            Command.Parameters.AddWithValue("@countryID", countryID);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    int ContactID = (int)Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine($"ContactID:{ContactID}");
                    Console.WriteLine($"FirstName:{FirstName}");
                    Console.WriteLine($"LastName:{LastName}");
                    Console.WriteLine($"Email:{Email}");
                    Console.WriteLine($"Phone:{Phone}");
                    Console.WriteLine($"Address:{Address}");
                    Console.WriteLine($"CountryID:{CountryID}");
                    Console.WriteLine();
                }

                Reader.Close();
                Connection.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
        }

        static void SearchContactsFirstNameStartWith(string StartWith)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string Query = "SELECT * FROM Contacts WHERE FirstName LIKE '' + @StartWith + '%'";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@StartWith", StartWith);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    int ContactID = (int)Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine($"ContactID:{ContactID}");
                    Console.WriteLine($"FirstName:{FirstName}");
                    Console.WriteLine($"LastName:{LastName}");
                    Console.WriteLine($"Email:{Email}");
                    Console.WriteLine($"Phone:{Phone}");
                    Console.WriteLine($"Address:{Address}");
                    Console.WriteLine($"CountryID:{CountryID}");
                    Console.WriteLine();
                }

                Reader.Close();
                Connection.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
        }

        static void SearchContactsFirstNameContains(string Contains)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string Query = "SELECT * FROM Contacts WHERE FirstName LIKE '%' + @Contains + '%'";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@Contains", Contains);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    int ContactID = (int)Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine($"ContactID:{ContactID}");
                    Console.WriteLine($"FirstName:{FirstName}");
                    Console.WriteLine($"LastName:{LastName}");
                    Console.WriteLine($"Email:{Email}");
                    Console.WriteLine($"Phone:{Phone}");
                    Console.WriteLine($"Address:{Address}");
                    Console.WriteLine($"CountryID:{CountryID}");
                    Console.WriteLine();
                }

                Reader.Close();
                Connection.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
        }

        static void SearchContactsFirstNameEndWith(string EndWith)
        {
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string Query = "SELECT * FROM Contacts WHERE FirstName LIKE '%' + @EndWith + ''";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@EndWith", EndWith);

            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                while (Reader.Read())
                {
                    int ContactID = (int)Reader["ContactID"];
                    string FirstName = (string)Reader["FirstName"];
                    string LastName = (string)Reader["LastName"];
                    string Email = (string)Reader["Email"];
                    string Phone = (string)Reader["Phone"];
                    string Address = (string)Reader["Address"];
                    int CountryID = (int)Reader["CountryID"];

                    Console.WriteLine($"ContactID:{ContactID}");
                    Console.WriteLine($"FirstName:{FirstName}");
                    Console.WriteLine($"LastName:{LastName}");
                    Console.WriteLine($"Email:{Email}");
                    Console.WriteLine($"Phone:{Phone}");
                    Console.WriteLine($"Address:{Address}");
                    Console.WriteLine($"CountryID:{CountryID}");
                    Console.WriteLine();
                }

                Reader.Close();
                Connection.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
        }

        static string FindFirstNameWhere(int ID)
        {
            string FirstName = "";
            SqlConnection Connection = new SqlConnection(ConnectionString);
            string Query = "SELECT FirstName FROM Contacts WHERE ContactID = @contactID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@contactID",ID);
            try
            {
                Connection.Open();
                object Result = Command.ExecuteScalar(); // To Get Single Value

                if(Result != null)
                {
                    FirstName = Result.ToString();
                }
                else
                {
                    FirstName = "";
                }
                Connection.Close();
            }
            catch (Exception Ex) 
            {
                Console.WriteLine("Error" + Ex);
            }
            return FirstName;
        }

        public struct stContact
        {
            public int ID { get; set; }
            public  string FirstName { get; set; }
            public string LastName { get; set; }
            public string Email { get; set; }
            public string Phone { get; set; }
            public string Address { get; set; }
            public int CountryID { get; set; }
        };
        
        static bool IsFoundContact(int ID, ref stContact Contact)
        {
            bool IsFound = false;
            SqlConnection Connection = new SqlConnection(ConnectionString);

            string Query = "SELECT * FROM Contacts WHERE ContactID = @ID";

            SqlCommand Command = new SqlCommand(Query, Connection);
            Command.Parameters.AddWithValue("@ID", ID);
            try
            {
                Connection.Open();

                SqlDataReader Reader = Command.ExecuteReader();

                if (Reader.Read())
                {
                    IsFound = true;
                   Contact.ID = (int)Reader["ContactID"];
                   Contact.FirstName = (string)Reader["FirstName"];
                   Contact.LastName = (string)Reader["LastName"];
                   Contact.Email = (string)Reader["Email"];
                   Contact.Phone = (string)Reader["Phone"];
                   Contact.Address = (string)Reader["Address"];
                   Contact.CountryID = (int)Reader["CountryID"];


                }
                else
                {
                    IsFound = false;
                }

                Reader.Close();
                Connection.Close();
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error" + Ex);
            }
            return IsFound;
        }
        
        static void InsertNewContact(stContact Contact)
        {
            // create connection
            SqlConnection connection = new SqlConnection(ConnectionString);

            // query
            string Query = @"INSERT INTO Contacts (FirstName,LastName,Email,Phone,Address,CountryID )
                            VALUES (@FirstName,@LastName,@Email,@Phone,@Address,@CountryID );";

            // comand
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@FirstName",Contact.FirstName);
            Command.Parameters.AddWithValue("@LastName",Contact.LastName);
            Command.Parameters.AddWithValue("@Email",Contact.Email);
            Command.Parameters.AddWithValue("@Phone",Contact.Phone);
            Command.Parameters.AddWithValue("@Address",Contact.Address);
            Command.Parameters.AddWithValue("@CountryID",Contact.CountryID);

            try
            {
                // start connection
                connection.Open();

                int RowAffected = Command.ExecuteNonQuery();

                if(RowAffected > 0)
                {
                    Console.WriteLine("Insert Succefuly");
                }
                else
                {
                    Console.WriteLine("Felid to Insert");
                }

                // end connection
                connection.Close();


            }
            catch(Exception Ex)
            {
                Console.WriteLine("Error : " + Ex);
            }
        }


        static void UpdateContact(int ContactID,stContact Contact)
        {
            // create connection
            SqlConnection connection = new SqlConnection(ConnectionString);

            // query
            string Query = @"UPDATE  Contacts
                            SET FirstName=@FirstName,LastName=@LastName,Email=@Email,Phone=@Phone,Address=@Address,CountryID=@CountryID
                            Where ContactID = @ContactID;";

            // comand
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);
            Command.Parameters.AddWithValue("@FirstName", Contact.FirstName);
            Command.Parameters.AddWithValue("@LastName", Contact.LastName);
            Command.Parameters.AddWithValue("@Email", Contact.Email);
            Command.Parameters.AddWithValue("@Phone", Contact.Phone);
            Command.Parameters.AddWithValue("@Address", Contact.Address);
            Command.Parameters.AddWithValue("@CountryID", Contact.CountryID);

            try
            {
                // start connection
                connection.Open();

                int RowAffected = Command.ExecuteNonQuery();

                if (RowAffected > 0)
                {
                    Console.WriteLine("Update Succefuly");
                }
                else
                {
                    Console.WriteLine("Felid to Update");
                }

                // end connection
                connection.Close();


            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error : " + Ex);
            }
        }

        static void DeleteContact(int ContactID)
        {
            // create connection
            SqlConnection connection = new SqlConnection(ConnectionString);

            // query
            string Query = @"DELETE  Contacts
                            Where ContactID = @ContactID ";

            // comand
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ContactID", ContactID);

            try
            {
                // start connection
                connection.Open();

                int RowAffected = Command.ExecuteNonQuery();

                if (RowAffected > 0)
                {
                    Console.WriteLine("Deleted Succefuly");
                }
                else
                {
                    Console.WriteLine("Felid to Delete");
                }

                // end connection
                connection.Close();


            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error : " + Ex);
            }
        }
        static void Main(string[] args)
        {
            PrintAllContacts();
            Console.WriteLine("------------------------------");
            PrintAllContactsWithFirstNameAndCountry("Jane", 1);
            Console.WriteLine("------------------------------");
            SearchContactsFirstNameStartWith("J");
            Console.WriteLine("------------------------------");
            SearchContactsFirstNameContains("h");
            Console.WriteLine("------------------------------");
            SearchContactsFirstNameEndWith("e");
            Console.WriteLine("------------------------------");
            Console.WriteLine(FindFirstNameWhere(1)); // John
            Console.WriteLine("------------------------------");
            stContact Contast = new stContact();
            
            if(IsFoundContact(1,ref Contast))
            {
                Console.WriteLine("ID: " + Contast.ID);
                Console.WriteLine("FirstName: " + Contast.FirstName);
                Console.WriteLine("LastName: " + Contast.LastName);
                Console.WriteLine("Email: " + Contast.Email);
                Console.WriteLine("Phone: " + Contast.Phone);
                Console.WriteLine("Address: " + Contast.Address);
                Console.WriteLine("CountryID: " + Contast.CountryID);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            Console.WriteLine("------------------------------");

            if (IsFoundContact(100,ref Contast))
            {
                Console.WriteLine("ID: " + Contast.ID);
                Console.WriteLine("FirstName: " + Contast.FirstName);
                Console.WriteLine("LastName: " + Contast.LastName);
                Console.WriteLine("Email: " + Contast.Email);
                Console.WriteLine("Phone: " + Contast.Phone);
                Console.WriteLine("Address: " + Contast.Address);
                Console.WriteLine("CountryID: " + Contast.CountryID);
            }
            else
            {
                Console.WriteLine("Not Found");
            }

            //-------------------------
            //----[ INSERT INTO]-------
            //-------------------------
            stContact InsertedContact = new stContact
            {
                FirstName = "Abo_Eid",
                LastName = "Ali",
                Email = "Abo_Eid@gmail.com",
                Phone = "0110062352",
                Address = "12 Elm st",
                CountryID = 2
            };

            //InsertNewContact(InsertedContact);

            //-------------------------
            //-------[ Updaet ]--------
            //-------------------------
            stContact UpdatedContact = new stContact
            {
                FirstName = "Abo_Ali",
                LastName = "Eid",
                Email = "Abo_Ali@gmail.com",
                Phone = "0110062352",
                Address = "13 Elm st",
                CountryID = 5
            };
            //UpdateContact(1,UpdatedContact);
            //-------------------------
            //-------[ Delete ]--------
            //-------------------------
            DeleteContact(7);
            Console.ReadKey();
        }
    }
}
