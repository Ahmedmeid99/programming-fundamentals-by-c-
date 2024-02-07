using System;
using System.Linq;


namespace learn_c__syntax
{
    internal class Program
    {

        static void Main(string[] args)
        {
            byte[] arr = { 1, 2, 3, 4, 5 };
            Console.WriteLine(arr[1]);

            int[] arr2 = new int[5];
            arr2[0] = 1;
            arr2[1] = 2;
            arr2[2] = 3;
            arr2[3] = 4;
            arr2[4] = 5;
            Console.WriteLine(arr2[1]);

            //from System.Linq
            Console.WriteLine(arr2.Max());
            Console.WriteLine(arr2.Min());
            Console.WriteLine(arr2.Count());
            Console.WriteLine(arr2.Sum());
            Console.WriteLine(arr2.Average());

            foreach (byte item in arr2)
            {
                Console.WriteLine(item);
            }


            // two dimintional array
            byte[,] DiArray = new byte[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            for (byte i = 0; i < 2; i++)
            {
                for (byte j = 0; j < 3; j++)
                {
                    Console.WriteLine(i + "->" + j);
                }
            }
            
            
            Console.ReadKey();
        }
    }
}
