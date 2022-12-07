using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Judge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Format -> [ Key(contest), Value((Key username, Value points)) ]
            Dictionary<string, Dictionary<string, int>> statistics =
                new Dictionary<string, Dictionary<string, int>>();

            //Format -> [ Key(username), Value(points) ]
            Dictionary<string, int> totalPoints = new Dictionary<string, int>();
            AddContests(statistics);
            AddUsers(totalPoints, statistics);

            PrintContestsAndUsers(statistics);
            PrintIndividualStatistics(totalPoints);

        }

        static void PrintIndividualStatistics(Dictionary<string, int> totalPoints)
        {
            int position = 1;
            Console.WriteLine("Individual standings:");
            foreach (var user in totalPoints
                .OrderByDescending(points => points.Value)
                .ThenBy(name => name.Key))
            {
                Console.WriteLine($"{position}. {user.Key} -> {user.Value}");
                position++;
            }
        }
        static void PrintContestsAndUsers(Dictionary<string, Dictionary<string, int>> statistics)
        {
            foreach (var contest in statistics)
            {
                Console.WriteLine($"{contest.Key}: {contest.Value.Count} participants");
                int position = 0;
                foreach (var user in contest.Value
                    .OrderByDescending(points => points.Value)
                    .ThenBy(name => name.Key))
                {
                    position++;
                    Console.WriteLine($"{position}. {user.Key} <::> {user.Value}");
                }
            }
        }

        static void AddUsers(Dictionary<string, int> totalPoints, Dictionary<string, Dictionary<string, int>> statistics)
        {
            foreach (var user in statistics.Values)
            {
                foreach (var student in user)
                {
                    if (!totalPoints.ContainsKey(student.Key))
                    {
                        totalPoints.Add(student.Key, student.Value);
                    }
                    else
                    {
                        totalPoints[student.Key] += student.Value;
                    }
                }
            }
        }

        static void AddContests(Dictionary<string, Dictionary<string, int>> statistics)
        {
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "no more time")
            {
                string[] inputArgs = input.Split(" -> ");
                string username = inputArgs[0];
                string contest = inputArgs[1];
                int points = int.Parse(inputArgs[2]);

                if (statistics.ContainsKey(contest))
                {
                    if (statistics[contest].ContainsKey(username))
                    {
                        int oldScore = statistics[contest][username];
                        if (points > oldScore)
                        {
                            statistics[contest][username] = points;
                        }
                    }
                    else
                    {
                        statistics[contest].Add(username, points);
                    }
                }
                else
                {
                    statistics.Add(contest, new Dictionary<string, int>());
                    statistics[contest].Add(username, points);
                }
            }
        }
    }
}
