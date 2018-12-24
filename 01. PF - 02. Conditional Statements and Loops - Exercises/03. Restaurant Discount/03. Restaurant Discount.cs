using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Restaurant_Discount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            string hallName = "";
            double price = 0;
            if (groupSize<=50)
            {
                hallName = "Small Hall";
                switch (package)
                {
                    case "Normal":
                        price = ((2500 + 500) - ((2500 + 500) * 0.05))/groupSize;
                        break;
                    case "Gold":
                        price = ((2500 + 750) - ((2500 + 750) * 0.10)) / groupSize;
                        break;
                    case "Platinum":
                        price = ((2500 + 1000) - ((2500 + 1000) * 0.15)) / groupSize;
                        break;
                    default:
                        break;
                }
            }
            else if (51<=groupSize && groupSize <= 100)
            {
                hallName = "Terrace";
                switch (package)
                {
                    case "Normal":
                        price = ((5000 + 500) - ((5000 + 500) * 0.05)) / groupSize;
                        break;
                    case "Gold":
                        price = ((5000 + 750) - ((5000 + 750) * 0.10)) / groupSize;
                        break;
                    case "Platinum":
                        price = ((5000 + 1000) - ((5000 + 1000) * 0.15)) / groupSize;
                        break;
                    default:
                        break;
                }
            }
            else if (101 <= groupSize && groupSize <= 120)
            {
                hallName = "Great Hall";
                switch (package)
                {
                    case "Normal":
                        price = ((7500 + 500) - ((7500 + 500) * 0.05)) / groupSize;
                        break;
                    case "Gold":
                        price = ((7500 + 750) - ((7500 + 750) * 0.10)) / groupSize;
                        break;
                    case "Platinum":
                        price = ((7500 + 1000) - ((7500 + 1000) * 0.15)) / groupSize;
                        break;
                    default:
                        break;
                }
            }
            if (groupSize>=121)
            {
                Console.WriteLine("We do not have an appropriate hall.");
            }
            else
            {
                Console.WriteLine($"We can offer you the {hallName}");
                Console.WriteLine($"The price per person is {price:f2}$");
            }  
        }
    }
}
