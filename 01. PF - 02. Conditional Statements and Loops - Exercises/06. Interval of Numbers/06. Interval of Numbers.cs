using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Interval_of_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            for (int i = Math.Min(startNumber,endNumber); i <=Math.Max(startNumber, endNumber); i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
