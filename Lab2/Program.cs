using System;
using System.Text;

namespace Lab2
{
    class Program
    {
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine(CreateMD5(""));
            Console.WriteLine(CreateMD5("a"));
            Console.WriteLine(CreateMD5("abc"));
            Console.WriteLine(CreateMD5("message digest"));
            Console.WriteLine(CreateMD5("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(CreateMD5("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"));
            Console.WriteLine(CreateMD5("12345678901234567890123456789012345678901234567890123456789012345678901234567890"));

            Console.WriteLine("--------------------------");

            Console.WriteLine(MD5.Calculate(""));
            Console.WriteLine(MD5.Calculate("a"));
            Console.WriteLine(MD5.Calculate("abc"));
            Console.WriteLine(MD5.Calculate("message digest"));
            Console.WriteLine(MD5.Calculate("abcdefghijklmnopqrstuvwxyz"));
            Console.WriteLine(MD5.Calculate("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"));
            Console.WriteLine(MD5.Calculate("12345678901234567890123456789012345678901234567890123456789012345678901234567890"));

            Console.ReadLine();
        }
    }
}
