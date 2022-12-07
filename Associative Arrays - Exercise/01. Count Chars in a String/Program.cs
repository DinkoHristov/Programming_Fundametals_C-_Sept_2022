using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Count_Chars_in_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> words = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<char, int> countChars = new Dictionary<char, int>();

            for(int i = 0; i < words.Count; i++)
            {
                string currentWord = words[i];

                for(int j = 0; j < currentWord.Length; j++)
                {
                    char currentLetter = (char)currentWord[j];

                    if (countChars.ContainsKey(currentLetter))
                    {
                        countChars[currentLetter] += 1;
                    }
                    else
                    {
                        countChars.Add(currentLetter, 1);
                    }
                }
            }

            foreach(var letter in countChars)
            {
                Console.WriteLine($"{letter.Key} -> {letter.Value}");
            }
        }
    }
}
