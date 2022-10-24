using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            List<int> bombParams = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToList();

            int bombNumber = bombParams[0];
            int bombPower = bombParams[1];

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] == bombNumber)
                {
                    int start = i - bombPower;

                    if (start < 0)
                    {
                        start = 0;
                    }

                    int end = i + bombPower + 1;

                    if (end > numbers.Count)
                    {
                        end = numbers.Count;
                    }

                    for (int j = start; j < end; j++)
                    {
                        numbers.RemoveAt(start);
                    }

                    i--;
                }
            }

            Console.WriteLine(numbers.Sum());
        }
    }
}
