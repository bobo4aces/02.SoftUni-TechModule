using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Fold_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int k = array.Length / 4;

            int[] upperLeftRow = array.Take(k).Reverse().ToArray();
            int[] upperRightRow = array.Reverse().Take(k).ToArray();
            int[] firstRow = upperLeftRow.Concat(upperRightRow).ToArray();
            int[] secondRow = array.Skip(k).Take(2*k).ToArray();

            var sumArray = firstRow.Select((x, index) => x + secondRow[index]);
            Console.WriteLine(string.Join(" ",sumArray));
        }
    }
}
