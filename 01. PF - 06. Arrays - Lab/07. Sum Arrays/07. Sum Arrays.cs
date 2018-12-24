using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sum_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int longestArrayLength = Math.Max(firstArray.Length, secondArray.Length);

            int[] sumArray = new int[longestArrayLength];

            for (int i = 0; i < longestArrayLength; i++)
            {
                sumArray[i] += firstArray[i%firstArray.Length];
                sumArray[i] += secondArray[i%secondArray.Length];
            }
            for (int i = 0; i < sumArray.Length; i++)
            {
                Console.Write(sumArray[i]+" ");
            }
        }
    }
}
