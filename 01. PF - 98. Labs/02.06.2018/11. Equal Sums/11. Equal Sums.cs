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
            int[] arr = Console.ReadLine().Split(StringSplitOptions.RemoveEmptyEntries,' ').Select(int.Parse).ToArray();

            bool isFound = false;

            for (int i = 0; i < arr.Length; i++)
            {
                int[] firstArray = arr.Take(i).ToArray();
                int[] secondArray = arr.Skip(i + 1).ToArray();

                if (firstArray.Sum()==secondArray.Sum())
                {
                    isFound = true;
                    Console.WriteLine(i);
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine("no");
            }
        }
    }
}
