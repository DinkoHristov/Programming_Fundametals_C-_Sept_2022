using System;

namespace _03._Elevator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.The input holds two lines:
            //  The number of people n
            //  The capacity p of the elevator.
            int n = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            //2.Calculate how many courses will be needed to elevate n persons by using an elevator of the capacity of p persons.
            int fullCourses = n / p;
            int leftPeople = n - (fullCourses * p);
            if (leftPeople != 0)
            {
                if (leftPeople <= p)
                {
                    fullCourses += 1;
                }
                else
                {
                    fullCourses += leftPeople / p;
                }
            }

            Console.WriteLine(fullCourses);
        }
    }
}
