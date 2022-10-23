using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int t = 0; t < n; t++)
            {
                string num1 = string.Empty;
                string num2 = string.Empty;
                long rightNum = 0;
                long leftNum = 0;
                long biggestNum = 0;

                string input = Console.ReadLine();

                for (int i = 0; i < input.Length; i++)
                {
                    char ch = input[i];
                    if (ch != ' ')
                    {
                        num1 += ch;
                    }
                    else if(ch == ' ')
                    {
                        for (int k = i + 1; k < input.Length; k++)
                        {
                            char ch2 = input[k];
                            num2 += ch2;
                        }
                        break;
                    }
                }
                rightNum = long.Parse(num1);
                leftNum = long.Parse(num2);

                if (rightNum > leftNum)
                {

                    for (int i = 0; i < num1.Length; i++)
                    {
                        if (num1[i] != '-')
                        {
                            biggestNum += num1[i] - '0';
                        }
                        
                    }
                }
                else
                {
                    for (int i = 0; i < num2.Length; i++)
                    {
                        if (num2[i] != '-')
                        {
                            biggestNum += num2[i] - '0';
                        }
                    }
                }
                Console.WriteLine(biggestNum);

            }

        }
    }
}
