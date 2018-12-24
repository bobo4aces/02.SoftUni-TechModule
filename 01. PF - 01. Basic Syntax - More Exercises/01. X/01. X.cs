using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.X
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n/2; i++)
            {
                
                Console.Write(new string(' ', i));
                Console.Write('x');
                Console.Write(new string(' ', (n - 2) - 2*i));
                Console.WriteLine('x');
            }
            Console.Write(new string(' ', n/2));
            Console.Write('x');
            Console.WriteLine(new string(' ', n/2));
            for (int i = 0; i < n / 2; i++)
            {

                Console.Write(new string(' ', (n/2-1)-i));
                Console.Write('x');
                Console.Write(new string(' ', 1 + 2*i));
                Console.WriteLine('x');
            }
        }
    }
}
