using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Sweet_Dessert
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal cash = decimal.Parse(Console.ReadLine());
            long guestsCount = long.Parse(Console.ReadLine());
            decimal bananaPrice = decimal.Parse(Console.ReadLine());
            decimal eggsPrice = decimal.Parse(Console.ReadLine());
            decimal berriesKiloPrice = decimal.Parse(Console.ReadLine());

            long portions = guestsCount / 6;
            if (guestsCount % 6!=0)
            {
                portions++;
            }

            decimal neededMoney =(bananaPrice*2+eggsPrice*4+berriesKiloPrice*0.2M)*portions;
            if (neededMoney<=cash)
            {
                Console.WriteLine($"Ivancho has enough money - it would cost {neededMoney:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivancho will have to withdraw money - he will need {(neededMoney-cash):f2}lv more.");
            }
        }
    }
}
