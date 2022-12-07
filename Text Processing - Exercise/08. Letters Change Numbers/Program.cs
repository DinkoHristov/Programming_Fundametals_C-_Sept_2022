using System;

namespace _08._Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //A12b s17G
            string[] input = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            //A12b
            //s17G
            double result = 0;
            foreach (string word in input)
            {
                //A12b
                char firstChar = word[0];
                char lastChar = word[^1];
                string strNumber = word[1..^1]; // From 1 to the last index -> "12"
                double dbNumber = double.Parse(strNumber); // 12

                dbNumber = CheckNumber(dbNumber, firstChar, lastChar);
                result += dbNumber;
            }

            Console.WriteLine($"{result:F2}");
        }

        static double CheckNumber(double dbNumber, char firstChar, char lastChar)
        {
            if (char.IsUpper(firstChar))
            {
                int position = firstChar - 64;
                dbNumber /= position;
            }
            else
            {
                int position = firstChar - 96;
                dbNumber *= position;
            }

            if (char.IsUpper(lastChar))
            {
                int position = lastChar - 64;
                dbNumber -= position;
            }
            else
            {
                int position = lastChar - 96;
                dbNumber += position;
            }

            return dbNumber;
        }
    }
}
