using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace _03._Messages_Manager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> users = new Dictionary<string, int>();

            //We will receive the capacity of users - int
            int capacity = int.Parse(Console.ReadLine());

            //We will receive commands until "Statistics"
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "Statistics")
            {
                //We will receive 3 different type of commands:
                string[] commandArgs = command.Split("=", StringSplitOptions.RemoveEmptyEntries);
                string commandType = commandArgs[0];
                //1.Add
                if (commandType == "Add")
                {
                    //Add={username}={sent}={received}
                    string username = commandArgs[1];
                    int sent = int.Parse(commandArgs[2]);
                    int received = int.Parse(commandArgs[3]);

                    //If the user don't exists we add him to the list
                    //Else we will ignore the command
                    if (!users.ContainsKey(username))
                    {
                        int totalMessages = sent + received;
                        users.Add(username, totalMessages);
                    }

                }
                //2.Message
                else if (commandType == "Message")
                {
                    //Message={sender}={receiver}"
                    string sender = commandArgs[1];
                    string receiver = commandArgs[2];

                    //If both users exist
                    if (users.ContainsKey(sender) && users.ContainsKey(receiver))
                    {
                        users[sender] += 1;
                        users[receiver] += 1;

                        if (users[sender] >= capacity)
                        {
                            users.Remove(sender);
                            Console.WriteLine($"{sender} reached the capacity!");
                        }
                        if (users[receiver] >= capacity)
                        {
                            users.Remove(receiver);
                            Console.WriteLine($"{receiver} reached the capacity!");
                        }
                    }
                }
                //3.Empty
                else if (commandType == "Empty")
                {
                    //Empty={username}
                    string username = commandArgs[1];

                    //If we receive "All" as a username, delete all records in the dictionary
                    //Else if we receive a valid username, delete only him
                    if (username == "All")
                    {
                        //Delete all users
                        users.Clear();
                    }
                    else if (users.ContainsKey(username))
                    {
                        users.Remove(username);
                    }
                }
            }

            Console.WriteLine($"Users count: {users.Count}");
            foreach (var currUser in users)
            {
                Console.WriteLine($"{currUser.Key} - {currUser.Value}");
            }
        }
    }
}
