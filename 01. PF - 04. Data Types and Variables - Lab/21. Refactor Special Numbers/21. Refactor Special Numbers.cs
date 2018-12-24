using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21.Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int newNumber = 0;
            bool isItSpecial = false;
            for (int i = 1; i <= number; i++)
            {
                newNumber = i;
                while (newNumber > 0)
                {
                    sum += newNumber % 10;
                    newNumber = newNumber / 10;
                }
                isItSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{i} -> {isItSpecial}");
                sum = 0;
            }
        }
    }
}
