using System;

namespace _07._NxN_Matrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> int n
            int n = int.Parse(Console.ReadLine());

            PrintMatrix(n);
        }

        //2.Method that receives a single integer n and prints an NxN matrix using this number as a filler
        static void PrintMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{n} ");
                }

                Console.WriteLine();
            }
        }
    }
}
