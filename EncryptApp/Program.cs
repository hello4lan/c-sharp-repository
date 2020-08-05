using System;
using System.Security.Cryptography;
using System.Text;

namespace EncryptApp
{
    class Program
    {
        /*
        public static byte[] RSAEncrypt(byte[] DataToEncrypted ,RSAParameters RSAkeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] EncryptedData;
                using(RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAkeyInfo);
                    EncryptedData = RSA.Encrypt(DataToEncrypted, DoOAEPPadding);

                    

                }

                return EncryptedData;
            }catch(CryptographicException e)
            {

                Console.WriteLine(e.Message);
                return null;
            }

            

        }

        public static byte[] RSADecrypt(byte[] DataToEncrypt , RSAParameters RSAkeyInfo, bool DoOAEPPadding)
        {
            try
            {
                byte[] DecryptedData;

                using (RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {
                    RSA.ImportParameters(RSAkeyInfo);
                    DecryptedData = RSA.Decrypt(DataToEncrypt, DoOAEPPadding);

                    return DecryptedData;
                }
            }catch(CryptographicException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        static void Main(string[] args)
        {
            try
            {
                UnicodeEncoding ByteConverter = new UnicodeEncoding();
                byte[] dataToEncrypted = ByteConverter.GetBytes("1234567812345678");
                byte[] encryptedData;
                byte[] decryptedData;

                using(RSACryptoServiceProvider RSA = new RSACryptoServiceProvider())
                {

                    encryptedData = RSAEncrypt(dataToEncrypted, RSA.ExportParameters(false), false);

                    Console.WriteLine("ENCRYPTED DATA");
                   

                    decryptedData = RSADecrypt(encryptedData, RSA.ExportParameters(true), false);
                    Console.WriteLine("DECRYPTED DATA");
                    Console.WriteLine()
                    for (int i = 0; i <= decryptedData.Length - 1; i++)
                    {
                        Console.WriteLine(decryptedData[i]);
                    }


                }


                Console.WriteLine("Hello World!");

            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
                    }
    }
        */

    }
}
