using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Delegate
{
    internal class PredicateDelegate
    {
        public static bool IsEven (int  x)
        {
            return (x % 2 == 0);
        }
        static void Main(string[] args)
        {
            Predicate<int> IsEvenPredicate = IsEven;

            Console.WriteLine(IsEvenPredicate(3));
            Console.WriteLine(IsEvenPredicate(4));

            Console.ReadKey();
        }
    }
}
