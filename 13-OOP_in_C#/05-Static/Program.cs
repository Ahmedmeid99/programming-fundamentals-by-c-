using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Static
{
    internal class Program
    {
        //static class to make it not allowed to create object
        static class Settings
        {
            // no constractor because we will not creat object from this class
           public static string DayName
            {
                get
                {
                    return DateTime.Today.DayOfWeek.ToString();
                }
            }

            public static string ProjectPath { get; set; }

            //[2] private constactor to make it not allowed to create object but not allowed in static class
            //private Settings()
            //{
            //    ProjectPath = @"c:\myProjects\";
            //}
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Settings.DayName);
            Console.WriteLine(Settings.ProjectPath);
            Console.ReadKey();
        }
    }
}
