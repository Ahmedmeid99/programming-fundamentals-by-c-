using System;


namespace learn_c__syntax
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte b= 255;
            sbyte sb= -128;
            short s = 32000;
            ushort us = 65000;
            int i = 2000000000;
            uint ui = 4000000000;
            long l = 4000000000000000000;
            ulong ul = 4000000000000000000;
            float fl = 20;
            double d = 20.253;
            char c = 'A';
            bool bo = true;
            string st = "Ahmed" ;
            
            // boject
            // DateTime
            // ...

            Console.WriteLine("byte: " + b + "sbyte: " + sb + "short: " + s + "ushort: " + us);
            Console.WriteLine("int: "  + i + "uint: " + ui + "long: " + l + "ulong: " + ul);
            Console.WriteLine("float: " + fl + "double: " + d + "char: " + c + "bool: " + bo + "string: " + st);
            Console.ReadKey();
        }
    }
}
