using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Different_Integers_Size
{
    class Program
    {
        static void Main(string[] args)
        {
            //(sbyte < byte < short < ushort < int < uint < long).
            string input = Console.ReadLine();
            try
            {
                long number = long.Parse(input);
                Console.WriteLine($"{number} can fit in:");
                if (sbyte.MinValue<=number&&number<=sbyte.MaxValue)
                {
                    Console.WriteLine($"* sbyte");
                }
                if (byte.MinValue <= number && number <= byte.MaxValue)
                {
                    Console.WriteLine($"* byte");
                }
                if (short.MinValue <= number && number <= short.MaxValue)
                {
                    Console.WriteLine($"* short");
                }
                if (ushort.MinValue <= number && number <= ushort.MaxValue)
                {
                    Console.WriteLine($"* ushort");
                }
                if (int.MinValue <= number && number <= int.MaxValue)
                {
                    Console.WriteLine($"* int");
                }
                if (uint.MinValue <= number && number <= uint.MaxValue)
                {
                    Console.WriteLine($"* uint");
                }
                if (long.MinValue <= number && number <= long.MaxValue)
                {
                    Console.WriteLine($"* long");
                }
            }
            catch (Exception)
            {

                Console.WriteLine($"{input} can't fit in any type");
            }
        }
    }
}
