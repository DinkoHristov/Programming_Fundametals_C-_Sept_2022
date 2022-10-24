using System;
using System.Collections.Generic;

namespace _03._Take_Skip_Rope
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - string input
            string input = Console.ReadLine();

            //2.Take every digit from the string and store it in List.
            List<char> chars = new List<char>();
            List<int> numbers = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char currentChar = input[i];

                //3.If current char is number we will add it in another list
                if (currentChar >= 48 && currentChar <= 57)
                {
                    int number = int.Parse(currentChar.ToString());
                    numbers.Add(number);
                    chars.Remove(currentChar);
                    continue;
                }

                chars.Add(currentChar);
            }

            //4. Make two lists for even and odd index numbers in numbers list.
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int index = i;

                if (index % 2 == 0)
                {
                    evenNumbers.Add(currentNumber);
                }
                else
                {
                    oddNumbers.Add(currentNumber);
                }
            }

            //5.
            string result = string.Empty;

            for (int i = 0; i < evenNumbers.Count; i++)
            {
                int takenCount = evenNumbers[i];

                for (int t = 0; t < takenCount; t++)
                {
                    if (chars.Count != 0)
                    {
                        int index = 0;
                        char currentElement = chars[index];
                        result += currentElement;
                        chars.RemoveAt(index);
                    }
                }

                int skippedCount = oddNumbers[i];

                for (int s = 0; s < skippedCount; s++)
                {
                    if (chars.Count != 0)
                    {
                        int index = 0;
                        char currentElement = chars[index];
                        chars.Remove(currentElement);
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
