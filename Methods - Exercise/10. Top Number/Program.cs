using System;

namespace _10._Top_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> int number
            int number = int.Parse(Console.ReadLine());

            PrintTopNumbers(number);
        }

        //2.Method to print all top numbers.
        static void PrintTopNumbers(int number)
        {
            for (int i = 17; i <= number; i++)
            {
                int sumDigits = 0;
                int oddDigit = 0;

                int currentNumber = i;

                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    sumDigits += currentDigit;
                    if (currentDigit % 2 != 0)
                    {
                        oddDigit++;
                    }
                    currentNumber /= 10;
                }

                if (sumDigits % 8 == 0 && oddDigit >= 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
