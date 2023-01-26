int n = int.Parse(Console.ReadLine());


while (n > 0)
{
    string numbers = Console.ReadLine();

    long sumRight = 0;
    long sumLeft = 0;
    string rightNum = string.Empty;
    string leftNum = string.Empty;

    for (int i = 0; i < numbers.Length; i++)
    {
        rightNum += (char)numbers[i];

        if (numbers[i] == ' ')
        {
            for (int k = i + 1; k < numbers.Length; k++)
            {
                leftNum += (char)numbers[k];
            }
            break;
        }
    }

    long right = long.Parse(rightNum);
    long left = long.Parse(leftNum);

    if (right > left)
    {
        right = Math.Abs(right);

        while (right > 0)
        {
            sumRight += right % 10;
            right /= 10;
        }
        Console.WriteLine(sumRight);
    }
    else
    {
        left = Math.Abs(left);
        while (left > 0)
        {
            sumLeft += left % 10;
            left /= 10;
        }
        Console.WriteLine(sumLeft);
    }

    n--;
}
