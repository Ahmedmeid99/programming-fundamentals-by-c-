using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DataTable_DataView_DataSet
{
    internal class Program
    {
        static void Main(string[] args)

        {
            DataTable dt = new DataTable();

            // create Columns

            // Create Primary key
            DataColumn dtPrimaryColumn = new DataColumn();

            dtPrimaryColumn.DataType = typeof(int);
            dtPrimaryColumn.ColumnName = "ID";
            dtPrimaryColumn.Caption = "Employee ID";
            dtPrimaryColumn.AutoIncrement = true;
            dtPrimaryColumn.AutoIncrementSeed = 1;
            dtPrimaryColumn.AutoIncrementStep = 1;
            dtPrimaryColumn.Unique = true;
            dtPrimaryColumn.ReadOnly = true;
            
            dt.Columns.Add(dtPrimaryColumn);
            dt.Columns.Add("Name", typeof(string));
            dt.Columns.Add("Age", typeof(byte));
            dt.Columns.Add("Salary", typeof(double));
            dt.Columns.Add("DateOfBirth", typeof(DateTime));

            dt.Rows.Add(null,"Ahmed",22,2000,new DateTime(1999,3,6));
            dt.Rows.Add(null,"ali",12,4000,new DateTime(2002,4,1));
            dt.Rows.Add(null,"eid",23,5000,new DateTime(2003,10,4));
            dt.Rows.Add(null,"mohamed",25,25000,new DateTime(2012,8,2));
            dt.Rows.Add(null,"hassan",20,6000,new DateTime(2019,5,13));


            foreach (DataRow Record in dt.Rows)
            {
                Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", Record["ID"], Record["Name"], Record["Age"], Record["Salary"], Record["DateOfBirth"]); 
            }


            ////////////////////////////////////
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("ID", typeof(int));
            dt2.Columns.Add("Name", typeof(string));

            // Make ID as Primary key
            DataColumn[] dtPrimaryKeys = new DataColumn[1];
            dtPrimaryKeys[0] = dt2.Columns["ID"];
            dt2.PrimaryKey = dtPrimaryKeys;

            dt2.Rows.Add(1, "mohamed");
            dt2.Rows.Add(2, "hassan");  


            foreach (DataRow Record in dt2.Rows)
            {
                Console.WriteLine("{0}\t{1}", Record["ID"], Record["Name"]);
            }
            Console.ReadKey();
        }
    }
}
