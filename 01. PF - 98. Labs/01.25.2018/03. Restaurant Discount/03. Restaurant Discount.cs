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

            double price = 0;
            double pricePerPerson = 0;

            string hallType = "";

            if (groupSize>120)
            {
                Console.WriteLine("We do not have an appropriate hall.");
                return;
            }
            else if (groupSize<=50)
            {
                hallType = "Small Hall";
                if (package=="Normal")
                {
                    price = (2500 + 500) - (2500 + 500) * 0.05;
                    pricePerPerson = price / groupSize;
                }
                else if (package=="Gold")
                {
                    price = (2500 + 750) - (2500 + 750) * 0.10;
                    pricePerPerson = price / groupSize;
                }
                else if (package=="Platinum")
                {
                    price = (2500 + 1000) - (2500 + 1000) * 0.15;
                    pricePerPerson = price / groupSize;
                }
            }
            else if (50<groupSize&&groupSize<=100)
            {
                hallType = "Terrace";
                if (package == "Normal")
                {
                    price = (5000 + 500) - (5000 + 500) * 0.05;
                    pricePerPerson = price / groupSize;
                }
                else if (package == "Gold")
                {
                    price = (5000 + 750) - (5000 + 750) * 0.10;
                    pricePerPerson = price / groupSize;
                }
                else if (package == "Platinum")
                {
                    price = (5000 + 1000) - (5000 + 1000) * 0.15;
                    pricePerPerson = price / groupSize;
                }
            }
            else if (100<groupSize&&groupSize<=120)
            {
                hallType = "Great Hall";
                if (package == "Normal")
                {
                    price = (7500 + 500) - (7500 + 500) * 0.05;
                    pricePerPerson = price / groupSize;
                }
                else if (package == "Gold")
                {
                    price = (7500 + 750) - (7500 + 750) * 0.10;
                    pricePerPerson = price / groupSize;
                }
                else if (package == "Platinum")
                {
                    price = (7500 + 1000) - (7500 + 1000) * 0.15;
                    pricePerPerson = price / groupSize;
                }
            }
            Console.WriteLine($"We can offer you the {hallType}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
