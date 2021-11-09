using System;

namespace RSAAsymmetricKey
{
    class Program
    {
        static void Main(string[] args)
        {
            //RSA Encryption with Twileloop.ExpressSecurity

            //1. Generate a key pair !create folder Demo
            ExpressEncription.RSAEncription.MakeKey(@"C:\Demo\public.key", @"C:\Demo\private.key");

            //2. Encrypt
            var plainText = "hello world!!";
            var EncryptText = ExpressEncription.RSAEncription.EncryptString(plainText, @"C:\Demo\public.key");
            Console.WriteLine(EncryptText);

            //3.Decrypt
            var DecryptText = ExpressEncription.RSAEncription.DecryptString(EncryptText, @"C:\Demo\private.key");
            Console.WriteLine(DecryptText);


        }
    }
}
