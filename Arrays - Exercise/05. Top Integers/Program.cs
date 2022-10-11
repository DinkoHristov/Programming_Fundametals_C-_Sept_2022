using System;
using System.Linq;

namespace _05._Top_Integers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program to find all the top integers in an array.
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //2.A top integer is an integer that is greater than all the elements to its right.
            for (int i = 0; i < numbers.Length; i++)
            {
                bool isGreater = true;
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    if (numbers[i] > numbers[j])
                    {
                        isGreater = true;
                    }
                    else
                    {
                        isGreater = false;
                        break;
                    }
                }

                if (isGreater)
                {
                    Console.Write($"{numbers[i]} ");
                }
            }
        }
    }
}
