using System;


namespace learn_c__syntax
{
    internal class Program
    {
        static void PrintName(string Name)
        {
            Console.WriteLine(Name);
        }

        static string SumNums(int num1,int num2)
        {
            return ($"{num1} + {num2} = " + (num1+num2));

        }
        
        static void PrintformateDate(int year,byte month,byte day)
        {
            Console.WriteLine("{0}-{1}-{2}", year, month, day);
        }
        static void Main(string[] args)
        {
            PrintName("Ahemd Eid Ali");

            Console.WriteLine(SumNums(3,7));

            PrintformateDate(2024, 1, 19);
            PrintformateDate(month:1,year:2024, day:19);
            
            Console.ReadKey();
        }
    }
}
