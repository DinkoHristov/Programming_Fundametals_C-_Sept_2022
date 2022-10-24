using System;
using System.Collections.Generic;

namespace _03._House_Party
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - int commandsNumber - number of commands we will receive
            int commandsNumber = int.Parse(Console.ReadLine());

            //2.Check if the person is in the list
            List<string> names = new List<string>();
            string command = string.Empty;

            for (int i = 1; i <= commandsNumber; i++)
            {
                command = Console.ReadLine();
                string[] commandArgs = command.Split();
                string name = commandArgs[0];
                string isGoing = commandArgs[2];

                if (isGoing != "not")
                {
                    if (names.Contains(name))
                    {
                        Console.WriteLine($"{name} is already in the list!");
                    }
                    else
                    {
                        names.Add(name);
                    }
                }
                else
                {
                    if (names.Contains(name))
                    {
                        names.Remove(name);
                    }
                    else
                    {
                        Console.WriteLine($"{name} is not in the list!");
                    }
                }
            }

            if (names.Count != 0)
            {
                Console.WriteLine(string.Join(Environment.NewLine, names));
            }
        }
    }
}
