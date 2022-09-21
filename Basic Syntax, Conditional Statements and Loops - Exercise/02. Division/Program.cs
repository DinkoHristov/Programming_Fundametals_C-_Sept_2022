using System;

namespace _02._Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - int
            int number = int.Parse(Console.ReadLine());

            //2.If the number is divisible by both 2, 3, and 6, you should print only the division by 6 only. 
            //	If a number is divisible by 2 and 10, you should print the division by 10.
            if (number % 10 == 0)
            {
                Console.WriteLine("The number is divisible by 10");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("The number is divisible by 7");
            }
            else if (number % 6 == 0)
            {
                Console.WriteLine("The number is divisible by 6");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("The number is divisible by 3");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is divisible by 2");
            }
            else
            {
                Console.WriteLine("Not divisible");
            }
            //3.If the number is not divisible by any of the given numbers print "Not divisible".
            //  Otherwise, print "The number is divisible by {number}".
        }
    }
}
