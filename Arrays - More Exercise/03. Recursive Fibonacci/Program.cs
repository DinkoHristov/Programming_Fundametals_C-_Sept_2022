using System;

namespace _03._Recursive_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wantedFibonacciNumber = int.Parse(Console.ReadLine());

            int[] fibonacci = new int[wantedFibonacciNumber + 1];
            if (wantedFibonacciNumber == 0)
            {
                fibonacci[0] = 0;
            }
            else if (wantedFibonacciNumber == 1)
            {
                fibonacci[1] = 1;
            }
            else if (wantedFibonacciNumber == 2)
            {
                fibonacci[2] = 1;
            }
            else
            {
                int fibonacciNumber = 0;
                for (int i = 3; i <= wantedFibonacciNumber; i++)
                {
                    fibonacci[0] = 0;
                    fibonacci[1] = 1;
                    fibonacci[2] = 1;
                    fibonacciNumber = fibonacci[i - 1] + fibonacci[i - 2];
                    fibonacci[i] = fibonacciNumber;
                }
            }

            Console.WriteLine(fibonacci[wantedFibonacciNumber]);
        }
    }
}
