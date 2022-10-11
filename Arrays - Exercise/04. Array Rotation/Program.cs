using System;
using System.Linq;

namespace _04._Array_Rotation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that receives an array and several rotations that you have to perform.
            int[] array = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();
            int rotations = int.Parse(Console.ReadLine());

            //2.The rotations are done by moving the first element of the array from the front to the back.
            for (int i = 0; i < rotations; i++)
            {
                int temp = array[0];
                for (int j = 0; j < array.Length - 1; j++)
                {
                    array[j] = array[j + 1];
                }
                array[array.Length - 1] = temp;
            }

            //3.Print the resulting array.
            Console.WriteLine(string.Join(' ', array));
        }
    }
}
