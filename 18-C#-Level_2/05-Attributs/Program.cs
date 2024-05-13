using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _05_Attributs
{
    internal class Program
    {
        // Attributs to add MetaData (addtional information)

        // - [Serializable]     we use it before in Serialization 
        // - [Obsolete("")]     to tell developer message if use the element in his code
        // - [Conditional("")]  choose the Methods that will run in selected Mode (DEBUG,RELEASE)
        //                                                  or Custom Mode using => #defind Mode_Name

        [Obsolete("This Method not flexable, please use LastVersionSwapMethod insted")]
        public static int OldSwapMethod(ref int First,ref int Second)
        {
            int Temp = First;
            First = Second;
            Second = Temp;
            return Temp;
        }  
        public static T LastVersionSwapMethod <T>(ref T First ,ref T Second)
        {
            T Temp = First;
            First = Second;
            Second = Temp;
            return Temp;
        }

        //----------------------------------------------------
        [Conditional("DEBUG")]
        public static void CheckAccess()
        {
            Console.WriteLine("DEBUG MODE");
        }

        [Conditional("RELEASE")]
        public static void CheckAccess2 ()
        {
            Console.WriteLine("RELEASE MODE");
        }

        //----------------------------------------------------

        static void Main(string[] args)
        {
            int x = 10, y = 20;
            string a = "A", b = "B";

            OldSwapMethod(ref x, ref y);
            Console.WriteLine("x : " + x + "y : " + y);

            LastVersionSwapMethod(ref x,ref y);
            Console.WriteLine("x : " + x + "y : " + y);

            LastVersionSwapMethod(ref a,ref b);
            Console.WriteLine("a : " + a + "b : " + b);

            // -----------------------
            CheckAccess();
            CheckAccess2();

            Console.ReadKey();
        }
    }
}
