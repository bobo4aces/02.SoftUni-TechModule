using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _28.Increment_Variable
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            byte currentByte = 0;
            int overflow = 0;
            bool isOverFlowed = false;
            for (int i = 0; i < number; i++)
            {
                currentByte++;
                if (currentByte == 0)
                {
                    overflow++;
                    isOverFlowed = true;
                }
            }
            Console.WriteLine(currentByte);
            if (isOverFlowed)
            {
                Console.WriteLine($"Overflowed {overflow} times");
            }
        }
    }
}
