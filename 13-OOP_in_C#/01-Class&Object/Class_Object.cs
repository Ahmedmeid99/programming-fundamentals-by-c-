using System;


namespace Program // namespace to use this class as library
{
    internal class Program // class 
    {
        class clsPerson
        {
            private byte _Age = 25;
            private string _FirstName = "Ahmed" ;
            private string _LastName ="Eid" ;

            ///////////
            public byte Age()
            {
                return _Age;
            }

            public string FirstName()
            {
                return _FirstName;
            }

            public string LastName()
            {
                return _LastName;
            }
        }

        static void Main(string[] args) // main function
        {
            clsPerson Person_1 =new clsPerson();






            Console.WriteLine(Person_1.Age());
            Console.WriteLine(Person_1.FirstName());
            Console.WriteLine(Person_1.LastName());
            
            Console.ReadKey();
        }
    }
}