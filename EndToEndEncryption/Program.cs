using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace EndToEndEncryption
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = "b14ca5898a4e4133bbce2ea2315a1916";
            Console.WriteLine("Please enter a string for encryption");
            var message = Console.ReadLine();
            var encryptedString = EncryptDecrypt.EncryptString(key, message);
            Console.WriteLine($"encrypted string = {encryptedString}");
            var decryptedString = EncryptDecrypt.DecryptString(key, encryptedString);
            Console.WriteLine($"decrypted string = {decryptedString}");
            Console.ReadKey();
        }
    }

}