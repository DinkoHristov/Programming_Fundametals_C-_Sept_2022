using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Finish")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];

                if (commandType == "Add")
                {
                    int value = int.Parse(commandArgs[1]);

                    numbers.Add(value);
                }
                else if (commandType == "Remove")
                {
                    int value = int.Parse(commandArgs[1]);

                    if (numbers.Contains(value))
                    {
                        numbers.Remove(value);
                    }
                }
                else if (commandType == "Replace")
                {
                    int value = int.Parse(commandArgs[1]);
                    int replacement = int.Parse(commandArgs[2]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentNumber = numbers[i];

                        if (currentNumber == value)
                        {
                            numbers[i] = replacement;
                            break;
                        }
                    }
                }
                else if (commandType == "Collapse")
                {
                    int value = int.Parse(commandArgs[1]);

                    for (int i = 0; i < numbers.Count; i++)
                    {
                        int currentNumber = numbers[i];

                        if (currentNumber < value)
                        {
                            numbers.RemoveAt(i);
                            i--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
