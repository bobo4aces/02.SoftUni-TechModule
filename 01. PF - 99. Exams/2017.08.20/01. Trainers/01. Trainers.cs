using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Trainers
{
    class Program
    {
        static void Main(string[] args)
        {
            long participantsCount = long.Parse(Console.ReadLine());
            decimal technicalTeamMoney = 0M;
            decimal theoreticalTeamMoney = 0M;
            decimal practicalTeamMoney = 0M;
            for (int i = 0; i < participantsCount; i++)
            {
                long distanceInMiles = long.Parse(Console.ReadLine());
                decimal cargoInTons = decimal.Parse(Console.ReadLine());
                string team = Console.ReadLine().ToLower();
                decimal participantEarnedMoney = (cargoInTons * 1000M) * 1.5M - 0.7M * (distanceInMiles * 1600M) * 2.5M;
                if (team== "technical")
                {
                    technicalTeamMoney += participantEarnedMoney;
                }
                else if (team == "theoretical")
                {
                    theoreticalTeamMoney += participantEarnedMoney;
                }
                else if (team == "practical")
                {
                    practicalTeamMoney += participantEarnedMoney;
                }
            }
            if (technicalTeamMoney- theoreticalTeamMoney>= 0.0001M && technicalTeamMoney - practicalTeamMoney >= 0.0001M)
            {
                Console.WriteLine($"The Technical Trainers win with ${technicalTeamMoney:f3}.");
            }
            else if (theoreticalTeamMoney - technicalTeamMoney >= 0.0001M && theoreticalTeamMoney - practicalTeamMoney >= 0.0001M)
            {
                Console.WriteLine($"The Theoretical Trainers win with ${technicalTeamMoney:f3}.");
            }
            else if (practicalTeamMoney - technicalTeamMoney >= 0.0001M && practicalTeamMoney - theoreticalTeamMoney >= 0.0001M)
            {
                Console.WriteLine($"The Practical Trainers win with ${practicalTeamMoney:f3}.");
            }
        }
    }
}
