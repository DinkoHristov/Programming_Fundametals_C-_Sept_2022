using System;

namespace _06._Triples_of_Latin_Letters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that receives an integer n
            int n = int.Parse(Console.ReadLine());

            //2.Print all triples of the first n small Latin letters, ordered alphabetically:
            int firstChar = (int)'a';
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    for (int k = 0; k < n; k++)
                    {
                        Console.WriteLine($"{(char)(firstChar + i)}{(char)(firstChar + j)}{(char)(firstChar + k)}");
                    }
                }
            }
        }
    }
}
