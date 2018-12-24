using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example03
{
    class Example03
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;

            var result = a > b ? "First" : "Not First";
            if (a > b)
            {
                Console.WriteLine("First");
            }
            else
            {
                Console.WriteLine("Not First");
            }
        }
    }
}
