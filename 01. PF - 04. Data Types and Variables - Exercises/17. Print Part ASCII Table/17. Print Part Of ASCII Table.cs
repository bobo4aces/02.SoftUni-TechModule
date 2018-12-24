using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startChar = int.Parse(Console.ReadLine());
            int finalChar = int.Parse(Console.ReadLine());
            for (int i = startChar; i <= finalChar; i++)
            {
                Console.Write($"{(char)i} ");
            }
        }
    }
}
