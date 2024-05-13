using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
    internal class MulticastDelegate
    {
        //Delegate
        public delegate void MyDelegate(string Message);

        static void Method1(string Message)
        {
            Console.WriteLine("Method 1 : " + Message);
        }

        static void Method2(string Message)
        {
            Console.WriteLine("Method 2 : " + Message);
        }  
        
        //static void Main(string[] args)
        //{
        //    MyDelegate  myDelegate = Method1;
        //    myDelegate += Method2;
        //    myDelegate("Delegate Working");
        //    myDelegate -= Method1;
        //    myDelegate("Delegate Working 2");
        //
        //    Console.ReadKey();
        //
        //
        //}
    }
}
