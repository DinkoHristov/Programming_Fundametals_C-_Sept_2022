using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Race
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] participants = Console.ReadLine()
                .Split(", ")
                .ToArray();

            Dictionary<string, int> players = new Dictionary<string, int>();
            string input = string.Empty;
            while((input = Console.ReadLine()) != "end of race")
            {
                string pattern = @"[A-Za-z]+";
                Regex regex = new Regex(pattern);
                string name = string.Empty;
                MatchCollection matches = regex.Matches(input);

                foreach(Match match in matches)
                {
                    name += match.Value;
                }

                if(!participants.Contains(name))
                {
                    continue;
                }

                pattern = @"\d";
                regex = new Regex(pattern);
                int km = 0;
                matches = regex.Matches(input);

                foreach(Match match in matches)
                {
                    km += int.Parse(match.Value);
                }

                if(!players.ContainsKey(name))
                {
                    players.Add(name, km);
                }
                else
                {
                    players[name] += km;
                }
            }

            int count = 1;
            foreach(var player in players
                .OrderByDescending(km => km.Value))
            {
                if (count == 1)
                {
                    Console.WriteLine($"1st place: {player.Key}");
                    count++;
                }
                else if (count == 2)
                {
                    Console.WriteLine($"2nd place: {player.Key}");
                    count++;
                }
                else if (count == 3)
                {
                    Console.WriteLine($"3rd place: {player.Key}");
                    count++;
                }
                else
                {
                    break;
                }
            }
        }
    }
}
