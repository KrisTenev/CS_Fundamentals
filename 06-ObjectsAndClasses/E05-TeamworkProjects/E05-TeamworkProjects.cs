using System;
using System.Linq;
using System.Collections.Generic;

namespace E05_TeamworkProjects
{
    internal class Program
    {
        static void Main()
        {

            int registeredTeams = int.Parse(Console.ReadLine());

            List<Team> teams = new List<Team>();

            for (int i = 0; i < registeredTeams; i++)
            {
                string[] inputRegistration = Console.ReadLine().Split('-');
                string creator = inputRegistration[0];
                string newTeam = inputRegistration[1];

                bool isTeamNameExist = teams.Select(x => x.TeamName).Contains(newTeam);
                bool isCreatorExist = teams.Select(x => x.Creator).Contains(creator);

                if (isTeamNameExist)
                {
                    Console.WriteLine($"Team {newTeam} was already created!");
                }
                else
                {
                    if (isCreatorExist)
                    {
                        Console.WriteLine($"{creator} cannot create another team!");
                    }
                    else
                    {
                        teams.Add(new Team(creator, newTeam));
                        Console.WriteLine($"Team {newTeam} has been created by {creator}!");
                    }
                }
            }

            string[] inputJoin = Console.ReadLine().Split("->");

            string userToJoin = inputJoin[0];


            while (userToJoin != "end of assignment")
            {
                string teamToJoin = inputJoin[1];

                bool isTeamNameExist = teams.Select(x => x.TeamName).Contains(teamToJoin);
                bool isMemberExist = teams.Any(x => x.Member.Contains(userToJoin));
                bool isCreatorExist = teams.Any(x => x.Creator.Contains(userToJoin));

                if (isTeamNameExist)
                {
                    if (isMemberExist || isCreatorExist)
                    {
                        Console.WriteLine($"Member {userToJoin} cannot join team {teamToJoin}!");
                    }
                    else
                    {
                        int indexOfTeam = teams.FindIndex(x => x.TeamName == teamToJoin);

                        teams[indexOfTeam].Member.Add(userToJoin);
                    }
                }
                else
                {
                    Console.WriteLine($"Team {teamToJoin} does not exist!");
                }

                inputJoin = Console.ReadLine().Split("->");
                userToJoin = inputJoin[0];
            }

            List<Team> realTeams = teams
                .Where(x => x.Member.Count > 0)
                .OrderByDescending(x => x.Member.Count)
                .ThenBy(x => x.TeamName)
                .ToList();

            List<Team> disbandTeams = teams
                .Where(x => x.Member.Count == 0)
                .OrderBy(x => x.TeamName)
                .ToList();

            foreach (var item in realTeams)
            {
                Console.WriteLine(item.TeamName);
                Console.WriteLine("- " + item.Creator);
                Console.WriteLine(string.Join(Environment.NewLine, item.Member.Select(x => "-- " + x)));
            }

            Console.WriteLine("Teams to disband:");

            foreach (var item in disbandTeams)
            {
                Console.WriteLine(item.TeamName);
            }

        }

        public class Team
        {
            public Team(string creator, string teamName)
            {
                TeamName = teamName;
                Creator = creator;
                Member = new List<string>();
            }

            public string TeamName { get; set; }
            public string Creator { get; set; }
            public List<string> Member { get; set; }


        }
    }
}
