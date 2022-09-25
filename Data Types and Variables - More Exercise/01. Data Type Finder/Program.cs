using Microsoft.VisualBasic;
using System;

namespace _01._Data_Type_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.You will receive input until you receive "END". Find what data type is the input. Possible data types are:
            // -> Integer
            // -> Floating point 
            // -> Characters
            // -> Boolean
            // -> Strings
            string input = Console.ReadLine();
            int intValue;
            float floatValue;
            char charValue;
            bool boolValue;

            //2.Print the result in the following format:
            //      "{input} is {data type} type"
            while (input != "END")
            {
                if (int.TryParse(input, out intValue))
                {
                    Console.WriteLine($"{input} is integer type");
                }
                else if (float.TryParse(input, out floatValue))
                {
                    Console.WriteLine($"{input} is floating point type");
                }
                else if (char.TryParse(input, out charValue))
                {
                    Console.WriteLine($"{input} is character type");
                }
                else if (bool.TryParse(input, out boolValue))
                {
                    Console.WriteLine($"{input} is boolean type");
                }
                else
                {
                    Console.WriteLine($"{input} is string type");
                }

                input = Console.ReadLine();
            }
        }
    }
}
