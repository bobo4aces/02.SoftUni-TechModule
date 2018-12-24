using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Hornet_Assault
{
    class Program
    {
        static void Main(string[] args)
        {
            List <long> beehives = Console.ReadLine()
                .Split(new[] { ' '},StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            List <long> hornets = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(long.Parse)
                .ToList();
            List<long> beesResult = new List<long>();
            List<long> hornetsResult = new List<long>();
            int counter = 0;
            long hornetsSum = hornets.Sum();
            for (int i = 0; i < beehives.Count; i++)
            {
                if (hornets.Count == 0)
                {
                    break;
                }
                long beeCount = beehives[i];
                if (hornetsSum <= beeCount)
                {
                    long beesLeft = beeCount - hornetsSum;
                    if (beesLeft!=0)
                    {
                        beesResult.Add(beesLeft);
                    } 
                    if (counter>=hornets.Count)
                    {
                        break;
                    }
                    hornetsSum -= hornets[counter];
                    hornets[counter] = -1;
                    counter++; 
                }
            }
            hornetsResult.AddRange(hornets.Where(p => p > -1));
            if (beesResult.Count>0)
            {
                Console.WriteLine(string.Join(" ", beesResult));
            }
            else
            {
                Console.WriteLine(string.Join(" ", hornetsResult));
            }

        }
    }
}
