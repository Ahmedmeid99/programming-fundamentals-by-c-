using System;


namespace Get_Set
{
    internal class Program
    {
        public class clsPerson
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Emali { get; set; }
            public string Phone { get; set; }
            public short Age { get; set; }

            // read onle
            public int Id
            {
                get
                {
                    Random random = new Random();
                    return (int)(random.NextDouble()*(double)1000000000);
                }
            }
        }
            static void Main(string[] args)
            {
                clsPerson Person_1 = new clsPerson();
                Person_1.FirstName = "Ahmed";
                Person_1.LastName = "Eid";
                Person_1.Emali = "Ahmed@gmail";
                Person_1.Phone = "0100203040";
                Person_1.Age = 26;

                Console.WriteLine(
                    $"Id: {Person_1.Id} \n"+
                    $"FirstName: {Person_1.FirstName} \n " +
                    $"LastName: {Person_1.LastName}\n " +
                    $"Emali: {Person_1.Emali}\n" +
                    $"Phone: {Person_1.Phone}\n" +
                    $"Age: {Person_1.Age}");


                Console.ReadKey();
            }
        }
    }

