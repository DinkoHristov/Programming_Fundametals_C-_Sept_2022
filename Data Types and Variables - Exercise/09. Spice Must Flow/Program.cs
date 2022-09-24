using System;

namespace _09._Spice_Must_Flow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.You will receive a number, representing the starting yield of the source. 
            //1.1.Constraints:
            //    The starting yield will be a positive integer within the range [0 … 2 147 483 647]
            int startingYield = int.Parse(Console.ReadLine());

            //2.Task:
            //  StartingYield drops every day by 10.
            //  A source is profitable when yield >= 100, when is < 100 spices are exxpected in a day, abandon the source.
            //  The mining crew consumes 26 spices every day and additional 26 after the mine is exhausted.
            int extractedSpice = 0;
            int days = 0;
            int workersConsume = 26;
            while (startingYield >= 100)
            {
                days++;
                extractedSpice += startingYield - workersConsume;
                startingYield -= 10;
                if (startingYield < 100)
                {
                    extractedSpice -= workersConsume;
                }
            }

            //3.Print on the console on two separate lines:
            //  How many days the mine has operated and the total amount of spice extracted.
            Console.WriteLine(days);
            Console.WriteLine(extractedSpice);
        }
    }
}
