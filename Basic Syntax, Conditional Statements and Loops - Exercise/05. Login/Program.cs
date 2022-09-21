using System;
using System.Linq;

namespace _05._Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Input:
            // username - string
            string username = Console.ReadLine();

            //2.Password = username reversed;
            string password = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                password += username[i];
            }

            //3.On the next lines, you will receive passwords:
            //  If the password is incorrect print "Incorrect password. Try again."
            //	If the password is correct print: "User {username} logged in." and stop the program
            //  On the fourth attempt if the password is still not correct print: "User {username} blocked!"
            string possiblePasswords = Console.ReadLine();
            bool blocked = false;
            int count = 0;
            while (possiblePasswords != password)
            {
                count++;

                if (count == 4)
                {
                    blocked = true;
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }

                Console.WriteLine("Incorrect password. Try again.");
                possiblePasswords = Console.ReadLine();
            }

            if (!blocked)
            {
                Console.WriteLine($"User {username} logged in.");
            }
        }
    }
}
