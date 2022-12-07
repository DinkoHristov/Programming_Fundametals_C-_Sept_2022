using System;

namespace _03._Extract_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = Console.ReadLine();

            char separator = (char)92;
            string[] fileParameters = filePath
                .Split(separator);

            string[] nameAndPath = fileParameters[fileParameters.Length - 1].Split('.');
            string name = nameAndPath[0];
            string path = nameAndPath[1];

            Console.WriteLine($"File name: {name}");
            Console.WriteLine($"File extension: {path}");
        }
    }
}
