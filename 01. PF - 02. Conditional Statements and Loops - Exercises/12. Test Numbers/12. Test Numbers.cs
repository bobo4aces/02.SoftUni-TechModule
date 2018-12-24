using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Test_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maximumSumBoundary = int.Parse(Console.ReadLine());
            int sum = 0;
            int combinationsCount = 0;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += (i * j) * 3;
                    combinationsCount++;
                    if (sum>=maximumSumBoundary)
                    {
                        Console.WriteLine($"{combinationsCount} combinations");
                        Console.WriteLine($"Sum: {sum} >= {maximumSumBoundary}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationsCount} combinations");
            Console.WriteLine($"Sum: {sum}");
        }
    }
}
