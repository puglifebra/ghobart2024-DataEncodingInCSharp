using System;

namespace ghobart2024_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath;
            FilePath = args[0];
            Console.WriteLine($"Loading {FilePath}");

            string message;
            message = System.IO.File.ReadAllText($"{FilePath}");
            Console.WriteLine($"The encrypted message is: '{message}'.");

            Cipher cipher;
            cipher = new Cipher(3);

            string decrypted; 
            decrypted = cipher.Decrypt(message);
            Console.WriteLine($"The decrypted message is: '{decrypted}'");

            int shift = (1);
            while (shift <= 10)
            {
                cipher = new Cipher(shift);
                decrypted = cipher.Decrypt(message);
                Console.WriteLine($"The decrypted message is: '{decrypted}'");
                shift = (shift + 1);
            }

        }
    }
}
