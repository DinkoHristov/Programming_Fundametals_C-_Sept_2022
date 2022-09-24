using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;

namespace _08._Beer_Kegs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.You will receive 3 * n lines. Each group of lines will be on a new line:
            //	  First – model – string.
            //	  Second –radius – floating - point number
            //	  Third – height – integer number
            //1.1.Constraints:
            //  n will be in the interval[1…10]
            //	The radius will be a floating-point number in the interval[1…3.402823E+38]
            //	The height will be an integer in the interval[1…2147483647]
            int n = int.Parse(Console.ReadLine());
            float biggestVolume = float.MinValue;
            string biggestKeg = string.Empty;
            for (int i = 1; i <= n; i++)
            {
                string model = Console.ReadLine();
                float radius = float.Parse(Console.ReadLine());
                int height = int.Parse(Console.ReadLine());

                //2.Calculate the volume using the following formula: π * r^2 * h. 
                float volume = (float)Math.PI * radius * radius * height;
                if (volume > biggestVolume)
                {
                    biggestKeg = model;
                    biggestVolume = volume;
                }
            }

            //3.Print the model of the biggest keg.
            Console.WriteLine(biggestKeg);
        }
    }
}
