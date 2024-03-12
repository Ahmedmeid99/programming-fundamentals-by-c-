
using System;
using System.Data;
using ContactBusinessLayer;
using ContactsBusinessLayer;

namespace ContactsConsolApp
{
    internal class Program
    {
        static void testFindContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                Console.WriteLine(Contact1.FirstName+ " " + Contact1.LastName);
                Console.WriteLine(Contact1.Email);
                Console.WriteLine(Contact1.Phone);
                Console.WriteLine(Contact1.Address);
                Console.WriteLine(Contact1.DateOfBirth);
                Console.WriteLine(Contact1.CountryID);
                Console.WriteLine(Contact1.ImagePath);
            }
            else 
            {
                Console.WriteLine("Contact [" + ID + "] Not found!");   
            }
        }



        static void testAddNewContact()

        {
            clsContact Contact1 = new clsContact();
            Contact1.FirstName = "Fadi";
            Contact1.LastName = "Maher";
            Contact1.Email = "A@a.com";
            Contact1.Phone = "010010";
            Contact1.Address = "address1";
            Contact1.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
            Contact1.CountryID = 1;
            Contact1.ImagePath = "";
          
           if (Contact1.Save())
            {

                Console.WriteLine("Contact Added Successfully with id=" + Contact1.ID);
            }

        }

        static void testUpdateContact(int ID)

        {
            clsContact Contact1 = clsContact.Find(ID);

            if (Contact1 != null)
            {
                //update whatever info you want
                Contact1.FirstName = "Fadi2";
                Contact1.LastName = "Maher2";
                Contact1.Email = "A2@a.com";
                Contact1.Phone = "2222";
                Contact1.Address = "222";
                Contact1.DateOfBirth = new DateTime(1977, 11, 6, 10, 30, 0);
                Contact1.CountryID = 1;
                Contact1.ImagePath = "";

                if (Contact1.Save())
                {

                    Console.WriteLine("Contact updated Successfully ");
                }

            }
            else
            {
                Console.WriteLine("Not found!");
            }
        }

        static void ListContacts()
        {

            DataTable dataTable = clsContact.GetAllContacts();
           
            Console.WriteLine("Contacts Data:");

            foreach (DataRow row in dataTable.Rows)
            {
                Console.WriteLine($"{row["ContactID"]},  {row["FirstName"]} {row["LastName"]}");
            }

        }

        static void DeleteContact(int ID)
        {
            // if Exists
            //      tryDelete
            if(clsContact.IsContactExists(ID))
            {
                if(clsContact.DeleteContact(ID))
                    Console.WriteLine("Deleted Successfuly");
                else
                    Console.WriteLine("Faild to Delete");
            }
            else
                Console.WriteLine("Contact with ID ( "+ ID + " )Was not found !");
        }

        static void testFindCountryByName(string CounteryName)
        {
            clsCountry country1 = clsCountry.FindByName(CounteryName);

            if(country1 != null)
            {
                Console.WriteLine(country1.CountryID);
                Console.WriteLine(country1.CountryName);
                Console.WriteLine(country1.Code);
                Console.WriteLine(country1.PhoneCode);
            }
            else
            {
                Console.WriteLine(CounteryName + " Did not found in database");

            }
        }

        static void testCountyIsExists(string Name)
        {
            if(clsCountry.IsCountyExists(Name))
            {
                Console.WriteLine(Name + " is Exists");
            }
            else
            {
                Console.WriteLine(Name + " is not Exists");
            }
        }
        static void Main(string[] args)
        {
            
            // testFindContact(7);
            // testAddNewContact();
            testUpdateContact(1);
            // ListContacts();
            // DeleteContact(8);
            // DeleteContact(10);
            // 
            // testFindCountryByName("Canada");
            // testCountyIsExists("Canada");
            // testCountyIsExists("Canad");
            Console.ReadKey();

        }
    }
}
