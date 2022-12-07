using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Teamwork_Projects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());

            User user = new User();

            for (int i = 1; i <= teamsCount; i++)
            {
                string[] teamInfo = Console.ReadLine().Split("-");

                string creatorName = teamInfo[0];
                string teamName = teamInfo[1];

                Team team = new Team(creatorName, teamName);

                bool isTeamExists = false;

                foreach (Team currentTeam in user.Teams)
                {
                    if (currentTeam.TeamName == team.TeamName)
                    {
                        //We already have this team.
                        Console.WriteLine($"Team {team.TeamName} was already created!");
                        isTeamExists = true;
                    }
                }

                bool isCreatorExists = false;
                foreach (Team currentTeam in user.Teams)
                {
                    if (currentTeam.CreatorName == team.CreatorName)
                    {
                        Console.WriteLine($"{team.CreatorName} cannot create another team!");
                        isCreatorExists = true;
                    }
                }

                if (!isTeamExists && !isCreatorExists)
                {
                    user.Teams.Add(team);
                    team.Members.Add(team.CreatorName);
                    Console.WriteLine($"Team {team.TeamName} has been created by {team.CreatorName}!");
                }
            }

            string command = string.Empty;

            while ((command = Console.ReadLine()) != "end of assignment")
            {
                string[] userInfo = command.Split("->");

                string userName = userInfo[0];
                string teamName = userInfo[1];

                bool isTeamExists = false;

                foreach(Team currentTeam in user.Teams)
                {
                    if (currentTeam.TeamName == teamName)
                    {
                        //This means that the team exists.

                        if (userName != currentTeam.CreatorName)
                        {
                            //This means the new user can join this team.
                            currentTeam.Members.Add(userName);
                        }
                        else
                        {
                            Console.WriteLine($"Member {userName} cannot join team {teamName}!");
                        }

                        isTeamExists = true;
                    }
                }

                if (!isTeamExists)
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
            }

            foreach(Team team in user.Teams
                .OrderByDescending(x => x.Members.Count)
                .ThenBy(x => x.TeamName))
            {
                if (team.Members.Count > 1)
                {
                    Console.WriteLine($"{team.TeamName}");
                    Console.WriteLine($"- {team.CreatorName}");

                    for (int i = 1; i < team.Members.Count; i++)
                    {
                        Console.WriteLine($"-- {team.Members[i]}");
                    }
                }
            }

            Console.WriteLine("Teams to disband:");
            foreach(Team team in user.Teams
                .Where(x => x.Members.Count <= 1)
                .OrderBy(x => x.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }

    public class User
    {
        public User()
        {
            Teams = new List<Team>();
        }

        public List<Team> Teams { get; set; }
    }
    public class Team
    {
        public Team(string creatorName, string teamName)
        {
            CreatorName = creatorName;
            TeamName = teamName;
            Members = new List<string>();
        }

        public string CreatorName { get; set; }

        public string TeamName { get; set; }

        public List<string> Members { get; set; }
    }
}
