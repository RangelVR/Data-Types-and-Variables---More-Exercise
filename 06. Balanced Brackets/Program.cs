using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countOpen = 0;
            int countClose = 0;

            for (int i = 0; i < n; i++)
            {
                string ch = Console.ReadLine();
                if (ch == "(")
                {
                    countOpen++;
                }
                else if (ch == ")")
                {
                    countClose++;
                    if (countOpen - countClose != 0)
                    {
                        Console.WriteLine("UNBALANCED");
                        return;
                    }
                }               
            }
            if (countOpen == countClose)
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
