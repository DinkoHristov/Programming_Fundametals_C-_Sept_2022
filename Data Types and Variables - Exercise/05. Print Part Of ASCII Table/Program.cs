using System;

namespace _05._Print_Part_Of_ASCII_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.On the first line of input, you will receive the char index you should start with
            // On the second line - the index of the last character you should print.
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            //2.Find online more information about ASCII (American Standard Code for Information Interchange)
            // Write a program that prints part of the ASCII table of characters at the console.
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
