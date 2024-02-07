using System;


namespace learn_c__syntax
{
    internal class Program
    {
        static string CheckResult(byte result)
        {

            if (result < 50)
            {
                return "F";
            }
            else if (result <= 75)
            {
                return "B";
            }
            else if (result <= 100)
            {
                return "A";
            }
            else
            {
                return "ERRor";
            }
        }
        
        
        static void Main(string[] args)
        {
            bool IsHierd = true;
            if(IsHierd)
            {
                Console.WriteLine("accepted :-)");
            }
            else
            {
                Console.WriteLine("accepted :-)");
            }

            // short hand if
            string stIsHierd = (IsHierd) ? "Is Hierd" : "Isn`t Hierd";

            Console.WriteLine(stIsHierd);  // Is Hierd

            Console.WriteLine(CheckResult(40));  // F
            Console.WriteLine(CheckResult(50));  // B
            Console.WriteLine(CheckResult(60));  // B
            Console.WriteLine(CheckResult(80));  // A
            Console.WriteLine(CheckResult(100)); // A
            Console.WriteLine(CheckResult(110)); // ERRor



            char c = 'a';
            switch (c)
            {
                case 'a':
                    Console.WriteLine("char is a");
                    break;
                case 'b':
                    Console.WriteLine("char is b");
                    break;
                case 'c':
                    Console.WriteLine("char is c");
                    break;
                default:
                    Console.WriteLine("char is ?");
                    break;

            };
            
            

            Console.ReadKey();
        }
    }
}
