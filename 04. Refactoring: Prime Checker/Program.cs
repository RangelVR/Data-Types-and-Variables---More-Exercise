int stopNum = int.Parse(Console.ReadLine());

for (int startNum = 2; startNum <= stopNum; startNum++)
{
    string isPrime = "true";

    for (int currNum = 2; currNum < startNum; currNum++)
    {
        if (startNum % currNum == 0)
        {
            isPrime = "false";
            break;
        }
    }
    Console.WriteLine("{0} -> {1}", startNum, isPrime);
}
