using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Day_of_Week
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayOfWeek = int.Parse(Console.ReadLine());
            string[] daysOfWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            if (1<=dayOfWeek&&dayOfWeek<=7)
            {
                Console.WriteLine(daysOfWeek[dayOfWeek-1]);
            }
            else
            {
                Console.WriteLine("Invalid Day!");
            }
        }
    }
}
