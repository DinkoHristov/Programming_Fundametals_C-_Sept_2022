using System;

namespace _01._Ages
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input - age (int)
            int age = int.Parse(Console.ReadLine());

            //2.0-2 – baby
            //	3 - 13 – child
            //	14 - 19 – teenager
            //	20 - 65 – adult
            //	>= 66 – elder
            //	All the values are inclusive.
            if (age >= 0 && age <= 2)
            {
                Console.WriteLine("baby");
            }
            else if (age >= 3 && age <= 13)
            {
                Console.WriteLine("child");
            }
            else if (age >= 14 && age <= 19)
            {
                Console.WriteLine("teenager");
            }
            else if (age >= 20 && age <= 65)
            {
                Console.WriteLine("adult");
            }
            else if (age >= 66)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
