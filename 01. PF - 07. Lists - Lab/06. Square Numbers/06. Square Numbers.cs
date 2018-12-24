using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Square_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> squareNumbersList = new List<int>();
            for (int i = 0; i < list.Count; i++)
            {
                double number = list[i];
                if (Math.Sqrt(number)==(int)Math.Sqrt(number))
                {
                    squareNumbersList.Add(list[i]);
                }
            }
            squareNumbersList.Sort((a, b) => b.CompareTo(a));
            Console.WriteLine(string.Join(" ",squareNumbersList));
        }
    }
}
