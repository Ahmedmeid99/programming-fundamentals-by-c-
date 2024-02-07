using System;


namespace learn_c__syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your name ? ");
            string name = Console.ReadLine();

            Console.WriteLine("What is your age ? ");
            byte age = Convert.ToByte (Console.ReadLine());

            Console.WriteLine("Hello "+ name +" Your age is " + age);

            Console.Write("Hello\nHello");
            Console.Write("\nHello\tHello");
            Console.Write("\nHello \bHello");
            Console.Write("\nHello\\Hello");
            Console.Write("\nHello\"Hello");
            Console.Write("\nHello\'Hello");
            Console.Write("\a");

            Console.ReadKey();
        }
    }
}
