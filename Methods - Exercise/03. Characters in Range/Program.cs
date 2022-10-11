using System;

namespace _03._Characters_in_Range
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> 2 lines:
            //1.1 First line -> char startingChar
            //1.2 Second line -> char endingChar
            char startingChar = char.Parse(Console.ReadLine());
            char endingChar = char.Parse(Console.ReadLine());

            PrintCharacters(startingChar, endingChar);
        }

        //2.Method that receives two characters and prints all the characters between them according to ASCII (on a single line).
        static void PrintCharacters(char startingChar, char endingChar)
        {
            if (startingChar > endingChar)
            {
                char temp = startingChar;
                startingChar = endingChar;
                endingChar = temp;
            }

            startingChar++;
            for (char i = startingChar; i < endingChar; ++i)
            {
                Console.Write($"{i} ");
            }
        }
    }
}
