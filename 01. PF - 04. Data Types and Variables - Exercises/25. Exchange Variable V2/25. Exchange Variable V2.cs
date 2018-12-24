using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25.Exchange_Variable_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int oldA = a;
            a = b;
            b = oldA;
            Console.WriteLine(a);
            Console.WriteLine(b);
        }
    }
}
