using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Character_Stats
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int currentHealth = int.Parse(Console.ReadLine());
            int maximumHealth = int.Parse(Console.ReadLine());
            int currentEnergy = int.Parse(Console.ReadLine());
            int maximumEnergy = int.Parse(Console.ReadLine());
            string healthAsText = new string('|', currentHealth);
            string healthMissing = new string('.', maximumHealth - currentHealth);
            string energyAsText = new string('|', currentEnergy);
            string energyMissing = new string('.', maximumEnergy - currentEnergy);
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Health: |{healthAsText}{healthMissing}|");
            Console.WriteLine($"Energy: |{energyAsText}{energyMissing}|");
            //Console.Write("111"+System.Environment.NewLine+"2222");
        }
    }
}
