using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_of_the_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());

            for (int symbol = startNumber; symbol <= endNumber; symbol++)
            {
                if (symbol==endNumber)
                {
                    Console.Write((char)symbol);
                }
                else
                {
                    Console.Write((char)symbol + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
