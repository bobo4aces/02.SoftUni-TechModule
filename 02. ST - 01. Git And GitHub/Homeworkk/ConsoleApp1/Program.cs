using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                string asterisks = new string('*', i);
                string spaces = new string(' ', n - i);
                Console.Write(spaces);
                Console.Write(asterisks);
                Console.Write(" | ");
                Console.Write(asterisks);
                Console.WriteLine(spaces);
            }
        }
    }
}
