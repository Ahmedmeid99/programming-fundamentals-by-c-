using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.Security;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DVLDBusinessLayer.Global
{
    public static class GlobalFunctions
    {
        [Obsolete("Dont use this function didnt completed yet !!!")]
        public static string Encrypt(string PlainText, string Key)
        {
            byte[] PlainBytes = Encoding.UTF8.GetBytes(PlainText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.Mode = CipherMode.CBC;

                ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    msEncrypt.Write(BitConverter.GetBytes(aesAlg.IV.Length), 0, sizeof(int));
                    msEncrypt.Write(aesAlg.IV, 0, aesAlg.IV.Length);

                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        csEncrypt.Write(PlainBytes, 0, PlainBytes.Length);
                        csEncrypt.FlushFinalBlock();
                    }

                    return Convert.ToBase64String(msEncrypt.ToArray());
                }
            }

        }
        
        [Obsolete("Dont use this function didnt completed yet !!!")]
        public static string Decrypt(string CipherText, string Key)
        {
            byte[] CipherBytes = Convert.FromBase64String(CipherText);

            using (Aes aesAlg = Aes.Create())
            {
                aesAlg.Key = Encoding.UTF8.GetBytes(Key);
                aesAlg.Mode = CipherMode.CBC;

                int IvLength = BitConverter.ToInt32(CipherBytes, 0);
                byte[] Iv = new byte[IvLength];

                Array.Copy(CipherBytes, sizeof(int), Iv, 0, IvLength);

                ICryptoTransform decryptor = aesAlg.CreateEncryptor(aesAlg.Key, Iv);

                using (MemoryStream msDecrypt = new MemoryStream(CipherBytes, sizeof(int) + IvLength, CipherBytes.Length - sizeof(int) - IvLength))
                {

                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            return srDecrypt.ReadToEnd();
                        }
                    }

                }
            }
        }

        public static string HashingPassword(string Password)
        {
            using(SHA256 sHA256 = SHA256.Create())
            {

                byte[] hashBytes = sHA256.ComputeHash(Encoding.UTF8.GetBytes(Password));
                return  BitConverter.ToString(hashBytes).Replace("-","").ToLower(); 
            }
        }
        public static bool CheckAccessPermission(int UserPermissions, GlobalEnums.enUserPermission enAccessPermission)
        {
            int AccessPermission = (int)enAccessPermission;

            if (UserPermissions == (int)GlobalEnums.enUserPermission.AllPermission)
            {
                return true;
            }

            if ((AccessPermission & UserPermissions) == AccessPermission)
                return true;
            else
                return false;

        }
    }
}
