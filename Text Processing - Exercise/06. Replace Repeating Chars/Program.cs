using System;
using System.Text;

namespace _06._Replace_Repeating_Chars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder replacedText = new StringBuilder();

            string text = Console.ReadLine();

            replacedText.Append(text);
            for(int i = 0; i < replacedText.Length; i++)
            {
                char currentChar = replacedText[i];
                for(int j = i + 1; j < replacedText.Length; j++)
                {
                    char nextChar = replacedText[j];
                    if(currentChar == nextChar)
                    {
                        replacedText.Remove(j, 1);
                        j--;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            Console.WriteLine(replacedText);
        }
    }
}
