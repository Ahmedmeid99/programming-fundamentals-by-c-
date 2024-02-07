using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Interface
{
    internal class Program
    {
        // Interface
        public interface IPerson
        {
            void SayHello();
            void Print();
            void To_String();
        }

        public interface Icommuication 
        {
            void CallPhone();
            void SendEmail(string Title,string body);
            void SendSMS(string Title,string body);
            void SendFax(string Title,string body);
            
        }
        //abstract class
        public abstract class  clsPerson: IPerson, Icommuication
        {
             public string FirstName {get; set;}
             public string LastName {get; set;}
             public string Email {get; set;}
             public string Phone {get; set;}

            public void SayHello()
            {
                Console.WriteLine("Hello from Person Interface");
            }

            public void Print()
            {
                Console.WriteLine($"MyName: {this.FirstName + this.LastName}\n" +
                    $"MyPhone: {this.Phone}\n" +
                    $"MyEmail: {this.Email}");
            }
            public void To_String()
            {
                Console.WriteLine($"MyName: {this.FirstName + this.LastName}");
            }
            public abstract void Introduce();// abstruct member method

            public void CallPhone()
            {
                Console.WriteLine("Calling Phone");
            }
           public void SendEmail(string Title, string body)
            {
                Console.WriteLine("Send Email");
            }
           public void SendSMS(string Title, string body)
            {
                Console.WriteLine("Send SMS");
            }
            public void SendFax(string Title, string body)
            {
                Console.WriteLine("Send Fax");
            }

        }

        public class clsEmployee:clsPerson
        { 
            public string EmployeeId { get; set; }
            

            public override void Introduce()
            {
                Console.WriteLine(
                    $"MyName: {this.FirstName + this.LastName}\n" +
                    $"MyPhone: {this.Phone}\n" +
                    $"MyEmail: {this.Email}");
            }

        }
        static void Main(string[] args)
        {
            clsEmployee Embloyee_1= new clsEmployee();
            Embloyee_1.FirstName = "Ahmed";
            Embloyee_1.LastName = "Eid";
            Embloyee_1.Phone = "0103921821";
            Embloyee_1.Email = "ahmed@gmail.com";

            // from IPerson Interface
            Embloyee_1.SayHello();
            Embloyee_1.Introduce();
            Embloyee_1.To_String();

            // from Icommuication Interface
            Embloyee_1.CallPhone();
            Embloyee_1.SendEmail("title","the body");
            Embloyee_1.SendSMS("title","the body");
            Embloyee_1.SendFax("title","the body");

            Console.ReadKey();
        }
    }
}
