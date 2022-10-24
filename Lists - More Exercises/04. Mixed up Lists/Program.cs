using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Mixed_up_Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - 2 lines:
            //1.1 First line -> list of numbers one
            List<int> listOne = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //1.2 Second line -> list of nubmers two
            List<int> listTwo = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //2.Check which list is bigger (there always will be a list with 2 more elements)
            //2.1 Find this list and take this elements.
            int[] constraints = new int[2];

            if (listOne.Count > listTwo.Count)
            {
                constraints[0] = listOne[listOne.Count - 2];
                constraints[1] = listOne[listOne.Count - 1];
                listOne.RemoveAt(listOne.Count - 2);
                listOne.RemoveAt(listOne.Count - 1);
            }
            else
            {
                listTwo.Reverse();
                constraints[0] = listTwo[listTwo.Count - 2];
                constraints[1] = listTwo[listTwo.Count - 1];
                listTwo.RemoveAt(listTwo.Count - 2);
                listTwo.RemoveAt(listTwo.Count - 1);
            }

            //3.Sort constraints => index 0 will be with smaller index 1 with bigger number.
            if (constraints[0] > constraints[1])
            {
                int temp = constraints[0];
                constraints[0] = constraints[1];
                constraints[1] = temp;
            }

            //4.Add all elements to new mixed list
            List<int> mixedList = new List<int>();
            for (int i = 0; i < listOne.Count; i++)
            {
                mixedList.Add(listOne[i]);
                mixedList.Add(listTwo[listTwo.Count - 1 - i]);
            }

            
            //5.Take all numbers from our mixedList which are between the constraints.
            List<int> constraintsList = new List<int>();

            for (int i = 0; i < mixedList.Count; i++)
            {
                int currentNumber = mixedList[i];

                if (currentNumber > constraints[0] && currentNumber < constraints[1])
                {
                    constraintsList.Add(currentNumber);
                }
            }

            //6.Print constraint List ordered by Ascending and separated by a space.
            Console.WriteLine(string.Join(" ", constraintsList.OrderBy(x => x)));
        }
    }
}
