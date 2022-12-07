using System;

namespace _02._Character_Multiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            string wordOne = input[0];
            string wordTwo = input[1];

            decimal result = 0;
            int wordOneLength = input[0].Length;
            int wordTwoLength = input[1].Length;
            int smallerWordLength = wordOneLength;

            int difference = 0;
            bool isOneBigger = false;
            bool isTwoBigger = false;

            if (wordOneLength > wordTwoLength)
            {
                isOneBigger = true;
                difference = wordOneLength - wordTwoLength;
                smallerWordLength = wordTwoLength;
            }
            else if (wordOneLength < wordTwoLength)
            {
                isTwoBigger = true;
                difference = wordTwoLength - wordOneLength;
                smallerWordLength = wordOneLength;
            }

            for (int i = 0; i < smallerWordLength; i++)
            {
                result += (decimal)wordOne[i] * (decimal)wordTwo[i];
            }

            if (isOneBigger)
            {
                for (int j = wordOneLength - 1; j >= wordOneLength - difference; j--)
                {
                    result += (decimal)wordOne[j];
                }
            }
            else if (isTwoBigger)
            {
                for (int j = wordTwoLength - 1; j >= wordTwoLength - difference; j--)
                {
                    result += (decimal)wordTwo[j];
                }
            }

            Console.WriteLine(result);
        }
    }
}
