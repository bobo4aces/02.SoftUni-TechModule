using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.String_Concat
{
    class Program
    {
        static void Main(string[] args)
        {
            char delimiter = char.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int linesCount = int.Parse(Console.ReadLine());
            string newString = "";
            for (int i = 1; i <= linesCount; i++)
            {
                string word = Console.ReadLine();
                if (oddOrEven=="even")
                {
                    if (i%2==0)
                    {
                        newString += delimiter+word;
                    }
                }
                else if (oddOrEven == "odd")
                {
                    if (i % 2 != 0)
                    {
                        newString += delimiter + word;
                    }
                }
            }
            Console.WriteLine($"{newString.Remove(0,1)}");
        }
    }
}
