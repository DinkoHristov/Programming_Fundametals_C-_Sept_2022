using System;

namespace _01._The_Hunting_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberDays = int.Parse(Console.ReadLine());
            int players = int.Parse(Console.ReadLine());
            decimal groupsEnergy = decimal.Parse(Console.ReadLine());

            decimal waterDayly = decimal.Parse(Console.ReadLine());
            decimal foodDayly = decimal.Parse(Console.ReadLine());

            decimal totalWater = (numberDays * players * waterDayly);
            decimal totalFood = (numberDays * players * foodDayly);

            int daysCount = 0;
            bool runOutOfEnergy = false;
            for (int i = 1; i <= numberDays; i++)
            {
                decimal energyLost = decimal.Parse(Console.ReadLine());

                if (energyLost <= groupsEnergy)
                {
                    groupsEnergy -= energyLost;
                    daysCount++;
                }
                else
                {
                    runOutOfEnergy = true;
                    break;
                }

                if (daysCount % 2 == 0)
                {
                    groupsEnergy += groupsEnergy * 0.05m;
                    totalWater -= totalWater * 30 / 100m;
                }

                if (daysCount % 3 == 0)
                {
                    groupsEnergy += groupsEnergy * 0.10m;
                    totalFood -= totalFood / players;
                }

                if (groupsEnergy <= 0)
                {
                    runOutOfEnergy = true;
                    break;
                }
            }

            if (!runOutOfEnergy)
            {
                Console.WriteLine($"You are ready for the quest. You will be left with - {groupsEnergy:F2} energy!");
            }
            else
            {
                Console.WriteLine($"You will run out of energy. You will be left with {totalFood:F2} food and {totalWater:F2} water.");
            }
        }
    }
}
