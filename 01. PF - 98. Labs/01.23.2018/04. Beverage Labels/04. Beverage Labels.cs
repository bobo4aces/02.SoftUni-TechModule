using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Beverage_Labels
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int volume = int.Parse(Console.ReadLine());
            int energy = int.Parse(Console.ReadLine());
            int sugarContent = int.Parse(Console.ReadLine());
            double calories = volume*energy/100.0;
            double sugar = volume * sugarContent / 100.0;
            Console.WriteLine($"{volume}ml {name}:\r\n{calories}kcal, {sugar}g sugars");
        }
    }
}
