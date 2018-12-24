using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Rotate_and_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rotation = int.Parse(Console.ReadLine());
            int[] result = new int[numbers.Length];

            for (int rotations = 0; rotations < rotation; rotations++)
            {
                int lastdDigit = numbers[numbers.Length - 1];

                for (int index = numbers.Length-1; index > 0; index--)
                {
                    numbers[index] = numbers[index - 1];
                    result[index] += numbers[index];
                }

                numbers[0] = lastdDigit;
                result[0] += numbers[0];
            }

            for (int index = 0; index < result.Length; index++)
            {
                Console.Write(result[index]+" ");
            }

        }
    }
}
