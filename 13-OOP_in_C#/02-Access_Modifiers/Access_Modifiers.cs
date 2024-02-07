using System;

namespace Program
{
    internal class Program
    {
        class clsPerson
        {
            protected string _FirstName="";
            protected string _LastName="";
            protected int _Age=0;



            public int Age()
            {
                return _Age;
            }
        }
        class clsEmployee:clsPerson
        {
            public void SetAge(int Age)
            {
                 _Age = Age;
            }
            
            public int GetExperince()
            {
                int YearsBeforeWork=25;
                return _Age - YearsBeforeWork;
            }

        }


        static void Main(string []args)
        {
            clsEmployee Employee_1=new clsEmployee();
            Employee_1.SetAge(27); // 2
            Console.WriteLine(Employee_1.GetExperince());
            Console.ReadKey();
        }
    }
}