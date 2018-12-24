using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Multiply_big_number
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());
            if (multiplier==0)
            {
                Console.WriteLine(0);
                return;
            }
            StringBuilder sb = new StringBuilder();
            int reminder = 0;
            for (int i = number.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(number[i].ToString());
                int currentResult = currentDigit * multiplier+reminder;
                sb.Append(currentResult % 10);
                reminder = currentResult / 10;
            }

            if (reminder!=0)
            {
                Console.Write($"{reminder}");
            }
            Console.WriteLine(string.Concat(sb.ToString().Reverse()));
        }
    }
}
