using System;
using static System.Net.Mime.MediaTypeNames;

namespace _04._Sum_of_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.On the first line, you will receive n – the number of lines, which will follow
            //	On the next n lines – you will receive letters from the Latin alphabet
            int n = int.Parse(Console.ReadLine());

            int sumLetters = 0;
            for (int i = 1; i <= n; i++)
            {
                char letter = char.Parse(Console.ReadLine());

                //2.Create a program, which sums the ASCII codes of n characters and prints the sum on the console.
                sumLetters += (int)letter;
            }

            //3.Print the total sum in the following format:
            //  "The sum equals: {totalSum}"
            Console.WriteLine($"The sum equals: {sumLetters}");
        }
    }
}
