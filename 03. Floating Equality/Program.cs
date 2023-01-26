double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
bool isEqual = false;

if (Math.Abs(a - b) >= 0.000001)
{
    isEqual = false;
}
else
{
    isEqual = true;
}

Console.WriteLine(isEqual);

--------------------------------------------------------
//double EPS = 0.000001;

//double a = double.Parse(Console.ReadLine());
//double b = double.Parse(Console.ReadLine());

//if ((Math.Abs(a - b)) < EPS)
//{
//    Console.WriteLine(true);
//}
//else
//{
//    Console.WriteLine(false);
//}
