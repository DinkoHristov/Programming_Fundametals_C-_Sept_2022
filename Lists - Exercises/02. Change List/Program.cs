using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - List<int> numbers
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //2.Input - string command to manipulate the List
            string command = string.Empty;

            while((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];

                if (commandType == "Delete")
                {
                    int element = int.Parse(commandArgs[1]);

                    numbers.RemoveAll(x => x == element);
                }
                else if (commandType == "Insert")
                {
                    int element = int.Parse(commandArgs[1]);
                    int position = int.Parse(commandArgs[2]);

                    numbers.Insert(position, element);
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
