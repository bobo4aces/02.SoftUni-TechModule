using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Min__Max__Sum__Average
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numbersArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());
                numbersArray[i] = number;
            }
            Console.WriteLine($"Sum = {numbersArray.Sum()}");
            Console.WriteLine($"Min = {numbersArray.Min()}");
            Console.WriteLine($"Max = {numbersArray.Max()}");
            Console.WriteLine($"Average = {numbersArray.Average()}");
        }
    }
}
