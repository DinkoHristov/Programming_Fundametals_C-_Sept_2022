using System;

namespace _05._Add_and_Subtract
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

            int sumFirstTwo = SumFirstTwo(numberOne, numberTwo);
            int subtractThird = SubtractThird(sumFirstTwo, numberThree);

            Console.WriteLine(subtractThird);
        }

        //2.Method that returns the sum of the first two integers
        static int SumFirstTwo(int numberOne, int numberTwo)
        {
            int sum = numberOne + numberTwo;

            return sum;
        }

        //3.Method that subtracts the third integer from the result of the sum method.
        static int SubtractThird(int sumFirstTwo, int numberThree)
        {
            int subtract = sumFirstTwo- numberThree;

            return subtract;
        }
    }
}
