using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Ranking
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contests = new Dictionary<string, string>();
            AddContests(contests);

            //Format: Key(Name) -> Value((Key contest), (Value points))
            SortedDictionary<string, Dictionary<string, int>> submissions = 
                new SortedDictionary<string, Dictionary<string, int>>();
            AddSubmissions(contests, submissions);

            BestCandidate(submissions);
            PrintUsers(submissions);
        }

        static void PrintUsers(SortedDictionary<string, Dictionary<string, int>> submissions)
        {
            Console.WriteLine("Ranking:");
            foreach (var user in submissions)
            {
                Console.WriteLine($"{user.Key}");
                foreach (var contest in user.Value.OrderByDescending(points => points.Value))
                {
                    Console.WriteLine($"#  {contest.Key} -> {contest.Value}");
                }
            }
        }
        static void BestCandidate(SortedDictionary<string, Dictionary<string, int>> submissions)
        {
            int maxPoints = int.MinValue;
            string bestCandidate = string.Empty;
            foreach (var username in submissions)
            {
                string name = username.Key;
                int totalPoints = 0;
                foreach (var points in username.Value.Values)
                {
                    totalPoints += points;
                }

                if (totalPoints > maxPoints)
                {
                    maxPoints = totalPoints;
                    bestCandidate = name;
                }
            }

            Console.WriteLine($"Best candidate is {bestCandidate} with total {maxPoints} points.");
        }
        static void AddSubmissions(Dictionary<string, string> contests, SortedDictionary<string, Dictionary<string, int>> submissions)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "end of submissions")
            {
                string[] inputArgs = input.Split("=>");
                string contest = inputArgs[0];
                string password = inputArgs[1];
                string username = inputArgs[2];
                int points = int.Parse(inputArgs[3]);

                //Check if we have contest with given name and
                //given password for this contest is correct
                if (contests.ContainsKey(contest) && contests.ContainsValue(password))
                {
                    //If we receive the same contest and the same user
                    //-> updates the points only if the new ones are more than the older ones.
                    if (submissions.ContainsKey(username))
                    {
                        if (submissions[username].ContainsKey(contest))
                        {
                            int oldPoints = submissions[username][contest];
                            if (points > oldPoints)
                            {
                                submissions[username][contest] = points;
                            }
                        }
                        else
                        {
                            submissions[username].Add(contest, points);
                        }
                    }
                    else
                    {
                        submissions.Add(username, new Dictionary<string, int>());
                        submissions[username].Add(contest, points);
                    }
                }
            }
        }

        static void AddContests(Dictionary<string, string> contests)
        {
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end of contests")
            {
                string[] commandArgs = command.Split(":");
                string contest = commandArgs[0];
                string password = commandArgs[1];

                //We won't have two equal contests
                contests.Add(contest, password);
            }
        }
    }
}
