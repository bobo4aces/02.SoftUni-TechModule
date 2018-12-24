using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _02.Convert_base_N_to_10
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();
            BigInteger nBaseNumber = input[0];
            BigInteger decimalNumber = input[1];
            BigInteger result = 0;
            string decimalNumberAsText = decimalNumber.ToString();
            for (int i = 0; i < decimalNumberAsText.Length; i++)
            {
                BigInteger reminder = decimalNumber % 10;
                decimalNumber/= 10;
                BigInteger number = reminder * BigInteger.Pow(nBaseNumber, i);
                result += number;
            }
            Console.WriteLine(result);
        }
    }
}
