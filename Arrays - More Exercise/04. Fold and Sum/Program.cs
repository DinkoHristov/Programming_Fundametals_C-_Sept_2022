using System;
using System.Linq;

namespace _04._Fold_and_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Read an array of 4*k integers
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //2.Fold it like shown below, and print the sum of the upper and lower two rows:
            // -> (each holding 2 * k integers):
            // Example: Input: [1 2 {3 4 5 6} 7 8] => Output: 5 5 13 13 <=> Comments: 2   1   8   7  +
            //                                                                        3   4   5   6  =
            //                                                                        5   5   13  13

            // upperArray => 2 1 8 7 
            int[] upperArray = new int[numbers.Length / 2];
            // lowerArray => 3 4 5 6
            int[] lowerArray = new int[numbers.Length / 2];
            // foldArray => 5 5 13 13 (Sum of upperArray[index] + lowerArray[index])
            int[] foldArray = new int[numbers.Length / 2];

            int firstNumbers = 0;
            for (int i = 0; i < numbers.Length / 4; i++)
            {
                upperArray[i] = numbers[numbers.Length / 4 - 1 - i];
                firstNumbers++;
            }

            for (int i = numbers.Length - 1; i >= 3 * numbers.Length / 4; i--)
            {
                upperArray[firstNumbers] = numbers[i];
                firstNumbers++;
            }

            for (int i = numbers.Length / 4; i < 3 * numbers.Length / 4; i++)
            {
                lowerArray[i - numbers.Length / 4] = numbers[i];
            }

            for (int i = 0; i < upperArray.Length; i++)
            {
                foldArray[i] = upperArray[i] + lowerArray[i];
            }

            Console.WriteLine(string.Join(' ', foldArray));
        }
    }
}
