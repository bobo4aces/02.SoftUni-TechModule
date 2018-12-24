using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Math_Power
{
    class Program
    {
        static double GetPower(double number,int power)
        {
            double result = 1.0;
            for (int i = 1; i <= power; i++)
            {
                result *= number;
            }
            return result;
        }

        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(GetPower(number,power));
        }
    }
}
