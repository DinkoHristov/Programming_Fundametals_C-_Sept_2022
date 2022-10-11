using System;
using System.Linq;

namespace _07._Max_Sequence_of_Equal_Elements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that finds the longest sequence of equal elements in an array of integers.
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //2.If several equal sequences are present in the array, print out the leftmost one.
            int count = 1;
            int theBiggest = 0;
            int element = 0;
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] == numbers[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }

                if (count > theBiggest)
                {
                    theBiggest = count;
                    element = numbers[i];
                }
            }

            for (int j = 1; j <= theBiggest; j++)
            {
                Console.Write($"{element} ");
            }
        }
    }
}
