using System;
using System.Text.RegularExpressions;

namespace _02._Easter_Eggs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We will receive a text - string
            string text = Console.ReadLine();

            string pattern = @"[\@{1,}|\#{1,}](?<color>[a-z]{3,})[\@{1,}|\#{1,}][^A-Za-z0-9]*[\/+](?<amount>[\d]+)[\/+]";
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(text);

            foreach (Match match in matches)
            {
                string color = match.Groups["color"].Value;
                string am = match.Groups["amount"].Value;
                int amount = int.Parse(match.Groups["amount"].Value);

                Console.WriteLine($"You found {amount} {color} eggs!");
            }
        }
    }
}
