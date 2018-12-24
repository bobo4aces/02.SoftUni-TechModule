using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Pairs_by_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split(' ', StringSplitOptions).Select(int.Parse).ToArray();

            int difference = int.Parse(Console.ReadLine());

            int result = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentDigit = arr[i];
                for (int j = i; j < arr.Length; j++)
                {
                    if (Math.Abs(currentDigit-arr[i])==difference)
                    {
                        result++;
                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
