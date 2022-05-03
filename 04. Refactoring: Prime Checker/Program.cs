using System;

namespace _04._Refactoring_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int stopNum = int.Parse(Console.ReadLine());

            for (int currNum = 2; currNum <= stopNum; currNum++)
            {
                string prime = "true";
                for (int startNum = 2; startNum < currNum; startNum++)
                {
                    if (currNum % startNum == 0)
                    {
                        prime = "false";
                        break;
                    }
                }
                Console.WriteLine($"{currNum} -> {prime}");
            }

        }
    }
}
