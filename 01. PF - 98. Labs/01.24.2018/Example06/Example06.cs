using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example06
{
    class Example06
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            if (age<0||age>122)
            {
                Console.WriteLine("Error");
                return;
            }
            if (dayType=="Weekday")
            {
                if (18<age&&age<=64)
                {
                    Console.WriteLine("18$");
                }
                else
                {
                    Console.WriteLine("12$");
                }
            }
            else if (dayType=="Weekend")
            {
                if (18 < age && age <= 64)
                {
                    Console.WriteLine("20$");
                }
                else
                {
                    Console.WriteLine("15$");
                }
            }
            else
            {
                if (0<=age&&age<=18)
                {
                    Console.WriteLine("5$");
                }
                else if (18 < age && age <= 64)
                {
                    Console.WriteLine("12$");
                }
                else
                {
                    Console.WriteLine("10$");
                }
            }
        }
    }
}
