using System;

namespace _02._From_Left_to_The_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            


            for (int i = 0; i < n; i++)
            {

                string rightNum = string.Empty;
                string leftNum = string.Empty;
                long rightPars;
                long leftPars;
                long rightSum = 0;
                long leftSum = 0;

                string twoNumbers = Console.ReadLine();

                for (int j = 0; j <= twoNumbers.Length-1; j++)
                {
                    if (twoNumbers[j] != ' ')
                    {
                        rightNum += twoNumbers[j];
                    }
                    else if (twoNumbers[j] == ' ')
                    {
                        for (int k = j + 1; k <= twoNumbers.Length -1; k++)
                        {
                            leftNum += twoNumbers[k];
                        }
                        break;
                    }
                }

                rightPars = long.Parse(rightNum);
                leftPars = long.Parse(leftNum);

                if (leftPars > rightPars)
                {
                    for (int f = 0; f <= leftNum.Length - 1; f++)
                    {
                        if (leftNum[f] != '-')
                        {
                            leftSum += leftNum[f] - '0';
                        }
                         
                    }
                    Console.WriteLine(leftSum);
                }
                else if (leftPars <= rightPars)
                {
                    for (int f = 0; f <= rightNum.Length - 1; f++)
                    {
                        if (rightNum[f] != '-')
                        {
                            rightSum += rightNum[f] - '0';
                        }
                        
                    }
                    Console.WriteLine(rightSum);
                }
                
            }
        }
    }
}
