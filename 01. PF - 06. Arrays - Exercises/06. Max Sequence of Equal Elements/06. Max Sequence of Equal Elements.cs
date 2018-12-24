using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Max_Sequence_of_Equal_Elements
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
            for (int i = 1; i <= array.Length - 1; i++)
            {
                if (array[i] == array[start])
                {
                    len++;  
                }
                else
                {
                    start = i;
                    len = 1;  
                }
                if (bestLen < len)
                {
                    bestStart = start;
                    bestLen = len;
                }
            }
            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(array[bestStart] + " ");
            }
        }
    }
}
