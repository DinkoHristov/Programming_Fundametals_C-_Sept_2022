using System;

namespace _06._Strong_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input
            // number - int
            int number = int.Parse(Console.ReadLine());

            //2.145 is a strong number, because 1! + 4! + 5! = 145.
            int digit = 0;
            int copyNumber = number;
            int sum = 0;
            while (copyNumber != 0)
            {
                int lastDigit = copyNumber % 10;
                digit = lastDigit;
                copyNumber /= 10;

                int factoriel = 1;
                for (int i = 1; i <= digit; i++)
                {
                    factoriel *= i;
                }
                sum += factoriel;
            }

            //3.Print "yes" if the number is strong or "no" if the number is not strong.
            if (number == sum)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
