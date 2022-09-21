using System;
using System.Drawing;
using System.Reflection.Emit;

namespace _09._Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input:
            //  The amount of money John has – the floating-point number in the range[0.00…1, 000.00]
            //	The count of students – integer in the range[0…100]
            //	The price of lightsabers for a single saber – the floating - point number in the range[0.00…100.00]
            //	The price of robes for a single robe – the floating - point number in the range[0.00…100.00]
            //	The price of belts for a single belt – the floating - point number in the range[0.00…100.00]
            double moneyJohn = double.Parse(Console.ReadLine());
            int padawans = int.Parse(Console.ReadLine());
            double lightsabersPrize = double.Parse(Console.ReadLine());
            double robesPrize = double.Parse(Console.ReadLine());
            double beltsPrize = double.Parse(Console.ReadLine());

            //2.Lightsabres sometimes break, so John should buy 10% more (taken from the student's count),
            //  rounded up to the next integer
            //	Every sixth belt is free
            int freeBelts = padawans / 6;

            double neededMoney = Math.Ceiling(padawans + padawans * 10 / 100.0) * lightsabersPrize + padawans * robesPrize + 
                (padawans - freeBelts) * beltsPrize;

            //3.Output:
            //  If the calculated price of the equipment is less or equal to the money John has:
            //     "The money is enough - it would cost {the cost of the equipment}lv."
            //	If the calculated price of the equipment is more than the money John has:
            //     "John will need {neededMoney}lv more."
            if (neededMoney <= moneyJohn)
            {
                Console.WriteLine($"The money is enough - it would cost {neededMoney:F2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {neededMoney - moneyJohn:F2}lv more.");
            }
        }
    }
}
