using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace _01_List
{
    public class Employee
    {
        public string Name { get; set; } 
        public byte Age { get; set; } 
        public DateTime DateOfBirth { get; set; } 
        public decimal Salary { get; set; } 
        public bool IsActive { get; set; }

        public Employee(string Name, byte Age,DateTime DateOfBirth,decimal Salary,bool IsActive)
        {
            this.Name = Name;
            this.Age = Age;
            this.DateOfBirth = DateOfBirth;
            this.Salary = Salary ;
            this.IsActive = IsActive ;
        }
        public override string ToString()
        {
            return $"{Name} {Age} {DateOfBirth} {Salary} {IsActive}";
        }
    }
    public static class EmployeesHelper
    {
        public static List<Employee> LoadEmployees()
        {
            return new List<Employee>
            {
                new Employee("Ahmed", 24, new DateTime(2000, 3, 6), 20000, true),
                new Employee("Ali", 26, new DateTime(1999, 5, 13), 20400, false), 
                new Employee("Hassan", 24, new DateTime(2000, 3, 6), 20000, true),
                new Employee("Mohamed", 26, new DateTime(1999, 5, 13), 20400, false),
                new Employee("Eid", 20, new DateTime(2004, 7, 3), 10500, true)
            };

        }  
        public static IEnumerable<Employee> LoadEmployees2()
        {
            return new List<Employee>
            {
                new Employee("Ahmed", 24, new DateTime(2000, 3, 6), 20000, true),
                new Employee("Ali", 26, new DateTime(1999, 5, 13), 20400, false), 
                new Employee("Hassan", 24, new DateTime(2000, 3, 6), 20000, true),
                new Employee("Mohamed", 26, new DateTime(1999, 5, 13), 20400, false),
                new Employee("Eid", 20, new DateTime(2004, 7, 3), 10500, true)
            };

        }
    }
}
