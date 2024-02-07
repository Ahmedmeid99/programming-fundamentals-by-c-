using System;
using System.Linq;


namespace learn_c__syntax
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(3, 7));
            Console.WriteLine(Math.Min(3, 7));
            Console.WriteLine(Math.Sqrt(46));
            Console.WriteLine(Math.Abs(-4));
            Console.WriteLine(Math.Round(3.7));


            Random Rand = new Random();
            Console.WriteLine(Rand.Next(1,10));
            Console.ReadKey();
        }
    }
}
