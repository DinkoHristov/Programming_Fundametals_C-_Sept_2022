using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Student_Academy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < n; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (!students.ContainsKey(studentName))
                {
                    students.Add(studentName, new List<double>());
                    students[studentName].Add(grade);
                }
                else
                {
                    students[studentName].Add(grade);
                }
            }

            foreach (var student in students)
            {
                double average = 0;
                foreach (var grade in student.Value)
                {
                    average += grade;
                }

                average /= student.Value.Count;
                if (average < 4.50)
                {
                    students.Remove(student.Key);
                    continue;
                }
                Console.WriteLine($"{student.Key} -> {average:F2}");
            }
        }
    }
}