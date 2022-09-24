using System;
using System.Collections.Generic;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace _11._Snowballs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //!!!Constraints:
            // -> The number of snowballs(N) will be an integer in the range[0, 100].
            // -> The snowballSnow is an integer in the range[0, 1000].
            // -> The snowballTime is an integer in the range[1, 500].
            // -> The snowballQuality is an integer in the range[0, 100].

            //1.On the first input line, you will receive N – the number of snowballs.
            int n = int.Parse(Console.ReadLine());

            //	On the next N *3 input lines you will be receiving data about snowballs.
            //  ->	On the first line, you will get the snowballSnow – an integer.
            //  ->	On the second line, you will get the snowballTime – an integer.
            //  ->	On the third line, you will get the snowballQuality – an integer
            //  For each snowball you must calculate its snowballValue by the following formula:
            //  -> (snowballSnow / snowballTime) ^ snowballQuality
            BigInteger highestSnowballValue = BigInteger.MinusOne;
            int highestSnowballSnow = 0;
            int highestSnowballTime = 0;
            int highestSnowballQuality = 0;
            for (int i = 1; i <= n; i++)
            {
                BigInteger snowballValue = 0;

                int snowballSnow = int.Parse(Console.ReadLine());
                int snowballTime = int.Parse(Console.ReadLine());
                int snowballQuality = int.Parse(Console.ReadLine());

                snowballValue = BigInteger.Pow((snowballSnow / snowballTime), snowballQuality);
                if (snowballValue > highestSnowballValue)
                {
                    highestSnowballSnow = snowballSnow;
                    highestSnowballTime = snowballTime;
                    highestSnowballQuality = snowballQuality;
                    highestSnowballValue = snowballValue;
                }
            }

            //2.As output, you must print the highest calculated snowballValue, by the formula, specified above. 
            //  The output format is: 
            //       {snowballSnow} : {snowballTime} = {snowballValue} ({snowballQuality})
            Console.WriteLine($"{highestSnowballSnow} : {highestSnowballTime} = {highestSnowballValue} ({highestSnowballQuality})");
        }
    }
}
