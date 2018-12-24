using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18.Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int letter1 = 0; letter1 < n; letter1++)
            {
                for (int letter2 = 0; letter2 < n; letter2++)
                {
                    for (int letter3 = 0; letter3 < n; letter3++)
                    {
                        Console.WriteLine($"{(char)('a'+letter1)}{(char)('a' + letter2)}{(char)('a'+letter3)}");
                    }
                }
            }
        }
    }
}
