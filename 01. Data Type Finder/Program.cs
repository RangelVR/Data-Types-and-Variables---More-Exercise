using System;

namespace _01._Data_Type_Finder
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();

            string dataType = string.Empty;

            while (input != "END")
            {
                try
                {
                    int value = int.Parse(input);
                    dataType = "integer";
                }
                catch (Exception)
                {
                    try
                    {
                        float value = float.Parse(input);
                        dataType = "floating point";
                    }
                    catch (Exception)
                    {
                        try
                        {
                            char value = char.Parse(input);
                            dataType = "character";
                        }
                        catch (Exception)
                        {
                            try
                            {
                                bool value = bool.Parse(input);
                                dataType = "boolean";
                            }
                            catch (Exception)
                            {

                                dataType = "string";
                            }
                        }
                    }
                }
                Console.WriteLine($"{input} is {dataType} type");

                input = Console.ReadLine();
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
