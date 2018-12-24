using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numbersOfLines = int.Parse(Console.ReadLine());
            int bracketsCount = 0;

            for (int i = 0; i < numbersOfLines; i++)
            {
                string inputString = Console.ReadLine();
                if (inputString=="(")
                {
                    bracketsCount++;
                }
                else if (inputString == ")")
                {
                    bracketsCount--;
                    if (bracketsCount<0)
                    {
                        bracketsCount = int.MaxValue;
                    }
                }
            }

            if (bracketsCount==0)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            } 
        }
    }
}
