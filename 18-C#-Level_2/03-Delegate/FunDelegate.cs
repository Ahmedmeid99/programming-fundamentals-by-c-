using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
    internal class FunDelegate
    {    // normal delegate
        // public delegate int SquareDelegate(int x);

        // short cu
        static Func<int, int> SquareDelegate = Square;
        public static int Square(int x)
        {
            return x * x;
        }
        //static void Main(string[] args)
        //{
        //    //SquareDelegate squareDelegate = Square;
        //
        //    Console.WriteLine(SquareDelegate(3));
        //
        //    Console.ReadKey();
        //}
    }
}
