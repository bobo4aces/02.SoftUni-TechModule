using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sequence = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int[] result = new int[sequence.Length - 1];
            int initialIndex = sequence[result.Length];
            int steps = 0;
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = sequence[i] - 1;
            }
            for (int i = 0; i < result.Length; i++)
            {
                initialIndex = int.Parse(Console.ReadLine());
                steps++;
                bool isDead = false;
                for (int k = 0; k < result.Length; k++)
                {
                    result[k] = result[k] - 1;
                    if (result[initialIndex] == 0)
                    {
                        isDead = true;
                    }

                }
                if (isDead)
                {
                    Console.WriteLine(string.Join(" ", result));
                    Console.WriteLine(steps);
                    return;
                }
                for (int k = 0; k < result.Length; k++)
                {

                    if (result[k] == 0)
                    {
                        result[k] = sequence[k];
                    }
                }

            }
        }
    }
}