using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Most_Frequent_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int frequency = 0;
            int bestFrequency = 0;
            int number = 0;
            int frequentNumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i; j < array.Length; j++)
                {
                    if (array[i]==array[j])
                    {
                        number = array[j];
                        frequency++;
                    }
                }
                if (frequency>bestFrequency)
                {
                    frequentNumber = number;
                    bestFrequency=frequency;
                }
                frequency = 0;
            }
            Console.WriteLine(frequentNumber);
        }
    }
}
