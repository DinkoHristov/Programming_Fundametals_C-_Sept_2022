using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Treasure_Finder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] keys = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string input = string.Empty;
            while((input = Console.ReadLine()) != "find")
            {
                List<char> inputChars = input.ToList();
                string treasureWord = string.Empty;

                while (inputChars.Count > 0)
                {
                    foreach (int currKey in keys)
                    {
                        foreach(char currLetter in inputChars)
                        {
                            //We have to decrease current letter with current key
                            char newLetter =(char)((int)currLetter - currKey);
                            treasureWord += newLetter;
                            inputChars.RemoveAt(0);
                            break;
                        }
                    }
                }

                int treasureTypeStartIndex = treasureWord.IndexOf('&');
                int treasureTypeLastIndex = treasureWord.LastIndexOf('&');
                string treasureType = treasureWord.Substring(treasureTypeStartIndex + 1, 
                    treasureTypeLastIndex- treasureTypeStartIndex - 1);
                int treasureCoordinateStartIndex = treasureWord.IndexOf('<');
                int treasureCoordinateLastIndex = treasureWord.IndexOf('>');
                string treasureCoordinate = treasureWord.Substring(treasureCoordinateStartIndex + 1,
                    treasureCoordinateLastIndex - treasureCoordinateStartIndex - 1);

                Console.WriteLine($"Found {treasureType} at {treasureCoordinate}");
            }
        }
    }
}
