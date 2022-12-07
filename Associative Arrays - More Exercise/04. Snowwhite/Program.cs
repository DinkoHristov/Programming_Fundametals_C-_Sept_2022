using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> dwarves = new Dictionary<string, int>();

            string command = string.Empty;
            while((command = Console.ReadLine()) != "Once upon a time")
            {
                //"{dwarfName} <:> {dwarfHatColor} <:> {dwarfPhysics}"
                string[] commandArgs = command.Split(" <:> ");
                string dwarfName = commandArgs[0];
                string dwarfHatColor = commandArgs[1];
                int dwarfPhysics = int.Parse(commandArgs[2]);

                string ID = $"({dwarfHatColor}) {dwarfName}";

                if(dwarves.ContainsKey(ID))
                {
                    int oldPhysics = dwarves[ID];
                    if(dwarfPhysics > oldPhysics)
                    {
                        dwarves[ID] = dwarfPhysics;
                    }
                }
                else
                {
                    dwarves.Add(ID, dwarfPhysics);
                }
            }

           
            foreach(var dwarf in dwarves
                .OrderByDescending(physics => physics.Value)
                .ThenByDescending(hats => dwarves.Where(hat => hat.Key.Split()[0] == hats.Key.Split()[0])
                .Count()))
            {
                Console.WriteLine($"{dwarf.Key} <-> {dwarf.Value}");
            }
        }
    }
}
