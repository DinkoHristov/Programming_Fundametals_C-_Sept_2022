using System;
using System.Linq;

namespace _02._Car_Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> int[] array from numbers
            int[] numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            //2.We will receive always and odd array length
            //2.1 Cars finish line will be the middle element of the array
            int finishLine = (numbers.Length - 1) / 2; // Returns the middle element of the array

            //3.First racer time
            // First racer starts from the first element of the array and finished at the middle element of the array
            double firstRacerTime = 0;
            for (int i = 0; i < finishLine; i++)
            {
                int currentNumber = numbers[i];

                //4.Check if current number of the array == 0
                //  If it is 0 we will reduce racer time
                if (currentNumber == 0)
                {
                    firstRacerTime *= 0.8;
                    continue;
                }

                firstRacerTime += currentNumber;
            }

            //5.Second racer time
            // Second racer starts from the end of the array until finish line.
            double secondRacerTime = 0;
            for (int i = numbers.Length - 1; i > finishLine; i--)
            {
                int currentNumber = numbers[i];

                //6.Check if current number of the array == 0
                //  If it is 0 we will reduce racer time
                if (currentNumber == 0)
                {
                    secondRacerTime *= 0.8;
                    continue;
                }

                secondRacerTime += currentNumber;
            }

            //7.We check times now (We will print racer's smaller time, because the smallest time wins):
            //7.1 If first racer time is smaller than second racer time, we will print first racer
            //7.2 If second racer time is smaller than first racer time, we will print second racer
            if (firstRacerTime < secondRacerTime)
            {
                Console.WriteLine($"The winner is left with total time: {firstRacerTime}");
            }
            else if (secondRacerTime < firstRacerTime)
            {
                Console.WriteLine($"The winner is right with total time: {secondRacerTime}");
            }
        }
    }
}
