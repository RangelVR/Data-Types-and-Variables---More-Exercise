using System;

namespace _05._Decrypting_Message
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int nChars = int.Parse(Console.ReadLine());
            string decriptedMessage = string.Empty;

            for (int i = 0; i < nChars; i++)
            {
                char ch = char.Parse(Console.ReadLine());
                char decryptedChar = (char)(ch + key);
                decriptedMessage += decryptedChar;
            }

            Console.WriteLine(decryptedMessage);
        }
    }
}
