using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_partial_sealed
{
    // closed to create object from it
    public class Aperson
    {
        public  virtual void Print()
            {
                ///
            }
    }
    public sealed class clsPerson:Aperson
    {
        // properties
        // methods
        
        // closed to inherite from it
        public sealed override void Print()
        {
            Console.WriteLine("Hello from clsPerson");
        }
    }

    // not allowed to inherite from clsPerson because it is sealed
    //public class Employee : clsPerson
    //{

    //}

   /* ++++++++++++++++++++++++++++++++++++++++ */
   /* +++++++[ Partial class method ]+++++++++ */
   /* ++++++++++++++++++++++++++++++++++++++++ */

    public partial class clsCalculator
    {
        public int Subtract(int x, int y)
        {
            return x - y;
        }
    }
    public partial class clsCalculator
    {
        public int Sum(int x, int y)
        {
            return x + y;
        }
    } 

    internal class Program
    {
        static void Main(string[] args)
        {
            
            clsPerson p_1 = new clsPerson();
            p_1.Print();

            clsCalculator Calc = new clsCalculator();
            Console.WriteLine(Calc.Sum(2,3));      // 5
            Console.WriteLine(Calc.Subtract(7,3)); // 4
        }
    }
}
