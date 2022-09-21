using System;
using System.Numerics;
using System.Reflection;
using System.Xml.Linq;

namespace _03._Gaming_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1.Create a program, which helps you buy the games. The valid games are the following games in this table:
            //   Name                       Price
            // OutFall 4                    $39.99
            // CS: OG                       $15.99
            // Zplinter Zell	            $19.99
            // Honored 2                    $59.99
            // RoverWatch                   $29.99
            // RoverWatch Origins Edition   $39.99

            //2.On the first line, you will receive your current balance – a floating-point number in the range [0.00…5000.00].
            double currentBalance = double.Parse(Console.ReadLine());

            //3.Until you receive the command "Game Time", you have to keep buying games.
            //  When a game is bought, the user’s balance decreases by the price of the game.
            string gameName = Console.ReadLine();
            double totalSum = 0;

            //4.If a game the user is trying to buy is not present in the table above, print "Not Found" and read the next line.
            //	If at any point, the user has $0 left, print "Out of money!" and end the program.
            //	Alternatively, if the user is trying to buy a game that they can’t afford, print "Too Expensive" and read the next line.
            //	If the game exists and the player has the money for it, print "Bought {nameOfGame}"
            while (gameName != "Game Time")
            {
                double gamePrize = 0;
                if (gameName == "OutFall 4")
                {
                    gamePrize = 39.99;
                }
                else if (gameName == "CS: OG")
                {
                    gamePrize = 15.99;
                }
                else if (gameName == "Zplinter Zell")
                {
                    gamePrize = 19.99;
                }
                else if (gameName == "Honored 2")
                {
                    gamePrize = 59.99;
                }
                else if (gameName == "RoverWatch")
                {
                    gamePrize = 29.99;
                }
                else if (gameName == "RoverWatch Origins Edition")
                {
                    gamePrize = 39.99;
                }
                else
                {
                    Console.WriteLine("Not Found");
                    gameName = Console.ReadLine();
                    continue;
                }

                if (gamePrize <= currentBalance)
                {
                    Console.WriteLine($"Bought {gameName}");
                    gameName = Console.ReadLine();
                    totalSum += gamePrize;
                    currentBalance -= gamePrize;
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                    gameName = Console.ReadLine();
                    continue;
                }

                if (currentBalance == 0)
                {
                    Console.WriteLine("Out of money!");
                    break;
                }
            }

            //5.When you receive "Game Time", print the user’s remaining money and total spent on games,
            //  rounded to the 2nd decimal place.
            if (gameName == "Game Time" && currentBalance > 0)
            {
                Console.WriteLine($"Total spent: ${totalSum:F2}. Remaining: ${currentBalance:F2}");
            }
        }
    }
}
