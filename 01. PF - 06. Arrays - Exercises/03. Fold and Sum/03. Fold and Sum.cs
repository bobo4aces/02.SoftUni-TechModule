using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().Replace("  ", " ");
            while (input.Contains("  "))
            {
                input = input.Replace("  ", " ");
            }
            int[] array = input.Split(' ').Select(int.Parse).ToArray();
            int newArrayLength = (array.Length) / 2;
            int kNumbers = (array.Length) / 4;
            int[] firstRow = new int[newArrayLength];
            int[] secondRow = new int[newArrayLength];
            int[] sumRow = new int[newArrayLength];
            int counter = 1;
            for (int i = 0; i <= newArrayLength - 1; i++)
            {
                if (i <= (newArrayLength - 1) / 2)
                {
                    firstRow[(kNumbers - 1) - i] = array[i];
                }
                else
                {
                    firstRow[i] = array[array.Length - counter];
                    counter++;
                }
                secondRow[i] = array[kNumbers + i];


            }
            for (int i = 0; i < sumRow.Length; i++)
            {
                sumRow[i] += firstRow[i] + secondRow[i];
            }
            Console.WriteLine(string.Join(" ", sumRow));
        }
    }
}
