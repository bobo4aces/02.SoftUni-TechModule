using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialSeq = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int initialIndex = initialSeq[initialSeq.Count - 1];
            string unchangedSeq = "";
            initialSeq.RemoveAt(initialSeq.Count - 1);
            int counter = 0;

            foreach (var el in initialSeq)
            {
                unchangedSeq += " " + el;
            }
            while (initialSeq[initialIndex] != 0)
            {
                for (int i = 0; i < initialSeq.Count; i++)
                {
                    initialSeq[i] -= 1;
                }
                if (initialSeq[initialIndex] == 0)
                {
                    Console.WriteLine(string.Join(" ", initialSeq));
                    Console.WriteLine(counter);
                    break;
                }
                List<int> toSearch = unchangedSeq.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
                for (int element = 0; element <= initialSeq.Count - 1; element++)
                {
                    if (initialSeq[element] == 0)
                    {
                        int value = toSearch[element];
                        initialSeq[element] = value;
                    }
                }
                counter++;
                initialIndex = int.Parse(Console.ReadLine());
            }
        }
    }
}