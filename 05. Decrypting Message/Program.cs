using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = int.Parse(Console.ReadLine());
            int countLetters = int.Parse(Console.ReadLine());
            string decodedWord = string.Empty;

            for (int i = 0; i < countLetters; i++)
            {
                char letter = char.Parse(Console.ReadLine());
                decodedWord += (char)(letter + key);
            }
            Console.WriteLine(decodedWord);
        }
    }
}
