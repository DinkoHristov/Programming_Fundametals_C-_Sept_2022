using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _4._Santa_s_Secret_Helper
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //On the first line we will receive a key
            int key = int.Parse(Console.ReadLine());

            //On the next lines until we receive "end", we will receive envrypted messages
            List<string> goodChildren = new List<string>();
            string encryptedMessage = string.Empty;
            while ((encryptedMessage = Console.ReadLine()) != "end")
            {
                //Decrypted message -> we need to subtract the key from the given letter from the encrypted message
                StringBuilder sb = new StringBuilder();
                string decryptedMessage = string.Empty;
                foreach (char letter in encryptedMessage)
                {
                    char newLetter = (char)(letter - key);
                    sb.Append(newLetter);
                }

                decryptedMessage = sb.ToString();

                string pattern = @".*\@(?<name>[A-Za-z]+)[^\@|\-|\!|\:|\>]+\!(?<behaviour>[G|N])\!.*";
                Regex regex = new Regex(pattern);
                Match match = regex.Match(decryptedMessage);

                if(match.Success)
                {
                    string name = match.Groups["name"].Value;
                    char behaviour = char.Parse(match.Groups["behaviour"].Value);

                    if(behaviour == 'G')
                    {
                        if(!goodChildren.Contains(name))
                        {
                            goodChildren.Add(name);
                        }
                    }
                }
            }

            foreach(string child in goodChildren)
            {
                Console.WriteLine(child);
            }
        }
    }
}
