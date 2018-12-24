using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int k = int.Parse(Console.ReadLine());
            int[] reversedArray = new int[array.Length];
            int[] sumArray = new int[array.Length];
            for (int r = 1; r <= k; r++)
            {
                for (int i = 0; i <= array.Length - 1; i++)
                {
                    reversedArray[(i + r) % array.Length] = array[i];
                    sumArray[(i + r) % array.Length] += reversedArray[(i + r) % array.Length];
                }

            }
            Console.WriteLine(string.Join(" ", sumArray));
        }
    }
}
