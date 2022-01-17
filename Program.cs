using System;

namespace ghobart2024_DataEncodingInCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;
            message = System.IO.File.ReadAllText("secrets/1.txt");
            Console.WriteLine($"The encrypted message is: '{message}'.");

            string decryptedMessage = string.Empty;
            foreach (char c in message)
            {
                message += (char)(c - 5);
            }
            return message;
        }
    }
}
