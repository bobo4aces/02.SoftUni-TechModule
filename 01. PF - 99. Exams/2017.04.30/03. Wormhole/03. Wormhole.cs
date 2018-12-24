using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Wormhole
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] wormholes = Console.ReadLine()
                .Split(new[] {' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int steps = 0;
            for (int i = 0; i < wormholes.Length; i++)
            {
                if (wormholes[i]==0)
                {
                    steps++;
                }
                else
                {
                    int index = wormholes[i];
                    wormholes[i] = 0;
                    i = index;
                    steps++;
                }
            }
            Console.WriteLine(steps);
        }
    }
}
