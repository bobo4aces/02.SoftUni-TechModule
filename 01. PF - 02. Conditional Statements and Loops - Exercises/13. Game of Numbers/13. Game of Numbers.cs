using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13.Game_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int lastFirstNumber = 0;
            int lastSecondNumber = 0;
            int combinationsCount = 0;
            for (int i = n; i <= m; i++)
            {
                for (int j = n; j <= m; j++)
                {
                    combinationsCount++;
                    if (i+j==magicNumber)
                    {
                        lastFirstNumber = i;
                        lastSecondNumber = j;
                    }
                }
            }
            if (lastFirstNumber>0&&lastSecondNumber>0)
            {
                Console.WriteLine($"Number found! {lastFirstNumber} + {lastSecondNumber} = {magicNumber}");
            }
            else
            {
                Console.WriteLine($"{combinationsCount} combinations - neither equals {magicNumber}");
            }
        }
    }
}
