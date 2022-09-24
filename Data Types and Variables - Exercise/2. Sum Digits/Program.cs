using System;

namespace _2._Sum_Digits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that receives a single integer.
            int number = int.Parse(Console.ReadLine());

            //2.Your task is to find the sum of its digits.
            //  For example: 12345 -> 1+2+3+4+5 = 15
            int sumDigits = 0;
            while (number > 0)
            {
                sumDigits += number % 10;
                number /= 10;
            }

            Console.WriteLine(sumDigits);
        }
    }
}
