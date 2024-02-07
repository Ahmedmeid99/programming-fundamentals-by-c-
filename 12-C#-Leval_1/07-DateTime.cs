using System;
using System.Linq;


namespace learn_c__syntax
{
    internal class Program
    {

        static void Main(string[] args)
        {
            DateTime dt = new DateTime();
            Console.WriteLine(dt);// 1/1/0001 12:00:00 AM

            DateTime dt2 = new DateTime(2024,1,19);
            Console.WriteLine(dt2);// 1/19/2024 12:00:00 AM

            DateTime dt3 = new DateTime(2024, 1, 19 ,5 ,27 ,12);
            Console.WriteLine(dt3);// 1/19/2024 5:27:12 AM

            DateTime dt4 = new DateTime(2024, 1, 19, 5, 27, 12,DateTimeKind.Utc);
            Console.WriteLine(dt4);// 1/19/2024 5:27:12 AM

            // Current date
            Console.WriteLine(DateTime.Now.ToString());// 1/19/2024 5:42:24 PM
            Console.WriteLine(DateTime.Now.Day);// 19
            Console.WriteLine(DateTime.Now.Month);// 1
            Console.WriteLine(DateTime.Now.Year);// 2024
            Console.WriteLine(DateTime.Now.Hour);// 5
            Console.WriteLine(DateTime.Now.Minute);//42
            Console.WriteLine(DateTime.Now.Second);// 24 

            Console.WriteLine(DateTime.MaxValue.Ticks);// 24 
            Console.WriteLine(DateTime.MinValue.Ticks);// 24 

            // TimeSpan hours Minute Second -> Day Hour Minute Second
            TimeSpan ts = new TimeSpan(25,12,12);
            Console.WriteLine(ts.Days);// 1
            Console.WriteLine(ts.Hours);// 1 
            Console.WriteLine(ts.Minutes);// 12 
            Console.WriteLine(ts.Seconds);// 12 

            // DateTime operations
            Console.WriteLine(dt4+ts);  // 1/20/2024 6:39:24 AM
            Console.WriteLine(dt4.Add(ts));  // 1/20/2024 6:39:24 AM
            Console.WriteLine(dt4-ts);  // 1/18/2024 4:15:00 AM
            Console.WriteLine(dt4-dt2); // 05:27:12
            Console.WriteLine(dt4==dt2); // false

            // string DateTime 
            string str = "1/1/2024";
            DateTime dt7;
            if(DateTime.TryParse(str, out dt7)) // true
            {
                Console.WriteLine(dt7);// 1/1/0001 12:00:00 AM
            }
            else
            {
                Console.WriteLine($"{str} not valid time");
            }

            Console.ReadKey();
        }
    }
}
