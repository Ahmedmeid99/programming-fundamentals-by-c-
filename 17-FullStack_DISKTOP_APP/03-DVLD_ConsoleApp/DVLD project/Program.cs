using System;

using System.Data;
using DVLDBusinessLayer;

namespace DVLD_project
{
    internal class Program
    {
        static void PrintPersonInfo(clsPersonBusiness Person)
        {
            Console.WriteLine("ID : " + Person.PersonID);
            Console.WriteLine("FirstName : " + Person.FirstName);
            Console.WriteLine("SecondName : " + Person.SecondName);
            Console.WriteLine("ThirdName : " + Person.ThirdName);
            Console.WriteLine("LastName : " + Person.LastName);
            Console.WriteLine("Email : " + Person.Email);
            Console.WriteLine("Phone : " + Person.Phone);
            Console.WriteLine("Address : " + Person.Address);
            Console.WriteLine("DateOfBirth : " + Person.DateOfBirth);
            Console.WriteLine("CountryID : " + Person.CountryID);
            Console.WriteLine("ImagePath : " + Person.ImagePath);
            Console.WriteLine("NationalID : " + Person.NationalID);
            Console.WriteLine("Gander : " + Person.Gander);
        }
        static void testFindPerson(int ID)
        {
            clsPersonBusiness Person = clsPersonBusiness.Find(ID);

            if (Person != null)
                PrintPersonInfo(Person);
            else
                Console.WriteLine("Person Not Found");
        } 
        static void testFindPerson(string NationalID)
        {
            clsPersonBusiness Person = clsPersonBusiness.Find(NationalID);

            if (Person != null)
                PrintPersonInfo(Person);
            else
                Console.WriteLine("Person Not Found");
        }
        
        static void testFindAll()
        {
            DataTable dt= clsPersonBusiness.GetAllPepole();

            foreach (DataRow Person in dt.Rows)
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} {7} {8} {9} {10} {11} {12}" 
                    ,Person[0], Person[1], Person[2], Person[3], Person[4], Person[5], Person[6], Person[7], Person[8], Person[9], Person[10], Person[11], Person[12]);
            }


        }

        static void testAddNewPerson()
        {
            clsPersonBusiness Person1 = new clsPersonBusiness();
            Person1.PersonID =  -1;
            Person1.FirstName =  "AHMED";
            Person1.SecondName =  "Eid";
            Person1.ThirdName =  "Mo";
            Person1.LastName =  "ali";
            Person1.Gander =  "M";
            Person1.Address =  "12 str egy";
            Person1.Email =  "ali@gmail.com";
            Person1.Phone =  "01232836263";
            Person1.NationalID =  "32127186";
            Person1.ImagePath = @"E:\\Test\\images\\avatar.png";
            Person1.DateOfBirth =  DateTime.Now;
            Person1.CountryID = 1;

            if(Person1.Save())
            {
                Console.WriteLine("Saved Successfuly");
            }
            else
            {
                Console.WriteLine("did not Save");
            }
            

        }

        static void testUpdatePerson()
        {
            clsPersonBusiness Person1 = clsPersonBusiness.Find(5);
            if(Person1 != null)
            {
                Person1.FirstName = "AHMED";
                Person1.SecondName = "Eid";
                Person1.ThirdName = "Mo";
                Person1.LastName = "ali";
                Person1.Address = "12 str egy";
                Person1.Email = "ali@gmail.com";
                Person1.Gander = "M";
                Person1.Phone = "01232836263";
                Person1.NationalID = "32127186";
                Person1.ImagePath = @"E:\\Test\\images\\avatar.png";
                Person1.DateOfBirth = DateTime.Now;
                Person1.CountryID = 1;
            }
            

            if (Person1.Save())
            {
                Console.WriteLine("Saved Successfuly");
            }
            else
            {
                Console.WriteLine("did not Save");
            }


        }

        static void testDeletePerson(int ID)
        {
            if(clsPersonBusiness.Delete(ID))
                Console.WriteLine("Deleted Successfuly"); 
            else
                Console.WriteLine("Did not Delete the Person"); 

        }    
        static void testPersonIsExist(int ID)
        {
            if(clsPersonBusiness.IsExists(ID))
                Console.WriteLine("IsExists"); 
            else
                Console.WriteLine("Is not Exists"); 

        }
        static void Main(string[] args)
        {
            //testAddNewPerson();
            //Console.WriteLine("------------------");

            //testUpdatePerson();
            //Console.WriteLine("------------------");   
            
            //testDeletePerson(3);
            //Console.WriteLine("------------------");


            //testFindPerson(4);           // get person 3
            //testFindPerson("23424523");  // get person 7
            //testFindPerson("234242");    // not found

            //Console.WriteLine("------------------");
            //testPersonIsExist(5);        //  Is Exist
            //testPersonIsExist(31);       //  Is not Exist

            Console.WriteLine("------------------");
            testFindAll();
            Console.WriteLine("------------------");


            Console.ReadKey();
        }
    }
}
