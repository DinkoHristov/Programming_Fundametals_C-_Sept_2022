using System;

namespace _01._Sort_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program that receives three real numbers and sorts them in descending order.
            //  Print each number on a new line.
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());
            int numberThree = int.Parse(Console.ReadLine());

            int firstNum = 0;
            int secondNum = 0;
            int thirdNum = 0;

            if (numberOne > numberTwo && numberOne > numberThree)
            {
                firstNum = numberOne;
                if (numberTwo > numberThree)
                {
                    secondNum = numberTwo;
                    thirdNum = numberThree;
                }
                else
                {
                    secondNum = numberThree;
                    thirdNum = numberTwo;
                }
            }
            else if (numberTwo > numberOne && numberTwo > numberThree)
            {
                firstNum = numberTwo;
                if (numberOne > numberThree)
                {
                    secondNum = numberOne;
                    thirdNum = numberThree;
                }
                else
                {
                    secondNum = numberThree;
                    thirdNum = numberOne;
                }
            }
            else if (numberThree > numberOne && numberThree > numberTwo)
            {
                firstNum = numberThree;
                if (numberOne > numberTwo)
                {
                    secondNum = numberOne;
                    thirdNum = numberTwo;
                }
                else
                {
                    secondNum = numberTwo;
                    thirdNum = numberOne;
                }
            }

            Console.WriteLine(firstNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(thirdNum);
        }
    }
}
