using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Theatre_Promotion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dayType = Console.ReadLine().ToLower();
            int age = int.Parse(Console.ReadLine());
            int price = 0;
            if (0<=age&&age<=18)
            {
                switch (dayType)
                {
                    case "weekday":
                        price = 12;
                        break;
                    case "weekend":
                        price = 15;
                        break;
                    case "holiday":
                        price = 5;
                        break;
                    default:
                        break;
                }
            }
            else if (19 <= age && age <= 64)
            {
                switch (dayType)
                {
                    case "weekday":
                        price = 18;
                        break;
                    case "weekend":
                        price = 20;
                        break;
                    case "holiday":
                        price = 12;
                        break;
                    default:
                        break;
                }
            }
            else if (65 <= age && age <= 122)
            {
                switch (dayType)
                {
                    case "weekday":
                        price = 12;
                        break;
                    case "weekend":
                        price = 15;
                        break;
                    case "holiday":
                        price = 10;
                        break;
                    default:
                        break;
                }
            }
            if (price>0)
            {
                Console.WriteLine($"{price}$");
            }
            else
            {
                Console.WriteLine("Error!");
            }
        }
    }
}
