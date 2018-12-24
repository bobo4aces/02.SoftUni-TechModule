using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Worms_World_Party
{
    public class Team
    {
        public string TeamName { get; set; }
        public Dictionary<string, long> WormNameAndScore { get; set; }

        public Team(string teamName,string wormName, long wormScore)
        {
            TeamName = teamName;
            WormNameAndScore = new Dictionary<string, long>();
            WormNameAndScore.Add(wormName, wormScore);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<Team> teams = new List<Team>();
            while (input != "quit")
            {
                string[] info = input
                    .Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string wormName = info[0].Trim();
                string teamName = info[1].Trim();
                long wormScore = long.Parse(info[2].Trim());
                Team team = new Team(teamName,wormName,wormScore);
                if (!teams.Any(wn=>wn.WormNameAndScore.ContainsKey(wormName)))
                {
                    bool isFound = false;
                    foreach (var teamM in teams)
                    {
                        if (teamM.TeamName == teamName)
                        {
                            if (!teamM.WormNameAndScore.ContainsKey(wormName))
                            {
                                teamM.WormNameAndScore.Add(wormName, wormScore);
                            }
                            else
                            {
                                teamM.WormNameAndScore[wormName] = wormScore;
                            }
                            isFound = true;
                        }
                    }
                    if (!isFound)
                    {
                        teams.Add(team);
                    }
                }

                input = Console.ReadLine();
            }
            int counter = 1;
            foreach (var team in teams.OrderByDescending(totalScore=>totalScore.WormNameAndScore.Values.Sum()).ThenByDescending(totalScore => totalScore.WormNameAndScore.Values.Sum()/ totalScore.WormNameAndScore.Values.Count()))
            {
                Console.WriteLine($"{counter}. Team: {team.TeamName} - {team.WormNameAndScore.Values.Sum()}");
                foreach (var wormName in team.WormNameAndScore.OrderByDescending(score=>score.Value))
                {
                    Console.WriteLine($"###{wormName.Key} : {wormName.Value}");
                }
                counter++;
            }
        }
    }
}
