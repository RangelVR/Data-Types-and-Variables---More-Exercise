using System;

namespace _06._Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfLines = int.Parse(Console.ReadLine());
            
            int openCounter = 0;
            int closeCounter = 0;

            for (int i = 0; i < numOfLines; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    openCounter++;
                }
                else if (input == ")")
                {
                    closeCounter++;
                    if (openCounter - closeCounter != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }

            }

            if (openCounter == closeCounter)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }


            
        }
    }
}
