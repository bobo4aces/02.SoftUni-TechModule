using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hornet_Armada
{
    public class Legion
    {
        public long LastActivity { get; set; }
        public string LegionName { get; set; }
        public string SoldierType { get; set; }
        public long SoldierCount { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, long> legionByActivity = new Dictionary<string, long>();
            Dictionary<string, Dictionary<string, long>> legionByTypeAndCount = new Dictionary<string, Dictionary<string, long>>();
            for (int i = 0; i < n; i++)
            {
                string[] soldierInfo = Console.ReadLine()
                    .Split(new char[] { '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                long lastActivity = long.Parse(soldierInfo[0]);
                string legionName = soldierInfo[1].Trim();
                string soldierType = soldierInfo[2].Trim();
                long soldierCount = long.Parse(soldierInfo[3]);
                if (legionByTypeAndCount.ContainsKey(legionName))
                {
                    if (!legionByTypeAndCount[legionName].ContainsKey(soldierType))
                    {
                        legionByTypeAndCount[legionName].Add(soldierType, 0);
                    }
                    legionByTypeAndCount[legionName][soldierType] += soldierCount;
                }
                else
                {
                    Dictionary<string, long> dictionary = new Dictionary<string, long>();
                    dictionary.Add(soldierType, soldierCount);
                    legionByTypeAndCount.Add(legionName, dictionary);
                }
                if (!legionByActivity.ContainsKey(legionName))
                {
                    legionByActivity[legionName] = lastActivity;
                }

                if (lastActivity > legionByActivity[legionName])
                {
                    legionByActivity[legionName] = lastActivity;
                }
            }
            string[] command = Console.ReadLine()
                .Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            if (command.Length > 1)
            {
                foreach (var legion in legionByTypeAndCount.Where(l => l.Value.ContainsKey(command[1])).OrderByDescending(c => c.Value[command[1]]))
                {

                    if (legionByActivity[legion.Key] < long.Parse(command[0]))
                    {
                        Console.WriteLine($"{legion.Key} -> {legion.Value[command[1]]}");
                    }

                }
            }
            else
            {
                foreach (var legion in legionByActivity.OrderByDescending(a => a.Value))
                {
                    if (legionByTypeAndCount[legion.Key].ContainsKey(command[0]))
                    {
                        Console.WriteLine($"{legion.Value} -> {legion.Key}");
                    }
                }
            }
        }
    }
}
