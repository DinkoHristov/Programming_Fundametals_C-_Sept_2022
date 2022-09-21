using System;

namespace _04._Print_and_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input:
            // start number - int
            // end number - int
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());

            //2.Output on two lines:
            //  On the first line print, all numbers from the start of the sequence to the end inclusive
            //	On the second line print the sum of the sequence in the format: "Sum: {sum}"
            int sum = 0;
            for (int i = start; i <= end; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
