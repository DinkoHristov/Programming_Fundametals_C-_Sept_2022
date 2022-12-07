using System;
using System.Collections.Generic;

namespace _05._Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "end")
            {
                string[] commandArgs = command.Split(" : ");
                string courseName = commandArgs[0];
                string studentName = commandArgs[1];

                if (!courses.ContainsKey(courseName))
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(studentName);
                }
                else
                {
                    courses[courseName].Add(studentName);
                }
            }

            foreach(var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");

                foreach(string student in course.Value)
                {
                    Console.WriteLine($"-- {student}");
                }
            }
        }
    }
}
