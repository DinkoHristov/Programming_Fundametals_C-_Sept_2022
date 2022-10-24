using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._List_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - List<int> numbers
            List<int> inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //2.Until "End" we will receive a command
            string command = string.Empty;

            while((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split();
                string commandType = commandArgs[0];

                if (commandType == "Add")
                {
                    int number = int.Parse(commandArgs[1]);

                    inputNumbers.Add(number);
                }
                else if (commandType == "Insert")
                {
                    int number = int.Parse(commandArgs[1]);
                    int index = int.Parse(commandArgs[2]);

                    if (index < 0 || index > inputNumbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    inputNumbers.Insert(index, number);
                }
                else if (commandType == "Remove")
                {
                    int index = int.Parse(commandArgs[1]);

                    if (index < 0 || index > inputNumbers.Count)
                    {
                        Console.WriteLine("Invalid index");
                        continue;
                    }

                    inputNumbers.RemoveAt(index);
                }
                else if (commandType == "Shift")
                {
                    string commandDirection = commandArgs[1];

                    if (commandDirection == "left")
                    {
                        int count = int.Parse(commandArgs[2]);

                        for (int i = 0; i < count; i++)
                        {
                            int currentNumber = inputNumbers[i];
                            inputNumbers.Remove(currentNumber);
                            inputNumbers.Add(currentNumber);
                            i--;
                            count--;
                        }
                    }
                    else if (commandDirection == "right")
                    {
                        int count = int.Parse(commandArgs[2]);

                        for (int i = 0; i < count; i++)
                        {
                            int currentNumber = inputNumbers[inputNumbers.Count - 1];
                            inputNumbers.Remove(currentNumber);
                            inputNumbers.Insert(i, currentNumber);
                            i--;
                            count--;
                        }
                    }
                }
            }

            Console.WriteLine(string.Join(" ", inputNumbers));
        }
    }
}
