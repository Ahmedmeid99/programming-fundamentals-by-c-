using System;
using FirstLibrary;

namespace Test_class_library
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // from FirstLibrary
            clsCalculator Calc = new clsCalculator();
            Calc.Add(10);
            Calc.PrintResult(); // 10
            Calc.Subtracct(5);
            Calc.PrintResult(); // 5
            Calc.Divide(0);
            Calc.PrintResult(); // 5
            Calc.Add(10);
            Calc.Multiply(2);
            Calc.PrintResult(); // 30


            Console.ReadKey();

        }
    }
}
