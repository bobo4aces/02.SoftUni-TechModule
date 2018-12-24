using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Last_K_Numbers_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            int[] elementsArray = new int[n];
            elementsArray[0] = 1;
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                elementsArray[i] = sum;
                for (int j = i; j <= k; j++)
                {
                    sum += j;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(elementsArray[i]);
            }
        }
    }
}
