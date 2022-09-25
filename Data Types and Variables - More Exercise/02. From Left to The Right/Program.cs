using System;
using System.Linq;
using System.Numerics;

namespace _02._From_Left_to_The_Right
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.You will receive a number that represents how many lines we will get as input.
            int linesNumber = int.Parse(Console.ReadLine());

            //2.On the next N lines, you will receive a string with 2 numbers separated by a single space.
            for (int i = 1; i <= linesNumber; i++)
            {
                // BigInteger because we have numbers greater than 9 billion.
                BigInteger[] arr = Console.ReadLine()
                    .Split()
                    .Select(BigInteger.Parse)
                    .ToArray();

                BigInteger numberOne = arr[0];
                BigInteger numberTwo = arr[1];

                //3.You need to compare them.
                // -> If the left number is greater than the right number,
                //     you need to print the sum of all digits in the left number.
                int sum = 0;
                if (numberOne > numberTwo)
                {
                    while (numberOne != 0)
                    {
                        sum += Math.Abs((int)(numberOne % 10));
                        numberOne /= 10;
                    }

                    Console.WriteLine(sum);
                }
                // -> Otherwise print the sum of all digits in the right number.
                else
                {
                    while (numberTwo != 0)
                    {
                        sum += Math.Abs((int)(numberTwo % 10));
                        numberTwo /= 10;
                    }

                    Console.WriteLine(sum);
                }
            }
        }
    }
}
