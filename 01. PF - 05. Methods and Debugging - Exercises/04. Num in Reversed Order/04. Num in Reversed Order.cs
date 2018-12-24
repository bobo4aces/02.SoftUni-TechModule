using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Num_in_Reversed_Order
{
    class Program
    {
        static decimal GetReversedDigits(decimal number)
        {
            string numberAsText = number.ToString();
            string reversedDigitsAsText = "";
            for (int i = numberAsText.Length - 1; i >= 0; i--)
            {
                reversedDigitsAsText += numberAsText[i];
            }
            decimal reversedDigits = decimal.Parse(reversedDigitsAsText);
            return reversedDigits;
        }

        static void Main(string[] args)
        {
            decimal number = decimal.Parse(Console.ReadLine());
            Console.WriteLine(GetReversedDigits(number));
        }
    }
}
