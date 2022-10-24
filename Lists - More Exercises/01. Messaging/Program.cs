using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Messaging
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - 2 lines:
            //1.1 First line -> List of int numbers
            List<int> numbers = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToList();

            //1.2 Second line -> string
            string input = Console.ReadLine();

            //2.Sum current number digits.
            string message = string.Empty;

            List<string> newMessage = new List<string>();
            for (int i = 0; i < input.Length; i++)
            {
                string currentElement = input[i].ToString();
                newMessage.Add(currentElement);
            }

            for (int i = 0; i < numbers.Count; i++)
            {
                int currentNumber = numbers[i];
                int sum = 0;

                while (currentNumber > 0)
                {
                    int currentDigit = currentNumber % 10;
                    sum += currentDigit;
                    currentNumber /= 10;
                }

                //3.Check to what index of the given string correspond out sum of digits.
                bool isCharAdded = false;
                for (int j = 0; j < newMessage.Count; j++)
                {
                    string currentChar = newMessage[j];
                    int index = j;

                    if (sum >= newMessage.Count)
                    {
                        sum -= newMessage.Count;
                        j = -1;
                        continue;
                    }

                    if (sum == index)
                    {
                        isCharAdded = true;
                        message += currentChar;
                        newMessage.RemoveAt(index);
                        break;
                    }

                    if (isCharAdded)
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(message);
        }
    }
}
