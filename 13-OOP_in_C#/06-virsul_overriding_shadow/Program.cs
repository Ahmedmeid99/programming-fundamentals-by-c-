using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace virsul_overriding_shadow
{
    internal class Program
    {
       public class clsPerson
        {
            public virtual void Print()
            {
                Console.WriteLine("This function work from Person class");
            }
        }
        public class clsEmployee :clsPerson
        {
            public override void Print()
            {
                Console.WriteLine("This function work from Employee class");
            }

            // shadow using new keyword
            //public new void Print()
            //{
            //    Console.WriteLine("This function work from Employee class");
            //}

        }

        static void Main(string[] args)
        {
            clsPerson P1 = new clsPerson();
            P1.Print();
            clsEmployee E1 = new clsEmployee();
            E1.Print();

            /* [we can see the defirunt between shadow and overriding when use down casting] */

            Console.ReadKey();
        }
    }
}
