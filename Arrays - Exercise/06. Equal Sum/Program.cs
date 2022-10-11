using System;
using System.Linq;

namespace _06._Equal_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that determines if an element exists in an array
            // -> for which the sum of all elements to its left is equal to the sum of all elements to its right.
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //2.If there are no elements to the left or right, their sum is considered to be 0.
            bool isFound = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int leftSum = 0;
                for (int k = 0; k < i; k++)
                {
                    leftSum += numbers[k];
                }

                int rightSum = 0;
                for (int j = numbers.Length - 1; j > i; j--)
                {
                    rightSum += numbers[j];
                }

                if (leftSum == rightSum && !isFound)
                {
                    Console.WriteLine(i);
                    isFound = true;
                    break;
                }
            }

            //3.Print the index of the element that satisfies the condition or "no" if there is no such element.
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
