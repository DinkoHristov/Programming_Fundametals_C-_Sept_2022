using System;

namespace _06._Middle_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> string
            string input = Console.ReadLine();

            string middleChar = MiddleCharacter(input);
            Console.WriteLine(middleChar);
        }

        //2.Method that prints the character found at its middle.
        // -> If the length of the string is even there are two middle characters.
        static string MiddleCharacter(string input)
        {
            bool isEven = false;
        
            if (input.Length % 2 == 0)
            {
                isEven = true;
            }
        
            string middleChar = string.Empty;
            if (isEven)
            {
                for (int i = input.Length / 2 - 1; i < input.Length / 2 + 1; i++)
                {
                    middleChar += input[i];
                }
            }
            else
            {
                for (int i = input.Length / 2; i < input.Length / 2 + 1; i++)
                {
                    middleChar += input[i];
                }
            }

            return middleChar;
        }
    }
}
