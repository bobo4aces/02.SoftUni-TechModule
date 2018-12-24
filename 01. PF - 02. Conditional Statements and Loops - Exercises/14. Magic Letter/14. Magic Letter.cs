using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Magic_Letter
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstLetter = char.Parse(Console.ReadLine());
            char secondLetter = char.Parse(Console.ReadLine());
            char missingLetter = char.Parse(Console.ReadLine());
            for (int i = firstLetter; i <= secondLetter; i++)
            {
                for (int j = firstLetter; j <= secondLetter; j++)
                {
                    for (int k = firstLetter; k <= secondLetter; k++)
                    {
                        if (i!=missingLetter&& j != missingLetter && k != missingLetter)
                        {
                            Console.Write($"{(char)i}{(char)j}{(char)k} ");
                        }
                    }
                }
            }
        }
    }
}
