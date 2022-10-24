using System;
using System.Linq;

namespace _07._Append_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> Array -> separated by '|'
            string[] array = Console.ReadLine()
                .Split('|')
                .ToArray();

            int[] newArray = new int[100];
            int newArrayIndex = 0;

            for (int i = array.Length - 1; i >= 0; i--)
            {
                string[] currentSection = array[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < currentSection.Length; j++)
                {
                    int currentNumber = int.Parse(currentSection[j]);

                    newArray[newArrayIndex++] = currentNumber;
                }
            }

            int[] finalArray = new int[newArrayIndex];

            for (int i = 0; i < finalArray.Length; i++)
            {
                finalArray[i] = newArray[i];
            }

            Console.WriteLine(string.Join(" ", finalArray));
        }
    }
}
