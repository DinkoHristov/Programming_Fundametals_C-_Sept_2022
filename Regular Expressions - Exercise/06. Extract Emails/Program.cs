using System;
using System.Text.RegularExpressions;

namespace _06._Extract_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input string
            string input = Console.ReadLine();

            //2.Regex for email user
            string pattern = @"(^|(?<=\s))(([a-zA-Z0-9]+)([\.\-_]?)([A-Za-z0-9]+)\@([a-zA-Z]+[\-]?([\.\-][A-Za-z]+)+))(\b|(?=\s))";
            Regex regex = new Regex(pattern);

            MatchCollection matches = regex.Matches(input);

            foreach(Match match in matches)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
