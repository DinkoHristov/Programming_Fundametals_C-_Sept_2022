using System;

namespace _05._Messages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string word = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    word += " ";
                }
                else if (number == 1)
                {

                }
                else if (number == 2)
                {
                    word += "a";
                }
                else if (number == 22)
                {
                    word += "b";
                }
                else if (number == 222)
                {
                    word += "c";
                }
                else if (number == 3)
                {
                    word += "d";
                }
                else if (number == 33)
                {
                    word += "e";
                }
                else if (number == 333)
                {
                    word += "f";
                }
                else if (number == 4)
                {
                    word += "g";
                }
                else if (number == 44)
                {
                    word += "h";
                }
                else if (number == 444)
                {
                    word += "i";
                }
                else if (number == 5)
                {
                    word += "j";
                }
                else if (number == 55)
                {
                    word += "k";
                }
                else if (number == 555)
                {
                    word += "l";
                }
                else if (number == 6)
                {
                    word += "m";
                }
                else if (number == 66)
                {
                    word += "n";
                }
                else if (number == 666)
                {
                    word += "o";
                }
                else if (number == 7)
                {
                    word += "p";
                }
                else if (number == 77)
                {
                    word += "q";
                }
                else if (number == 777)
                {
                    word += "r";
                }
                else if (number == 7777)
                {
                    word += "s";
                }
                else if (number == 8)
                {
                    word += "t";
                }
                else if (number == 88)
                {
                    word += "u";
                }
                else if (number == 888)
                {
                    word += "v";
                }
                else if (number == 9)
                {
                    word += "w";
                }
                else if (number == 99)
                {
                    word += "x";
                }
                else if (number == 999)
                {
                    word += "y";
                }
                else if (number == 9999)
                {
                    word += "z";
                }
            }

            Console.WriteLine(word);
        }
    }
}
