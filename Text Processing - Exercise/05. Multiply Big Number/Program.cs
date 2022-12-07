using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Multiply_Big_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numberOne = Console.ReadLine();
            int numberTwo = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            foreach(char letter in numberOne)
            {
                int number = int.Parse(letter.ToString());
                numbers.Add(number);
            }

            List<int> sum = new List<int>();
            int left = 0;
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                int currentNumber = numbers[i];

                int multiply = currentNumber * numberTwo + left;
                if(multiply >= 10)
                {
                    left = 0;
                    sum.Insert(0, multiply % 10);
                    left += multiply / 10;
                    continue;
                }

                left = 0;
                sum.Insert(0, multiply);
            }

            if(left != 0)
            {
                sum.Insert(0, left);
            }
            
            if(numberOne.Length == 0 || numberTwo == 0 || sum.Count == 0)
            {
                Console.WriteLine(0);
            }
            else
            {
                foreach (int number in sum)
                {
                    Console.Write($"{number}");
                }
            }
            Console.WriteLine();
        }
    }
}
