using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Spyfer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> newSeq = Console.ReadLine()
                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            List<int> sequence = newSeq.ToList();
            sequence.Insert(0, int.MaxValue);
            sequence.Add(int.MaxValue);
            for (int i = 1; i < sequence.Count-1; i++)
            {
                if (sequence[i]==sequence[i-1]+sequence[i+1])
                {
                    sequence.RemoveAt(i + 1);
                    sequence.RemoveAt(i - 1);
                    i = 1;
                }
            }
            sequence.RemoveAt(0);
            sequence.RemoveAt(sequence.Count - 1);
            Console.WriteLine(string.Join(" ",sequence));
        }
    }
}
