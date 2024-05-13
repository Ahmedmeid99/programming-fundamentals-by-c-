using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
    
    internal class ActionDelegate
    {
        static void Method1()
        {
            Console.WriteLine("Hello");
        }
        static void Method2(int x)
        {
            Console.WriteLine("x : " + x);
        }
        static void Method3(int x, int y)
        {
            Console.WriteLine("x : " + x + ", y : " + y) ;
        }     
        static void Method4(int x, int y)
        {
            Console.WriteLine("x2 : " + x + ", y2 : " + y) ;
        }
        //static void Main(string[] args)
        //{
        //    Action ParameterLessAction = Method1;
        //    Action<int> ActionWithIntParameter = Method2;
        //    Action<int,int> ActionWith2IntParameter = Method3;
        //
        //    ActionWith2IntParameter += Method4;
        //
        //    ParameterLessAction();
        //    ActionWithIntParameter(3);
        //    ActionWith2IntParameter(3, 2);
        //
        //    Console.ReadKey();
        //}

    }
}
