using System;
using System.Numerics;

namespace _08._Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> 2 lines;
            //1.1 First line -> numberOne
            //1.2 Second line -> nubmerTwo
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            double result = PrintFactorial(numberOne, numberTwo);
            Console.WriteLine($"{result:F2}");
        }

        //2.Method to calculate the factorial of each number.
        //-> Divide the first result by the second and print the result 
        static double PrintFactorial(int numberOne, int numberTwo)
        {
            long factNumberOne = 1;
            long factNumberTwo = 1;
            double result = 0;

            for (int i = 1; i <= numberOne; i++)
            {
                factNumberOne *= i;
            }

            for (int i = 1; i <= numberTwo; i++)
            {
                factNumberTwo *= i;
            }

            result = (double)factNumberOne / factNumberTwo;

            return result;
        }
    }
}
