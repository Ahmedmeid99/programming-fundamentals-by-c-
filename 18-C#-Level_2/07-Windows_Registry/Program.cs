using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace _07_Windows_Registry
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string KeyPath = @"HKEY_CURRENT_USER\SOFTWARE\koko_Application";
            string ValueName = "UserName";
            string ValueDate = "Abu_Eid";

            // Writing to Registry
            try
            {
                Registry.SetValue(KeyPath, ValueName, ValueDate,RegistryValueKind.String);
            } 
            catch (Exception Ex)
            {
                Console.WriteLine("Error : " + Ex);
            }

            // Reading from Registry
            try
            {
                string ValueOfUserName = Registry.GetValue(KeyPath, ValueName, null) as string;

                if (ValueOfUserName != null)
                    Console.WriteLine("UserName : " + ValueOfUserName);
                else
                    Console.WriteLine($"Can not find {ValueName}");
            }
            catch (Exception Ex)
            {
                Console.WriteLine("Error : " + Ex);
            }

            Console.WriteLine($" 111111 : {HashingPassword("111111")} and 123456 : {HashingPassword("123456")} ");


            Console.ReadKey();
        }
        public static string HashingPassword(string Password)
        {
            using (SHA256 sHA256 = SHA256.Create())
            {

                byte[] hashBytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }
    }
}
