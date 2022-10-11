using System;

namespace _01._Smallest_of_Three_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> 3 lines:
            //1.1 First line -> int numberOne
            //1.2 Second line -> int numberTwo
            //1.3 Third line -> int numberThree
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            PrintSmallestNumber(numberOne, numberTwo, numberThree);
        }

        //2.Method that prints out the smallest of three integer numbers.
        static void PrintSmallestNumber(int numberOne, int numberTwo, int numberThree)
        {
            if (numberOne < numberTwo && numberOne < numberThree)
            {
                Console.WriteLine(numberOne);
            }
            else if (numberTwo < numberOne && numberTwo < numberThree)
            {
                Console.WriteLine(numberTwo);
            }
            else
            {
                Console.WriteLine(numberThree);
            }
        }
    }
}
