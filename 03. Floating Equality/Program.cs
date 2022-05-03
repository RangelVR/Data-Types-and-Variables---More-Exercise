using System;
using System.Numerics;

namespace _03._Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
             
            decimal EPS =  0.000001m;

            decimal a = decimal.Parse(Console.ReadLine());
            decimal b = decimal.Parse(Console.ReadLine());

            if ((Math.Abs(a - b)) < EPS)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
        }
    }
}
