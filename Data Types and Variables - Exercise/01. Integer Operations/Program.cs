using System;
using System.Collections.Generic;

namespace _01._Integer_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that receives four integer numbers.
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int fourthInt = int.Parse(Console.ReadLine());

            //2.Add first to the second.
            //	Divide(integer) the result of the first operation by the third number.
            //	Multiply the result of the second operation by the fourth number.
            uint result = (uint)(firstInt + secondInt);
            result /= (uint)thirdInt;
            result *= (uint)fourthInt;

            //3.Print the result after the last operation.
            Console.WriteLine(result);
        }
    }
}
