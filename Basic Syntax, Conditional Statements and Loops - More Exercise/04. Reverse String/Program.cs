using System;

namespace _04._Reverse_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program which reverses a string and print it on the console.
            // Example: Hello -> olleH
            string word = Console.ReadLine();

            string reversedWord = string.Empty;
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reversedWord += word[i];
            }

            Console.WriteLine(reversedWord);
        }
    }
}
