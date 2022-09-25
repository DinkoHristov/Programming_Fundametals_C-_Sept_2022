using System;
using static System.Net.Mime.MediaTypeNames;

namespace _06._Balanced_Brackets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input:
            //	-> On the first line, you will receive n – the number of lines, which will follow
            //	-> On the next n lines, you will receive "(", ")" or another string
            int n = int.Parse(Console.ReadLine());

            bool isOpened = false;
            bool isBalanced = true;

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (input == "(")
                {
                    if (!isOpened)
                    {
                        isOpened = true;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }

                if (input == ")")
                {
                    if (isOpened)
                    {
                        isOpened = false;
                    }
                    else
                    {
                        isBalanced = false;
                    }
                }
            }

            //2.Output:
            // -> You have to print "BALANCED" if the parentheses are balanced and "UNBALANCED" otherwise.
            if (isBalanced && !isOpened)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
