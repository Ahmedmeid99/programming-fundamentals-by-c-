using System;


namespace _04_Constractors
{
    internal class Program
    {
        public class clsPerson
        {
            public clsPerson()
            {
                Random random = new Random();
                int rnd = (int)(random.NextDouble() * (double)1000000000);
                this.Id = rnd;
                this.FirstName = string.Empty;
                this.LastName = string.Empty;
                this.Emali = string.Empty;
                this.Phone = string.Empty;
                this.Age = 0;
            }
            public clsPerson(string FirstName, string LastName,string Email,string Phone,short Age)
            {
                Random random = new Random();
                int rnd = (int)(random.NextDouble() * (double)1000000000);
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Emali =Email;
                this.Phone = Phone;
                this.Age = Age;
            }
            public clsPerson(int Id,string FirstName, string LastName, string Email, string Phone, short Age)
            {
                Random random = new Random();
                Id = (int)(random.NextDouble() * (double)1000000000);
                this.Id = Id;
                this.FirstName = FirstName;
                this.LastName = LastName;
                this.Emali = Email;
                this.Phone = Phone;
                this.Age = Age;
            }
            // Deconstracor
            ~clsPerson() 
            {
                // close database
                // close file
                // clean memory
                Console.WriteLine("Deconstracor Work Now");
            }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Emali { get; set; }
            public string Phone { get; set; }
            public short Age { get; set; }

            // read onle
            public int Id { get; }
            


        }

        public class clsEmployee : clsPerson
        {
            public clsEmployee(int Id,string FirstName, string LastName, string Email, string Phone, short Age, string Field, double Salary) : base(Id,FirstName, LastName, Email, Phone, Age)
            {
                // this.Id = base.Id;
                this.Field = Field;
                this.Salary = Salary;
            }
            public string Field { get; set; }
            public double Salary { get; set; }
            
            public void Print()
            {
                Console.WriteLine(
                $"Id: {this.Id} \n" +
                $"FirstName: {this.FirstName} \n" +
                $"LastName: {this.LastName}\n" +
                $"Emali: {this.Emali}\n" +
                $"Phone: {this.Phone}\n" +
                $"Age: {this.Age}\n" +
                $"Field: {this.Field}\n" +
                $"Salary: {this.Salary}");
            }
        }
        
        
        static void Main(string[] args)
        {
            clsPerson Person_1 = new clsPerson();
            Person_1.FirstName = "Ahmed";
            Person_1.LastName = "Eid";
            Person_1.Emali = "Ahmed@gmail";
            Person_1.Phone = "0100203040";
            Person_1.Age = 26;

            Console.WriteLine(
                $"Id: {Person_1.Id} \n" +
                $"FirstName: {Person_1.FirstName} \n" +
                $"LastName: {Person_1.LastName}\n" +
                $"Emali: {Person_1.Emali}\n" +
                $"Phone: {Person_1.Phone}\n" +
                $"Age: {Person_1.Age}");


            clsEmployee Employee_1 = new clsEmployee(0,"Ahmed","EAD","Eid@gmail","010033445",27,"DOTNET DEVELOPER",15000);
            Employee_1.Print();

            // up Casting
            clsEmployee Employee_2 = new clsEmployee(0, "Ali", "EAD", "ali@gmail", "0104245445", 25, "DOTNET DEVELOPER", 15000);
            clsPerson Person2 = Employee_2; // to use min size of clsPerson
            Console.WriteLine(Person2.FirstName);


            // down Casting
            clsPerson Person_3 = new clsEmployee(0, "Hassan", "EAD", "ali@gmail", "0104245445", 25, "DOTNET DEVELOPER", 15000);
            clsEmployee Employee_3 = (clsEmployee)Person_3; // to Max size of clsEmployee
            Console.WriteLine(Employee_3.FirstName);

            Console.ReadKey();
        }
    }
}
