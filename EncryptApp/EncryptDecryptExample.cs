using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;
using System.Text;


namespace EncryptApp
{
    class EncryptDecryptExample
    {
        private static RSAParameters publicKey;
        private static RSAParameters privateKey;

        static string CONTAINER_NAME = "My Container Name";

        public enum KeySizes
        {
            SIZE_512 = 512,
            SIZE_1024 = 1024,
            SIZE_2024 = 2024,
            SIZE_952 = 952,  
            SIZE_1369 = 1369


        };

        static void Main(string[] args)
        {
            string message = "2343234678909876";
            generateKeys();
            byte[] encrypted = Encrypt(Encoding.UTF8.GetBytes(message));
            byte[] decrypted = Decrypt(encrypted);

            Console.WriteLine("Message: " + message);
            Console.WriteLine("Encrypted : \n " + BitConverter.ToString(encrypted).Replace("-", " ") + "\n");
            Console.WriteLine("Decripted : " + Encoding.UTF8.GetString(decrypted));

            Console.ReadLine();

        }

        static void generateKeys()
        {
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                publicKey = rsa.ExportParameters(false);
                privateKey = rsa.ExportParameters(true);
            }
        }

        static byte[] Encrypt(byte[] input)
        {
            byte[] encrypted;
            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(publicKey);
                encrypted = rsa.Encrypt(input, true);
            }

            return encrypted;
        }

        static byte[] Decrypt(byte[] input)
        {
            byte[] decrypted;

            using (var rsa = new RSACryptoServiceProvider(2048))
            {
                rsa.PersistKeyInCsp = false;
                rsa.ImportParameters(privateKey);
                decrypted = rsa.Decrypt(input, true);

            }
            return decrypted;
        }
    }
}
