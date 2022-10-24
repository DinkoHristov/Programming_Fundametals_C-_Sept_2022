using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - List<int> wagons
            List<int> wagons = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //2.Input - int max capacity of the wagon
            int maxCapacity = int.Parse(Console.ReadLine());

            //3.Until "end" -> string command
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];

                //4.Add new wagon to our List of wagons
                if (commandType == "Add")
                {
                    int passengers = int.Parse(commandArgs[1]);
                    wagons.Add(passengers);
                }
                //5.Check if we have a wagon with enough capacity for our passengers
                //  If we have then we add our passengers there.
                else if (commandType != "Add")
                {
                    int passengers = int.Parse(commandArgs[0]);

                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentWagon = wagons[i];
                        bool isWagonFound = false;

                        if ((currentWagon + passengers) <= maxCapacity)
                        {
                            wagons[i] += passengers;
                            isWagonFound = true;
                        }

                        if (isWagonFound)
                        {
                            break;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
