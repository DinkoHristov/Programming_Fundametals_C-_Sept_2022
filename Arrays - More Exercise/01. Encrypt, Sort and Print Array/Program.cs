using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Security;

namespace _01._Encrypt__Sort_and_Print_Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program that reads a sequence of strings from the console. Encrypt every string by summing:
            //  -> The code of each vowel multiplied by the string length
            //  -> The code of each consonant divided by the string length
            int namesCount = int.Parse(Console.ReadLine());

            //2.Sort the number sequence in ascending order and print it on the console.
            //  On the first line, you will always receive the number of strings you have to read.
            string[] names = new string[namesCount];
            int[] numbers = new int[namesCount];
            for (int i = 0; i < namesCount; i++)
            {
                names[i] = Console.ReadLine();

                string currentName = names[i];
                int sum = 0;

                for (int j = 0; j < currentName.Length; j++)
                {
                    int vowels = 0;
                    int consonant = 0;

                    if (currentName[j] == 'a' || currentName[j] == 'e' || currentName[j] == 'i' ||
                        currentName[j] == 'o' || currentName[j] == 'u' ||
                        currentName[j] == 'A' || currentName[j] == 'E' || currentName[j] == 'I' ||
                        currentName[j] == 'O' || currentName[j] == 'U')
                    {
                        vowels += (int)(currentName[j] * currentName.Length);
                        sum += vowels;
                    }
                    else
                    {
                        consonant += (int)((double)currentName[j] / currentName.Length);
                        sum += consonant;
                    }
                }

                numbers[i] = sum;
            }

            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
