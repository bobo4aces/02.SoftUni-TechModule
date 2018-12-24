using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Teamwork_Projects
{
    class Team
    {
        public string TeamName { get; set; }
        public List<string> Members { get; set; }
        public string CreatorName { get; set; }

        public Team(string teamName, string creatorName)
        {
            TeamName = teamName;
            Members = new List<string>();
            CreatorName = creatorName;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int teamsCount = int.Parse(Console.ReadLine());
            List<Team> teams = new List<Team>();
            while (teamsCount-- > 0)
            {
                string[] teamInfo = Console.ReadLine().Split('-').ToArray();
                string creatorName = teamInfo[0];
                string teamName = teamInfo[1];
                Team team = new Team(teamName, creatorName);
                bool isTeamCreated = true;
                for (int i = 0; i < teams.Count; i++)
                {
                    if (teams[i].TeamName == team.TeamName)
                    {
                        Console.WriteLine($"Team {team.TeamName} was already created!");
                        isTeamCreated = false;
                    }
                    if (teams[i].CreatorName == team.CreatorName)
                    {
                        Console.WriteLine($"{team.CreatorName} cannot create another team!");
                        isTeamCreated = false;
                    }
                }
                if (isTeamCreated)
                {
                    teams.Add(team);
                    Console.WriteLine($"Team {teamName} has been created by {creatorName}!");
                }
            }

            string assignment = Console.ReadLine();
            while (assignment != "end of assignment")
            {
                string[] separator = new string[] { "->" };
                var currentLine = assignment.Split(separator, StringSplitOptions.None).ToList();
                string member = currentLine.First();
                string teamName = currentLine.Last();
                if (!teams.Any(n => n.TeamName == teamName))
                {
                    Console.WriteLine($"Team {teamName} does not exist!");
                }
                else if (teams.Any(m => m.CreatorName == member) || teams.Any(m => m.Members.Contains(member)))
                {
                    Console.WriteLine($"Member {member} cannot join team {teamName}!");
                }
                else
                {
                    foreach (var team in teams)
                    {
                        if (team.TeamName == teamName)
                        {
                            team.Members.Add(member);
                        }
                    }
                }
                assignment = Console.ReadLine();
            }
            foreach (var team in teams.Where(m => m.Members.Count > 0).OrderBy(t => t.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
                Console.WriteLine($"- {team.CreatorName}");
                foreach (var member in team.Members)
                {
                    Console.WriteLine($"-- {member}");
                }
            }
            Console.WriteLine("Teams to disband:");
            foreach (var team in teams.Where(m => m.Members.Count == 0).OrderBy(t => t.TeamName))
            {
                Console.WriteLine($"{team.TeamName}");
            }
        }
    }
}
