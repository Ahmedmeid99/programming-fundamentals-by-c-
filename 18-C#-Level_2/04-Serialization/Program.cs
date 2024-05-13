using System;
using System.IO;

using System.Xml.Serialization;   // XML
using System.Runtime.Serialization.Json;   // JSON
using System.Runtime.Serialization.Formatters.Binary;  // Binary

namespace _04_Serialization
{
    // Serialization Types
    // - XML
    // - JSON
    // - Binary

    [Serializable] // Attrubite to 
    public class Person
    {
        public string Name { get; set; }
        public byte Age { get; set;}
        
        public Person()
        {
            this.Name = "UnKnow";
            this.Age = 0;
        } 
        public Person(string Name,byte Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Create New Object of Person
            Person FirstPerson = new Person("Ahmed",25);

            //////////////////////////////////////////////////////
            // XML Serialization
            XmlSerializer serializer = new XmlSerializer(typeof(Person)) ;
            using (TextWriter writer = new StreamWriter("Person.xml"))
            {
                serializer.Serialize(writer,FirstPerson);

            }

            // XML Deserialization
            using (TextReader reader = new StreamReader("Person.xml"))
            {
                Person deserializedPerson = (Person) serializer.Deserialize(reader);
                Console.WriteLine($"[XML] Name : {deserializedPerson.Name},Age {deserializedPerson.Age}");
            }

            //////////////////////////////////////////////////////
            // JSON Serialization
            DataContractJsonSerializer serializer2 = new DataContractJsonSerializer(typeof(Person));
            using(MemoryStream stream = new MemoryStream())
            {
                serializer2.WriteObject(stream, FirstPerson);

                string JsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());
                File.WriteAllText("person.json", JsonString);
            }

            // JSON Deserialization
            using (FileStream stream = new FileStream("person.json", FileMode.Open))
            {
                Person deserializedPerson = (Person)serializer2.ReadObject(stream);
                Console.WriteLine($"[JSON] Name : {deserializedPerson.Name},Age {deserializedPerson.Age}");
            }

            //////////////////////////////////////////////////////
            // Pinary Serialization
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream stream = new FileStream("person.bin", FileMode.Create))
            {
                formatter.Serialize(stream, FirstPerson);
            }

            // Pinary Deserialization
            using (FileStream stream = new FileStream("person.bin", FileMode.Open))
            {
                Person deserializedPerson = (Person)formatter.Deserialize(stream);
                Console.WriteLine($"[Pinary] Name : {deserializedPerson.Name},Age {deserializedPerson.Age}");
            }


            Console.ReadKey();
        }
    }
}












