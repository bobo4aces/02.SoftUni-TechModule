using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _01.Convert_base_10_to_N
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger[] input = Console.ReadLine().Split(new[] { ' ' },StringSplitOptions.RemoveEmptyEntries).Select(BigInteger.Parse).ToArray();
            BigInteger nBaseNumber = input[0];
            BigInteger decimalNumber = input[1];
            string result = "";
            while (decimalNumber > 0)
            {
                BigInteger reminder = decimalNumber % nBaseNumber;
                decimalNumber /= nBaseNumber;
                result = reminder+ result;
            }
            Console.WriteLine(result);
        }
    }
}
