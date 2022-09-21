using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.ConstrainedExecution;

namespace _11._Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input:
            //  On the first line, you will receive integer N – the count of orders the shop will receive.
            //	For each order you will receive the following information:
            //      Price per capsule -the floating - point number in the range[0.00…1000.00]
            //      Days – integer in the range[1…31]
            //      Capsules count - integer in the range[0…2000]
            int orders = int.Parse(Console.ReadLine());
            double totalPrize = 0;
            for (int i = 1; i <= orders; i++)
            {
                double coffeePrize = 0;
                double prize = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int capsulesCount = int.Parse(Console.ReadLine());

                coffeePrize = prize * days * capsulesCount;
                totalPrize += coffeePrize;
                Console.WriteLine($"The price for the coffee is: ${coffeePrize:F2}");
            }

            Console.WriteLine($"Total: ${totalPrize:F2}");
        }
    }
}
