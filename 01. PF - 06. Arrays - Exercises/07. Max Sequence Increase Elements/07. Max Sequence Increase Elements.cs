using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Max_Sequence_Increase_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int start = 0;
            int len = 1;
            int bestStart = 0;
            int bestLen = 1;
            for (int i = 1; i <= array.Length-1; i++)
            {
                if (array[i-1] < array[i])
                {
                    len++;
                }
                else
                {
                    start = i;
                    len = 1;
                }
                if (bestLen<len)
                {
                    bestLen = len;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestLen+bestStart; i++)
            {
                Console.Write(array[i]+" ");
            }
        }
    }
}
