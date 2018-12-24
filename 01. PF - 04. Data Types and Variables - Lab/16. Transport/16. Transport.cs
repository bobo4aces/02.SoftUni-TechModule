using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Transport
{
    class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
            int capacity = 24;
            int courses = (int)Math.Ceiling((double)peopleCount / capacity);
            Console.WriteLine(courses);
        }
    }
}
