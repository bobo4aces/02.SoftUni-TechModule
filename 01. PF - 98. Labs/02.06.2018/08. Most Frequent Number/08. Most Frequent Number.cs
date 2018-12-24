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
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int result = 0;
            int occurances = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int currentNumber = numbers[i];
                int currentOccurances = 0;
                int totalOccurances = 0;
                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber==numbers[j])
                    {
                        currentOccurances++;
                        if (currentOccurances> totalOccurances)
                        {
                            totalOccurances = currentOccurances;
                            result = currentNumber;
                        }
                    }
                }
                Console.WriteLine(result);
            }
        }
    }
}
