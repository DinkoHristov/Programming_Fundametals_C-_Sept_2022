using System;
using System.Collections.Generic;

namespace _04._SoftUni_Parking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, string> parking = new Dictionary<string, string>();

            for(int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split();
                string commandType = command[0];
                string username = command[1];

                if (commandType == "register")
                {
                    string licensePlateNumber = command[2];

                    if (!parking.ContainsKey(username))
                    {
                        parking.Add(username, licensePlateNumber);
                        Console.WriteLine($"{username} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: already registered with plate number {licensePlateNumber}");
                    }
                }
                else if (commandType == "unregister")
                {
                    if (parking.ContainsKey(username))
                    {
                        parking.Remove(username);
                        Console.WriteLine($"{username} unregistered successfully");
                    }
                    else
                    {
                        Console.WriteLine($"ERROR: user {username} not found");
                    }
                }
            }

            foreach(var user in parking)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
