using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Debit_Card_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
            Console.WriteLine($"{firstNumber:d4} {secondNumber:d4} {thirdNumber:d4} {fourthNumber:d4}");
            //Console.WriteLine("{0:d4} {1:d4} {2:d4} {3:d4}",firstNumber,secondNumber,thirdNumber,fourthNumber);
            //Console.WriteLine($"{firstNumber:0000.0000}");
        }
    }
}
