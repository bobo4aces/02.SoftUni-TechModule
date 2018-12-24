using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Pokemon_Don_t_Go
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine()
                .Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();
            int sum = 0;
            while (sequence.Count!=0)
            {
                int index = int.Parse(Console.ReadLine());
                int removedNumber = 0;
                if (index<0)
                {
                    int lastNumber = sequence[sequence.Count - 1];
                    removedNumber = sequence[0];
                    sequence.RemoveAt(0);
                    sequence.Insert(0, lastNumber);
                }
                else if (index>=sequence.Count)
                {
                    int firstNumber = sequence[0];
                    removedNumber = sequence[sequence.Count - 1];
                    sequence.RemoveAt(sequence.Count - 1);
                    sequence.Insert(sequence.Count - 1, firstNumber);
                }
                else
                {
                    removedNumber = sequence[index];
                    sequence.RemoveAt(index);
                }
                sum += removedNumber;
                for (int i = 0; i < sequence.Count; i++)
                {
                    if (sequence[i] <= removedNumber)
                    {
                        sequence[i] += removedNumber;
                    }
                    else
                    {
                        sequence[i] -= removedNumber;
                    }
                }
                
            }
            Console.WriteLine(sum);
        }
    }
}
