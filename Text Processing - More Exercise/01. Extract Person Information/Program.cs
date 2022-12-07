using System;
using System.Collections.Generic;

namespace _01._Extract_Person_Information
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string text = Console.ReadLine();
                int nameStartIndex = text.IndexOf('@');
                int nameLastIndex = text.LastIndexOf('|');
                string name = text.Substring(nameStartIndex + 1, nameLastIndex - nameStartIndex - 1);
                int ageStartIndex = text.IndexOf('#');
                int ageLastIndex = text.LastIndexOf('*');
                int age = int.Parse(text.Substring(ageStartIndex + 1, ageLastIndex - ageStartIndex - 1));

                Console.WriteLine($"{name} is {age} years old.");
            }
        }
    }
}
