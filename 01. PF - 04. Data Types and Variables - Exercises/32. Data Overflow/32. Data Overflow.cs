using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _32.Data_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong number1 = ulong.Parse(Console.ReadLine());
            ulong number2 = ulong.Parse(Console.ReadLine());
            ulong smallerNumber = Math.Min(number1, number2);
            ulong biggerNumber = Math.Max(number1, number2);
            string smallerType = "";
            string biggerType = "";
            double overflow = 0;
            if (byte.MinValue<= smallerNumber && smallerNumber <= byte.MaxValue)
            {
                smallerType = "byte";
                overflow = (double)biggerNumber/byte.MaxValue;
            }
            else if (ushort.MinValue <= smallerNumber && smallerNumber <= ushort.MaxValue)
            {
                smallerType = "ushort";
                overflow = (double)biggerNumber / ushort.MaxValue;
            }
            else if (uint.MinValue <= smallerNumber && smallerNumber <= uint.MaxValue)
            {
                smallerType = "uint";
                overflow = (double)biggerNumber / uint.MaxValue;
            }
            else if (ulong.MinValue <= smallerNumber && smallerNumber <= ulong.MaxValue)
            {
                smallerType = "ulong";
                overflow = (double)biggerNumber / ulong.MaxValue;
            }
            if (byte.MinValue <= biggerNumber && biggerNumber <= byte.MaxValue)
            {
                biggerType = "byte";
            }
            else if (ushort.MinValue <= biggerNumber && biggerNumber <= ushort.MaxValue)
            {
                biggerType = "ushort";
            }
            else if (uint.MinValue <= biggerNumber && biggerNumber <= uint.MaxValue)
            {
                biggerType = "uint";
            }
            else if(ulong.MinValue <= biggerNumber && biggerNumber <= ulong.MaxValue)
            {
                biggerType = "ulong";
            }
            Console.WriteLine($"bigger type: {biggerType}");
            Console.WriteLine($"smaller type: {smallerType}");
            Console.WriteLine($"{biggerNumber} can overflow {smallerType} {Math.Round(overflow,0)} times");
        }
    }
}
