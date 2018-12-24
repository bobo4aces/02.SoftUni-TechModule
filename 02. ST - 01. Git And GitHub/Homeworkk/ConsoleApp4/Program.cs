using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            if (num < 0)
            {
                Console.WriteLine("invalid number");
            }
            if (num >= 101)
            {
                Console.WriteLine("invalid number");
            }
            string words = "";
            var unitsMap = new[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            var tensMap = new[] { "zero", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety", "one hundred" };


            if (num >= 0)
            {
                if (num < 20)
                {
                    words += unitsMap[num];
                    Console.WriteLine(words);
                }



                else if (num <= 100)
                {
                    words += tensMap[num / 10];
                    if (num % 10 > 0)
                        words += " " + unitsMap[num % 10];
                    Console.WriteLine(words);
                }
            }

        }

    }
}
