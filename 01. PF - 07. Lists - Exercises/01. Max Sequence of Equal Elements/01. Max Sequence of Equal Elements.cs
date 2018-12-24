using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Max_Sequence_of_Equal_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> maxSequenceNumbers = new List<int>();
            int maxSequence = 0;
            int start = 0;
            int length = 1;
            int bestStart = 0;
            int bestLength =1;
            for (int i = 1; i < list.Count; i++)
            {
                if (list[start] ==list[i])
                {
                    length++;
                }
                else
                {
                    start = i;
                    length = 1;
                }
                if (bestLength<length)
                {
                    bestLength = length;
                    bestStart = start;
                }
            }
            for (int i = bestStart; i < bestLength+bestStart; i++)
            {
                Console.Write(list[i]+" ");
            }
        }
    }
}
