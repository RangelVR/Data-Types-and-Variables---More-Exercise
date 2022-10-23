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

-Въпреки, че това решение се дъни на този вход, то в Judge минава 100/100:
11
(
5 + 10
)
* 
(
2 +
(
5
)
-12
)

            //int numOfLines = int.Parse(Console.ReadLine());
            
            //int openCounter = 0;
            //int closeCounter = 0;

            //for (int i = 0; i < numOfLines; i++)
            //{
            //    string input = Console.ReadLine();

            //    if (input == "(")
            //    {
            //        openCounter++;
            //    }
            //    else if (input == ")")
            //    {
            //        closeCounter++;
            //        if (openCounter - closeCounter != 0)
            //        {
            //            Console.WriteLine("UNBALANCED");
            //            return;
            //        }
            //    }

            //}

            //if (openCounter == closeCounter)
            //{
            //    Console.WriteLine("BALANCED");
            //}
            //else
            //{
            //    Console.WriteLine("UNBALANCED");
            //}
