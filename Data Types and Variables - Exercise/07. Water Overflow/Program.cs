using System;
using static System.Net.Mime.MediaTypeNames;
using System.Collections.Generic;

namespace _07._Water_Overflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.The input will be on two lines:
            //	On the first line, you will receive n – the number of lines, which will follow
            //	On the next n lines – you receive quantities of water, which you have to pour into the tank
            int n = int.Parse(Console.ReadLine());

            //  Constraints:
            //	n will be in the interval[1…20]
            //	liters will be in the interval[1…1000]
            //  water tank with a capacity of 255 liters
            int waterTank = 255;
            int waterSum = 0;
            for (int i = 1; i <= n; i++)
            {
                int liters = int.Parse(Console.ReadLine());
                if (liters <= waterTank)
                {
                    waterSum += liters;
                    waterTank -= liters;
                }
                //2.Every time you do not have enough capacity in the tank to pour the given liters, print:
                //  Insufficient capacity!
                //  On the last line, print only the liters in the tank.
                else
                {
                    Console.WriteLine("Insufficient capacity!");
                }
            }

            Console.WriteLine(waterSum);
        }
    }
}
