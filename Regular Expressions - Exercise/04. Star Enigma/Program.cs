using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04._Star_Enigma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string pattern = @"^[^\@\-\!\:\>]*?\@(?<planet>[A-Za-z]+)[^\@\-\!\:\>]*?\:(?<population>\d+)[^\@\-\!\:\>]*?\!(?<attackType>A|D)\![^\@\-\!\:\>]*?\-\>(?<soldiers>\d+)[^\@\-\!\:\>]*?$";
            Regex regex = new Regex(pattern);

            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < n; i++)
            {
                string encryptedMessage = Console.ReadLine();
                string decryptedMessage = DecryptMessage(encryptedMessage);

                Match match = regex.Match(decryptedMessage);
                if(match.Success)
                {
                    string planet = match.Groups["planet"].Value;
                    char attackType = char.Parse(match.Groups["attackType"].Value);

                    if(attackType == 'A')
                    {
                        if(!attackedPlanets.Contains(planet))
                        {
                            attackedPlanets.Add(planet);
                        }
                    }
                    else if (attackType == 'D')
                    {
                        if(!destroyedPlanets.Contains(planet))
                        {
                            destroyedPlanets.Add(planet);
                        }
                    }
                }
            }

            PrintPlanets("Attacked", attackedPlanets);
            PrintPlanets("Destroyed", destroyedPlanets);
        }

        static string DecryptMessage(string encryptedMessage)
        {
            //count all the letters [s, t, a, r] 
            //Remove the count from the current ASCII value of each symbol of the encrypted message.
            int count = 0;
            foreach(char currChar in encryptedMessage.ToLower())
            {
                if(currChar == 's' || currChar == 't' ||
                    currChar == 'a' || currChar == 'r')
                {
                    count++;
                }
            }

            //Here we we replace the old char with a brand new char,
            //and we will add we will decrypt the message
            StringBuilder sb = new StringBuilder();
            string decryptedMessage = string.Empty;

            foreach(char currChar in encryptedMessage)
            {
                char newChar = (char)(currChar - count);
                sb.Append(newChar);
            }

            decryptedMessage = sb.ToString();

            return decryptedMessage;
        }

        static void PrintPlanets(string attackType, List<string> planets)
        {
            Console.WriteLine($"{attackType} planets: {planets.Count}");
            foreach(string planet in planets
                .OrderBy(name => name))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
