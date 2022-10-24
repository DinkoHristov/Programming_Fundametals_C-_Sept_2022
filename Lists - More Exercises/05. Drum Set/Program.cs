using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -_ 2 lines:
            //1.1 First line -> double savings
            //1.2 Second line -> int drum set - sequence of integers, separated by space
            double savings = double.Parse(Console.ReadLine());
            List<int> drumSet = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //2.We will store initial drum set here, and update it every time when they are hit
            List<int> updatedDrums = new List<int>();
            for (int i = 0; i < drumSet.Count; i++)
            {
                int currentDrum = drumSet[i];
                updatedDrums.Add(currentDrum);
            }

            //3.Until the command "Hit it again, Gabsy!" we will be receiving integers - hit power on drums
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Hit it again, Gabsy!")
            {
                //This is the hit power with which Gabsy hits the drums
                int hitPower = int.Parse(command);

                //4.We are reaching every drum
                for (int i = 0; i < updatedDrums.Count; i++)
                {
                    int index = i;
                    int currentDrum = updatedDrums[i];
                    int drumPower = currentDrum - hitPower;

                    if (drumPower <= 0)
                    {
                        //5.Can Gabsy afford to buy a new drum
                        double drumValue = (drumSet[index] * 3);

                        if (drumValue <= savings)
                        {
                            savings -= drumValue;
                            drumPower = drumSet[index];
                        }
                        //5.1 Is she can't afford to buy a new drum, it will be removed from the drum set
                        else
                        {
                            updatedDrums.RemoveAt(index);
                            drumSet.RemoveAt(index);
                            i--;
                            continue;
                        }
                    }

                    updatedDrums.RemoveAt(index);
                    updatedDrums.Insert(index, drumPower);
                }
            }

            //6.Output -> 2 lines:
            //6.1 First line -> print each drum one the drum set
            //6.2 Second line -> print Gabsy's left money
            Console.WriteLine(string.Join(" ", updatedDrums));
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}