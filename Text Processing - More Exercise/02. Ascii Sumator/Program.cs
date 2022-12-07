using System;
using System.Text;

namespace _02._Ascii_Sumator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstBoundChar = char.Parse(Console.ReadLine());
            char secondBoundChar = char.Parse(Console.ReadLine());
            string randomText = Console.ReadLine();

            int asciCharSum = 0;
            foreach(char currLetter in randomText)
            {
                if(currLetter > firstBoundChar && currLetter < secondBoundChar)
                {
                    int asciCode = (int)currLetter;
                    asciCharSum += asciCode;
                }
            }

            Console.WriteLine(asciCharSum);
        }
    }
}
