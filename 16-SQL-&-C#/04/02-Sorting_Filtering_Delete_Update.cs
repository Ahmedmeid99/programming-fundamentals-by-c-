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

            // Count Sum AVG Max Min
            int Count = dt.Rows.Count;
            Console.WriteLine("Count: " + Count );
            double Sum = Convert.ToDouble(dt.Compute("SUM(Salary)",string.Empty)); 
            Console.WriteLine("Sum  : " + Sum);
            double Avg = Convert.ToDouble(dt.Compute("AVG(Salary)",string.Empty)); 
            Console.WriteLine( "Avg : " + Avg );
            double Max = Convert.ToDouble(dt.Compute("Max(Salary)",string.Empty)); 
            Console.WriteLine("Max  : " + Max);
            double Min = Convert.ToDouble(dt.Compute("Min(Salary)",string.Empty));
            Console.WriteLine("Min  : " + Min);

            // filter & Sum
            double Sum2 = Convert.ToDouble(dt.Compute("SUM(Salary)", "Salary > 10000")); 
            Console.WriteLine("Sum2 : " + Sum2 );

            Console.WriteLine("-------------------[Filtering]------------------------");

            // Filtering
            DataRow[] BigSalaries = dt.Select("Salary > 10000");
            DataRow[] resultRrows = dt.Select("Name = 'Ali' ");

            foreach (DataRow Record in BigSalaries)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", Record["Name"], Record["Age"], Record["Salary"], Record["DateOfBirth"]);

            Console.WriteLine("-------------------------------------------");

            foreach (DataRow Record in resultRrows)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", Record["Name"], Record["Age"], Record["Salary"], Record["DateOfBirth"]);

            
            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------[Sorting]-------------------------");

            // Sorting
            dt.DefaultView.Sort = "Salary desc"; // sort data view
            dt = dt.DefaultView.ToTable();       // set data view as table

            foreach (DataRow Record in dt.Rows)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", Record["Name"], Record["Age"], Record["Salary"], Record["DateOfBirth"]);


            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------[Delete Rows]-------------------------");
            
            // Delete Rows 
            DataRow[] aliRows = dt.Select("Name = 'Ali'");

            foreach (var Record in aliRows)
                Record.Delete();
            // AcceptChanges when internet turn on 
            dt.AcceptChanges();

            foreach (DataRow Record in dt.Rows)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", Record["Name"], Record["Age"], Record["Salary"], Record["DateOfBirth"]);


            ///////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------[Update Rows]-------------------------");
            
            // Update Rows 
            DataRow[] HassanRows = dt.Select("Name = 'Hassan'");

            foreach (DataRow RecordRow in HassanRows)
            {
                RecordRow["Name"] = "Hassan2";
                RecordRow["Age"] = 19;
            }
            dt.AcceptChanges();

            foreach (DataRow Record in HassanRows)
                Console.WriteLine("{0}\t{1}\t{2}\t{3}", Record["Name"], Record["Age"], Record["Salary"], Record["DateOfBirth"]);

            // Clear
            dt.Clear();




            Console.ReadKey();

        }
    }
}
