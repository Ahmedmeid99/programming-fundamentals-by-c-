using System;


namespace learn_c__syntax
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            for(byte i=0;i<=10;i++)
            {
                Console.Write(i + " ");
            }
            Console.Write("\n");// 0 1 2 3 4 5 6 7 8 9 10
            //////////////////////////////////

            byte count = 0;
            while (count !=11)
            {
                Console.Write(count + " ");
                count++;
            }
            Console.Write("\n"); // 0 1 2 3 4 5 6 7 8 9 10
            //////////////////////////////////

            do
            {
                Console.Write(count + " ");
                count++;
            }while (count < 20);
            Console.Write("\n");// 11 12 13 14 15 16 17 18 19
            //////////////////////////////////

            for (byte i = 0; i <= 100; i++)
            {
                if(i%2==0)
                {
                    Console.Write(i + " ");
                }
                if(i==20)
                {
                    break;
                }
            }
            Console.Write("\n");// 0 2 4 6 8 10 12 14 16 18 20
            //////////////////////////////////


            Console.ReadKey();
        }
    }
}
