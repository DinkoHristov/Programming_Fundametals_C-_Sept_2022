using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._MOBA_Challenger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Format -> [ Key(playerName), Value(Key(position), Value(skillPoints)) ]
            Dictionary<string, Dictionary<string, int>> players = 
                new Dictionary<string, Dictionary<string, int>>();

            string command = string.Empty;
            while((command = Console.ReadLine()) != "Season end")
            {
                //Check the input
                if (command.Split(" vs ").Length == 2)
                {
                    //"{player} vs {player}"
                    string[] commandArgs = command.Split(" vs ");
                    string playerOne = commandArgs[0];
                    string playerTwo = commandArgs[1];

                    if(players.ContainsKey(playerOne) && players.ContainsKey(playerTwo))
                    {
                        foreach (var currPlayerOne in players[playerOne])
                        {
                            bool isPlayerRemoved = false;
                            foreach (var currPlayerTwo in players[playerTwo])
                            {
                                //We found players we common positions.
                                if (currPlayerOne.Key == currPlayerTwo.Key)
                                {
                                    int playerOneSkill = currPlayerOne.Value;
                                    int playerTwoSkill = currPlayerTwo.Value;
                                    if (playerOneSkill > playerTwoSkill)
                                    {
                                        players.Remove(playerTwo);
                                        isPlayerRemoved = true;
                                        break;
                                    }
                                    else if (playerOneSkill < playerTwoSkill)
                                    {
                                        players.Remove(playerOne);
                                        isPlayerRemoved = true;
                                        break;
                                    }
                                }
                            }

                            if (isPlayerRemoved)
                            {
                                break;
                            }
                        }
                    }
                }
                else
                {
                    //"{player} -> {position} -> {skill}"
                    string[] commandArgs = command.Split(" -> ");
                    string player = commandArgs[0];
                    string position = commandArgs[1];
                    int skill = int.Parse(commandArgs[2]);

                    if(players.ContainsKey(player))
                    {
                        if (players[player].ContainsKey(position))
                        {
                            int oldSkill = players[player][position];
                            if (skill > oldSkill)
                            {
                                players[player][position] = skill;
                            }
                        }
                        else
                        {
                            players[player].Add(position, skill);
                        }

                    }
                    else
                    {
                        players.Add(player, new Dictionary<string, int>());
                        players[player].Add(position, skill);
                    }
                }
            }

            Dictionary<string, int> totalPlayers = new Dictionary<string, int>();
            foreach(var player in players)
            {
                if(!totalPlayers.ContainsKey(player.Key))
                {
                    int totalPoints = 0;
                    foreach(var points in player.Value.Values)
                    {
                        totalPoints += points;
                    }

                    totalPlayers.Add(player.Key, totalPoints);
                }
            }

            Dictionary<string, int> sortedPlayers = new Dictionary<string, int>();
            foreach(var player in totalPlayers
                .OrderByDescending(points => points.Value)
                .ThenBy(name => name.Key))
            {
                sortedPlayers.Add(player.Key, player.Value);
            }

            foreach(var player in sortedPlayers)
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");
                foreach(var position in players[player.Key]
                    .OrderByDescending(skill => skill.Value)
                    .ThenBy(posName => posName.Key))
                {
                    Console.WriteLine($"- {position.Key} <::> {position.Value}");
                }
            }
        }
    }
}
