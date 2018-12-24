using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Training_Hall_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberOfItems = int.Parse(Console.ReadLine());
            double subtotal = 0;
            for (int i = 0; i < numberOfItems; i++)
            {
                string nameOfItem = Console.ReadLine();
                double priceOfItem = double.Parse(Console.ReadLine());
                int itemCount = int.Parse(Console.ReadLine());
                if (itemCount==1)
                {
                    Console.WriteLine($"Adding {itemCount} {nameOfItem} to cart.");
                }
                else
                {
                    Console.WriteLine($"Adding {itemCount} {nameOfItem}s to cart.");
                }
                subtotal += priceOfItem * itemCount;  
            }
            Console.WriteLine($"Subtotal: ${subtotal:f2}");
            if (budget>=subtotal)
            {
                Console.WriteLine($"Money left: ${(budget-subtotal):f2}");
            }
            else
            {
                Console.WriteLine($"Not enough. We need ${(subtotal-budget):f2} more.");
            }
        }
    }
}
