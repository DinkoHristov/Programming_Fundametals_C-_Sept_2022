using System;
using System.Linq;

namespace _03._Zig_Zag_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.You will be given an integer n.
            int n = int.Parse(Console.ReadLine());

            //2.Create a program that creates 2 arrays.
            int[] array1 = new int[n];
            int[] array2 = new int[n];

            //3.On the next n lines, you will get 2 integers.
            int firstIndex = 0;
            int secondIndex = 1;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                int[] numbers = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                if (count % 2 != 0)
                {
                    array1[i] = numbers[secondIndex];
                    array2[i] = numbers[firstIndex];
                }
                else
                {
                    array1[i] = numbers[firstIndex];
                    array2[i] = numbers[secondIndex];
                }
                count++;
            }

            //4.Form 2 new arrays in a zig-zag pattern as shown below.
            Console.WriteLine(string.Join(' ', array1));
            Console.WriteLine(string.Join(' ', array2));
        }
    }
}
