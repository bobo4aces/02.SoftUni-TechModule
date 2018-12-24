using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Triple_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            bool isTripleSumExist = false;
            for (int a = 0; a < array.Length; a++)
            {

                for (int b = a+1; b < array.Length; b++)
                {
                    int sum = array[a] + array[b];
                    if (array.Contains(sum))
                    {
                        isTripleSumExist = true;
                        Console.WriteLine($"{array[a]} + {array[b]} == {array[a] + array[b]}");
                    }
                }
            }
            if (!isTripleSumExist)
            {
                Console.WriteLine("No");
            }
        }
    }
}
