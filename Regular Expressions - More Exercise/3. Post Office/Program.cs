using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _3._Post_Office
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            string firstPart = input[0];
            string secondPart = input[1];
            string[] thirdPart = input[2].Split(' ', StringSplitOptions.RemoveEmptyEntries);

            //We need to find the word between '$' in first part
            //This will be the beginning for every word in our output
            string pattern = @"(\#|\$|\%|\*|\&)(?<name>[A-Z]+)\1";
            Regex regex = new Regex(pattern);
            Match match = regex.Match(firstPart);

            string name = string.Empty;
            if (match.Success)
            {
                name = match.Groups["name"].Value;
            }
            
            //All letters -> AOTP => (0)A, (1)O, (2)T, (3)P
            List<char> mainLetters = name.ToList();

            //We need to check the second part for numbers
            string numberPattern = @"(?<number>\d+\:\d{2,})";
            Regex numberRegex = new Regex(numberPattern);
            MatchCollection numberMatch = numberRegex.Matches(secondPart);

            List<string> numbers = new List<string>();
            foreach(Match currMatch in numberMatch)
            {
                if(!numbers.Contains(currMatch.ToString()))
                {
                    numbers.Add(currMatch.ToString());
                }
            }

            //We need to find exactly the same ASCII symbol and length in the third part
            List<string> validWords = new List<string>();
            foreach(string currNumber in numbers)
            {
                string[] numberOneAndTwo = currNumber.Split(':');
                int asciiCode = int.Parse(numberOneAndTwo[0]);
                int length = int.Parse(numberOneAndTwo[1]) + 1; //Here we add +1, because we are counting from the zero index

                foreach(string currWord in thirdPart)
                {
                    bool isWordFound = false;
                    if (currWord[0] == (char)asciiCode)
                    {
                        //We found word which starts with the given number
                        if(currWord.Length == length)
                        {
                            //We found our word
                            validWords.Add(currWord);
                            isWordFound = true;
                            break;
                        }
                    }

                    if(isWordFound)
                    {
                        break;
                    }
                }
            }

            //Print all words by the first given letters order
            foreach(char letter in mainLetters)
            {
                foreach(string word in validWords)
                {
                    char firstLetter = word[0];
                    if(firstLetter == letter)
                    {
                        Console.WriteLine(word);
                        break;
                    }
                }
            }
        }
    }
}
