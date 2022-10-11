using System;
using System.Linq;

namespace _02._Common_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that prints out all common elements in two arrays.
            string[] array1 = Console.ReadLine()
                .Split()
                .ToArray();

            string[] array2 = Console.ReadLine()
                .Split()
                .ToArray();

            //2.You have to compare the elements of the second array to the elements of the first.
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        Console.Write($"{array2[i]} ");
                    }
                }
            }
        }
    }
}
