using System;
using System.Collections.Generic;
using System.Text;

namespace _07._String_Explosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            List<char> inputChars = new List<char>();
            foreach(char currChar in input)
            {
                inputChars.Add(currChar);
            }

            int bombPower = 0;
            //abv>1>1>2>2asdasd
            for (int i = 0; i < inputChars.Count; i++)
            {
                char currChar = inputChars[i];

                if(bombPower > 0 && currChar != '>')
                {
                    inputChars.RemoveAt(i);
                    bombPower--;
                    i--;
                }
                else if(currChar == '>')
                {
                    bombPower += int.Parse(inputChars[i + 1].ToString());
                }
            }

            Console.WriteLine(string.Join("", inputChars));
        }
    }
}
