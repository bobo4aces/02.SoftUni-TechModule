//CONFIRMED from bobo4aces
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
            //In the next four lines we receive from the Console 4 integers, representing parts of the Debit Card Number
			int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int fourthNumber = int.Parse(Console.ReadLine());
			//We print on the Console all parts of the Debit Card Number with the appropriate formating
            Console.WriteLine($"{firstNumber:D4} {secondNumber:d4} {thirdNumber:D4} {fourthNumber:D4}");
        }
    }
}
