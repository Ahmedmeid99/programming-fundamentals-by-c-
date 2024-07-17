using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // [1] Create
            List<int> nums = new List<int>();

            // [2] Create
            List<int> nums2 = new List<int> { 1,2,3,4,5};

            // Add
            nums.Add(1);
            nums.Add(2);
            nums.Add(3);
            nums.Add(4);
            nums.Add(5);

            // Loop [1]
            for (int i = 0; i < nums2.Count(); i++)
            {
                Console.WriteLine(nums2[i]);
            };
            
            // Delete
            nums.Remove(1);
            nums.RemoveAt(0);
            
            for (int i = 0; i < nums.Count(); i++)
            {
                Console.WriteLine(nums[i]);
            };

            // Clear
            nums.Clear();

            // Insert
            nums.Insert(0, 1);
            nums.Insert(1, 2);
            nums.Insert(2, 3);

            // Loop [2]
            foreach (var num in nums2)
            {
                Console.WriteLine(num);
            };

            // Loop [3]
            nums2.ForEach((num) => Console.WriteLine(num)) ;

            List<int> nums3 = new List<int> { 20, 9, -1, 7, 3, 6, 12 };
           
            // Linq
            Console.WriteLine(nums3.Min());
            Console.WriteLine(nums3.Max());
            Console.WriteLine(nums3.Sum());
            Console.WriteLine(nums3.Count());
            Console.WriteLine(nums3.Average());

            // Filtering Where statment
            Console.WriteLine(string.Join(",",nums3.Where((num)=> num >=2 )));
            Console.WriteLine(string.Join(",",nums3.Where((num)=> num <=2 )));
           
            // Sorting
            nums3.Sort();
            Console.WriteLine(string.Join(",",nums3 ));

            nums3.Reverse();
            Console.WriteLine(string.Join(",",nums3 ));
            
            // Linq namespace
            Console.WriteLine(string.Join(",", nums3.OrderBy((num) => num)));
            Console.WriteLine(string.Join(",", nums3.OrderByDescending((num) => num)));

            // Contains - Exists - Find - FindAll - Any
            Console.WriteLine("Has number = 3 ? : " + nums3.Contains(3));
            Console.WriteLine("Has number bigger than 10? : " + nums3.Exists((num) => num > 10));
            Console.WriteLine("First numbers > 10\n" + nums3.Find((num) => num > 10));
            Console.WriteLine("All numbers > 10\n"+string.Join(",", nums3.FindAll((num) => num > 10)));
            Console.WriteLine("Has number bigger than 10? : " + nums3.Any((num) => num > 10));

            // List -> Array
            int[] nums3Array = nums3.ToArray();

            // Array -> List
            List<int> Numbers3 =new List<int>(nums3Array);

            for (int i = 0; i < nums3Array.Length; i++)
            {
                Console.WriteLine(nums3Array[i]);
            };

            Numbers3.ForEach((num) => Console.WriteLine(num));


            // --------------------------
            // [Using List with objects]
            // --------------------------

            List<Employee> Employees = EmployeesHelper.LoadEmployees();
            var Employees2 = EmployeesHelper.LoadEmployees2();

            Console.WriteLine("Has Employee.Salary > 20000 : " + Employees.Exists((Employee) => Employee.Salary > 20000));
            Console.WriteLine("Has Employee.Salary > 20000 : " + Employees.FirstOrDefault((Employee) => Employee.Salary > 20000));
            Console.WriteLine("Employee that Salary > 20000 \n" + Employees.Find((Employee) => Employee.Salary > 20000));
            Console.WriteLine("All Active Employees \n" + string.Join(", ", Employees.FindAll((Employee) => Employee.IsActive == true)));
            Console.WriteLine("Has UnActive Employee " + Employees2.Any((Employee) => Employee.IsActive == false));


            Console.ReadKey();



        }
    }
}
