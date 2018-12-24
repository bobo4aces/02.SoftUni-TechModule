using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReversedNumber(number));
        }

        static string ReversedNumber(string number)
        {
            string reversedNumber = "";

            for (int i = number.Length-1; i >= 0; i--)
            {
                reversedNumber += number[i];
            }

            return reversedNumber;
        }
    }
}
