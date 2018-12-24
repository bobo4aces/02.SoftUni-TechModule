using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (var i = 1; i <= n; i++)
            {
                string astericks = new string('*', n);
                string spaces = new string(' ', n-i);
                Console.Write(astericks);
                Console.Write(spaces);
                Console.WriteLine(spaces);
        
                
            }
        }
    }
}
