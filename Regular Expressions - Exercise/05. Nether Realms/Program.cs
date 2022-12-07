using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _05._Nether_Realms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] demons = Regex.Split(Console.ReadLine(), @" *,{1} *");
            char[] splitter = new char [2]{ ',', ' '};
            string[] demons = Console.ReadLine()
                .Split(splitter, StringSplitOptions.RemoveEmptyEntries);

            foreach (var demon in demons.OrderBy(name => name))
            {
                string demonName = demon;

                double currDemonHealth = 0;

                string healthPattern = @"[^\d\+\-\*\/\.]";
                Regex regex = new Regex(healthPattern);

                MatchCollection matches = regex.Matches(demon);
                foreach(Match match in matches)
                {
                    char letter = char.Parse(match.Value);
                    currDemonHealth += letter;
                }

                double currDemonDamage = 0;

                string damagePattern = @"[\-\+]?(\d+(\.\d+)?)";
                regex = new Regex(damagePattern);

                matches = regex.Matches(demon);
                foreach(Match match in matches)
                {
                    double currNumber = double.Parse(match.Value);
                    currDemonDamage += currNumber;
                }

                string signsPattern = @"[\*\/]";
                regex = new Regex(signsPattern);

                matches = regex.Matches(demon);
                foreach(Match match in matches)
                {
                    char sign = char.Parse(match.Value);
                    if(sign == '*')
                    {
                        currDemonDamage *= 2;
                    }
                    else if (sign == '/')
                    {
                        currDemonDamage /= 2;
                    }
                }

                Console.WriteLine($"{demonName} - {currDemonHealth} health, {currDemonDamage:F2} damage");
            }
        }
    }
}
