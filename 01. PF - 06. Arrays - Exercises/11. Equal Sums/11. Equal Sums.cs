using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Equal_Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isExists = false;
            for (int i = 0; i <= array.Length-1; i++)
            {
                int leftSum = 0;
                int rightSum = 0;
                for (int j = 0; j < i; j++)
                {
                    leftSum += array[j];
                }
                for (int k = array.Length-1; k > i; k--)
                {
                    rightSum += array[k];
                }
                if (rightSum==leftSum)
                {
                    isExists = true;
                    Console.WriteLine(i);   
                }
            }
            if (!isExists)
            {
                Console.WriteLine("no");
            }
        }
    }
}
