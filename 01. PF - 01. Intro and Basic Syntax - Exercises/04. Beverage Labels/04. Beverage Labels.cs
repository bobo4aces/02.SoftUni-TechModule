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
            int energyPer100ml = int.Parse(Console.ReadLine());
            int sugarPer100ml = int.Parse(Console.ReadLine());
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{(energyPer100ml * volume)/100.0}kcal, {(sugarPer100ml*volume)/100.0}g sugars");
        }
    }
}
