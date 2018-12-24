using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Odd_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isEvenNumber = true;
            do
            {
                if (number % 2 != 0)
                {
                    isEvenNumber = false;
                    Console.WriteLine($"The number is: {Math.Abs(number)}");
                }
                else
                {
                    
                    Console.WriteLine($"Please write an odd number.");
                    number = int.Parse(Console.ReadLine());
                }
            } while (isEvenNumber);
        }
    }
}
