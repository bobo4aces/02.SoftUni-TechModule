using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _01.Convert_from_base_10_to_base_N
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').ToArray();
            int @base = int.Parse(input[0]);
            BigInteger number = BigInteger.Parse(input[1]);

            StringBuilder reminders = new StringBuilder();

            while (number>0)
            {
                reminders.Append(number % @base);
                number /= @base;
            }

            Console.WriteLine(string.Concat(reminders.ToString().Reverse()));
        }
    }
}
