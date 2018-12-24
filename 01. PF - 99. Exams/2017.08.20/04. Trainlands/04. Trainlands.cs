using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Trainlands
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<KeyValuePair<string, long>>> trainsWithWagonsAndPower = new Dictionary<string, List<KeyValuePair<string, long>>>();
            while (input != "It's Training Men!")
            {
                string[] info = input
                    .Split(new[] { ' ', '=', '-', '>', ':' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                if (info.Length >= 3)
                {
                    if (!trainsWithWagonsAndPower.ContainsKey(info[0]))
                    {
                        trainsWithWagonsAndPower.Add(info[0], new List<KeyValuePair<string, long>>());          
                    }
                    trainsWithWagonsAndPower[info[0]].Add(new KeyValuePair<string,long>(info[1],long.Parse(info[2])));
                }
                else
                {
                    if (input.Contains("->"))
                    {
                        if (!trainsWithWagonsAndPower.ContainsKey(info[0]))
                        {
                            trainsWithWagonsAndPower.Add(info[0], new List<KeyValuePair<string, long>>());
                        }
                        trainsWithWagonsAndPower[info[0]].AddRange(trainsWithWagonsAndPower[info[1]]);
                        trainsWithWagonsAndPower[info[1]].Clear();
                    }
                    else if (input.Contains("="))
                    {
                        if (!trainsWithWagonsAndPower.ContainsKey(info[0]))
                        {
                            trainsWithWagonsAndPower.Add(info[0], new List<KeyValuePair<string, long>>());
                        }
                        trainsWithWagonsAndPower[info[0]].Clear();
                        trainsWithWagonsAndPower[info[0]].AddRange(trainsWithWagonsAndPower[info[1]]);
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var train in trainsWithWagonsAndPower.Where(wagonCount=>wagonCount.Value.Count>=1).OrderByDescending(wagonPower=>wagonPower.Value.Sum(x=>x.Value)).ThenBy(wagonCount => wagonCount.Value.Count()))
            {
                Console.WriteLine($"Train: {train.Key}");
                foreach (var wagon in train.Value.OrderByDescending(wagonPower=>wagonPower.Value))
                {
                    Console.WriteLine($"###{wagon.Key} - {wagon.Value}");
                }
            }
        }
    }
}
