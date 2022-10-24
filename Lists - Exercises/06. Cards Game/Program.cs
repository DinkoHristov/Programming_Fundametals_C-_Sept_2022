using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - 2 lines:
            //1.1 First line -> List<int> firstHand
            List<int> firstHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            //1.2 Second line -> List<int> secondHand
            List<int> secondHand = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //2.Check each iteration for bigger card
            //2.1.This is deck One
            bool isFirstLost = false;
            bool isSecondLost = false;

            for (int i = 0; i < firstHand.Count; i++)
            {
                int deckOneCard = firstHand[i];
                //2.2.This is deck two
                for (int j = 0; j < secondHand.Count; j++)
                {
                    int deckTwoCard = secondHand[j];

                    if (deckOneCard > deckTwoCard)
                    {
                        firstHand.Add(deckOneCard);
                        firstHand.Add(deckTwoCard);
                        firstHand.RemoveAt(i);
                        secondHand.RemoveAt(j);
                        break;
                    }
                    else if (deckTwoCard > deckOneCard)
                    {
                        secondHand.Add(deckTwoCard);
                        secondHand.Add(deckOneCard);
                        firstHand.RemoveAt(i);
                        secondHand.RemoveAt(j);
                        break;
                    }
                    else
                    {
                        firstHand.Remove(deckOneCard);
                        secondHand.Remove(deckTwoCard);
                        break;
                    }
                }

                if (secondHand.Count == 0)
                {
                    isSecondLost = true;
                    break;
                }
                else if (firstHand.Count == 0)
                {
                    isFirstLost = true;
                    break;
                }

                i--;
            }

            if (isFirstLost)
            {
                Console.WriteLine($"Second player wins! Sum: {secondHand.Sum()}");
            }
            else
            {
                Console.WriteLine($"First player wins! Sum: {firstHand.Sum()}");
            }
        }
    }
}
