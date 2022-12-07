using System;
using System.ComponentModel;
using System.Text;

namespace _01._Valid_Usernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder validUsernames = new StringBuilder();

            string[] usernames = Console.ReadLine()
                .Split(", ");

            //Print valid usernames:
            //-> Has length between 3 and 16 characters and
            //-> Contains only letters, numbers, hyphens, and underscores
            foreach(string currUsername in usernames)
            {
                bool isValid = true;

                if((currUsername.Length >= 3 && currUsername.Length <= 16))
                {
                    foreach(char letter in currUsername)
                    {
                        if(!char.IsLetterOrDigit(letter) &&
                            letter != '-' && letter != '_')
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
                else
                {
                    isValid = false;
                }

                if(isValid)
                {
                    validUsernames.AppendLine(currUsername);
                }
            }

            Console.WriteLine(validUsernames);
        }
    }
}
