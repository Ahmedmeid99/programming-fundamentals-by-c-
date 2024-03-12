using System;
using System.Linq;
using System.Data;

namespace _04_DataTable_DataView_DataSet
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataTable dt = new DataTable();

            // create Columns
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(byte));
            dt.Columns.Add("Salary", typeof(double));
            dt.Columns.Add("DateOfBirth", typeof(DateTime));

            // create Rows
            dt.Rows.Add("Ahmed", 25, 12000, new DateTime(1999, 3, 6));
            dt.Rows.Add("Eid", 22, 11000, new DateTime(2002, 10, 1));
            dt.Rows.Add("Ali", 15, 7000, new DateTime(2005, 10, 3));
            dt.Rows.Add("Hassan", 18, 8000, new DateTime(2009, 6, 16));

            // read table
            foreach (DataRow Record in dt.Rows)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", Record["Name"], Record["Age"], Record["Salary"], Record["DateOfBirth"]); 
            }
        }
    }
}
