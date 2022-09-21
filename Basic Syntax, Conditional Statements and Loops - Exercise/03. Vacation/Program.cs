using System;
using System.Diagnostics;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input:
            //  A count of people, which are going on vacation.
            //	Type of the group(Students, Business, or Regular).
            //  The day of the week which the group will stay(Friday, Saturday, or Sunday).
            int people = int.Parse(Console.ReadLine());
            string groupType = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            //2.            Friday	Saturday	Sunday
            // Students     8.45    9.80        10.46
            // Business     10.90   15.60       16
            // Regular      15      20          22.50
            double prize = 0;
            if (dayOfWeek == "Friday")
            {
                if (groupType == "Students")
                {
                    prize = 8.45;
                }
                else if (groupType == "Business")
                {
                    prize = 10.90;
                }
                else if (groupType == "Regular")
                {
                    prize = 15;
                }
            }
            else if (dayOfWeek == "Saturday")
            {
                if (groupType == "Students")
                {
                    prize = 9.80;
                }
                else if (groupType == "Business")
                {
                    prize = 15.60;
                }
                else if (groupType == "Regular")
                {
                    prize = 20;
                }
            }
            else if (dayOfWeek == "Sunday")
            {
                if (groupType == "Students")
                {
                    prize = 10.46;
                }
                else if (groupType == "Business")
                {
                    prize = 16;
                }
                else if (groupType == "Regular")
                {
                    prize = 22.50;
                }
            }
            double totalPrize = people * prize;

            //3.For Students, if the group is 30 or more people, you should reduce the total price by 15%
            //	For Business, if the group is 100 or more people, 10 of the people stay for free.
            //	For Regular, if the group is between 10 and 20  people(both inclusively), reduce the total price by 5 %
            if (groupType == "Students" && people >= 30)
            {
                totalPrize -= totalPrize * 15 / 100;
            }
            if (groupType == "Business" && people >= 100)
            {
                totalPrize -= 10 * prize;
            }
            if (groupType == "Regular" && people >= 10 && people <= 20)
            {
                totalPrize -= totalPrize * 5 / 100;
            }

            //4."Total price: {price}" 
            Console.WriteLine($"Total price: {totalPrize:F2}");
        }
    }
}
