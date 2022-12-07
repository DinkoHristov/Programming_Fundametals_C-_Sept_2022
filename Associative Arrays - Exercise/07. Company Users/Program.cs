using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Company_Users
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            Dictionary<string, List<string>> companies = new Dictionary<string, List<string>>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] commandArgs = command.Split(" -> ");
                string companyName = commandArgs[0];
                string employeeId = commandArgs[1];

                if(!companies.ContainsKey(companyName))
                {
                    companies.Add(companyName, new List<string>());
                    companies[companyName].Add(employeeId);
                }
                else
                {
                    bool isExist = false;
                    foreach (string existingId in companies[companyName])
                    {
                        if(existingId == employeeId)
                        {
                            isExist = true;
                        }
                    }

                    if(!isExist)
                    {
                        companies[companyName].Add(employeeId);
                    }
                }
            }

            foreach(var company in companies)
            {
                Console.WriteLine($"{company.Key}");
                foreach(var employeeId in company.Value)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
