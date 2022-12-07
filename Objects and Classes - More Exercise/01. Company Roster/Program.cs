using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Employee> employees = new List<Employee>();

            for (int i = 0; i < n; i++)
            {
                string[] employeeInfo = Console.ReadLine().Split();
                string name = employeeInfo[0];
                decimal salary = decimal.Parse(employeeInfo[1]);
                string department = employeeInfo[2];

                Employee employee = new Employee(name, salary, department);
                employees.Add(employee);
            }

            List<Employee> finalEmployees = new List<Employee>();
            decimal highestSalary = int.MinValue;
            string finalDepartment = string.Empty;
            for (int i = 0; i < employees.Count; i++)
            {                
                List<Employee> highestPayed = new List<Employee>();
                Employee currentEmployee = employees[i];
                decimal average = 0;
                decimal count = 0;

                foreach (Employee employee in employees)
                {
                    if (employee.Department == currentEmployee.Department)
                    {
                        highestPayed.Add(employee);
                        count++;
                        average += employee.Salary;
                    }
                }

                average /= count;
                if (average > highestSalary)
                {
                    finalEmployees = new List<Employee>();

                    foreach (Employee employee in highestPayed)
                    {
                        finalDepartment = employee.Department;
                        finalEmployees.Add(employee);
                    }
                    highestSalary = average;
                }
            }

            Console.WriteLine($"Highest Average Salary: {finalDepartment}");
            foreach(Employee employee in finalEmployees.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2}");
            }
        }
    }

    public class Employee
    {
        public Employee(string name, decimal salary, string department)
        {
            Name = name;
            Salary = salary;
            Department = department;
        }

        public string Name { get; private set; }

        public decimal Salary { get; set; }

        public string Department { get; set; }
    }
}
