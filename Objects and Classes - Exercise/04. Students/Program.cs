using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Students
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentsCount = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student>();

            for (int i = 1; i <= studentsCount; i++)
            {
                string[] studentsInfo = Console.ReadLine().Split();

                string firstName = studentsInfo[0];
                string lastName = studentsInfo[1];
                double grade = double.Parse(studentsInfo[2]);

                Student student = new Student(firstName, lastName, grade);
                students.Add(student);

            }

            foreach (Student student in students.OrderByDescending(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade:F2}");
            }

        }
    }

    public class Student
    {

        public Student(string firstName, string lastName, double grade)
        {
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public double Grade { get; set; }
    }
}
