using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                var input = Console.ReadLine();
                string dataType = "";
                if (input == "END")
                {
                    break;
                }
                try
                {
                    int number = int.Parse(input);
                    dataType = "integer";
                }
                catch (FormatException)
                {
                    try
                    {
                        double number = double.Parse(input);
                        dataType = "floating point";
                    }
                    catch (FormatException)
                    {
                        try
                        {
                            char number = char.Parse(input);
                            dataType = "character";
                        }
                        catch (FormatException)
                        {
                            try
                            {
                                bool number = bool.Parse(input);
                                dataType = "boolean";
                            }
                            catch (FormatException)
                            {
                                dataType = "string";
                            }
                        }
                    }
                }
                Console.WriteLine($"{input} is {dataType} type");
            }

            //string input = Console.ReadLine();
            //int valueInt;
            //float valueFloat;
            //char valueChar;
            //bool valueBoolean;

            //while (input != "END")
            //{
            //    if (int.TryParse(input, out valueInt))
            //    {
            //        Console.WriteLine($"{input} is integer type");
            //    }
            //    else if (float.TryParse(input, out valueFloat))
            //    {
            //        Console.WriteLine($"{input} is floating point type");
            //    }
            //    else if (char.TryParse(input, out valueChar))
            //    {
            //        Console.WriteLine($"{input} is character type");
            //    }
            //    else if (bool.TryParse(input, out valueBoolean))
            //    {
            //        Console.WriteLine($"{input} is boolean type");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{input} is string type");
            //    }
            //    input = Console.ReadLine();
            //}

        }
    }
}
