int key = int.Parse(Console.ReadLine());
int lines = int.Parse(Console.ReadLine());

string message = string.Empty;

while (lines > 0)
{
    char letter = char.Parse(Console.ReadLine());
    
    message += (char)(letter + key);

    lines--;
}

Console.WriteLine(message);
