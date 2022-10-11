using System;

namespace _01._Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.A train has an **n** number of wagons (integer, received as input).
            int wagons = int.Parse(Console.ReadLine());

            //2.On the next n lines, you will receive the number of people that are going to get on each wagon.
            int[] train = new int[wagons];
            int totalPeople = 0;
            for (int i = 0; i < wagons; i++)
            {
                int people = int.Parse(Console.ReadLine());
                train[i] = people;
                totalPeople += people;
            }

            //3.Print out the number of passengers in each wagon followed by the total number of passengers on the train.
            Console.WriteLine(string.Join(' ', train));
            Console.WriteLine(totalPeople);
        }
    }
}
