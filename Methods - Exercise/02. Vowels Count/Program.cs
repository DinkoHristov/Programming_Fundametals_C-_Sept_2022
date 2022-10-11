using System;

namespace _02._Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input -> string word
            string word = Console.ReadLine();

            int vowels = VowelsCount(word);
            Console.WriteLine(vowels);
        }

        //2.Method that receives a single string and prints out the number of vowels contained in it.
        static int VowelsCount(string word)
        {
            int vowels = 0;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == 'a' || word[i] == 'A' ||
                    word[i] == 'e' || word[i] == 'E' ||
                    word[i] == 'i' || word[i] == 'I' ||
                    word[i] == 'o' || word[i] == 'O' ||
                    word[i] == 'u' || word[i] == 'U')
                {
                    vowels++;
                }
            }

            return vowels;
        }
    }
}
