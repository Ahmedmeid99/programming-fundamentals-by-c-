using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Special_Comment_Generics
{
    // [1] Generic with class
    public class GenericBox <T>
    {
        private T _Content;
        public GenericBox(T value)
        {
            _Content = value;
        }
        public T GetContent ()
        {
            return _Content;
        }
    }
    internal class Program
    {
        // [2] Generic with Method

        /// <summary>
        ///  This Function swap First Element with Second Element in Memory
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="First">The First Element</param>
        /// <param name="Second">The Second Element</param>
        /// <returns> The Second Element</returns>
        public static T Swap <T>(ref T First, ref T Second)
        {
            T Temp = First;
            First = Second;
            Second = Temp;

            return Temp;
        }

        static void Main(string[] args)
        {
            string a = "A", b = "B";

            Swap(ref a, ref b);
            Console.WriteLine("A :" + a + "B : " + b);

            // --------------------------------
            GenericBox<int> intContent = new GenericBox<int>(5);
            Console.WriteLine(intContent.GetContent());

            GenericBox<string> strContent = new GenericBox<string>("Five");
            Console.WriteLine(strContent.GetContent());

            Console.ReadKey();

        }
    }
}
