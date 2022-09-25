using System;

namespace _03._Floating_Equality
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.You will receive two lines, each containing a floating-point number
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            //2.Your task is to compare the values of the two numbers.
            // !compares floating-point numbers (double) with precision eps = 0.000001
            double eps = 0.000001;
            double difference = Math.Abs(a - b);
            bool isEqual = false;
            if (difference < eps)
            {
                isEqual = true;
            }

            Console.WriteLine(isEqual);
        }
    }
}
