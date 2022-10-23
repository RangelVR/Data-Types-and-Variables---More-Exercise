using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter1 = 0;
            int counter2 = 0;

            for (int i = 0; i < n; i++)
            {
                string ch = Console.ReadLine();
                if (ch == ")")
                {
                    Console.WriteLine("UNBALANCED");
                    return;
                }
                else if (ch == "(")
                {
                    counter1++;
                    for (int j = i + 1; j < n; j++)
                    {
                        ch = Console.ReadLine();
                        if (ch == ")")
                        {
                            counter2++;
                        }
                        else if (ch == "(")
                        {
                            counter1++;
                        }
                    }
                    break;
                }
            }
            if (counter1 == counter2)
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
