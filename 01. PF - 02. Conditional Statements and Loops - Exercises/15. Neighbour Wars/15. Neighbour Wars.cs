using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Neighbour_Wars
{
    class Program
    {
        static void Main(string[] args)
        {
            int peshosDamage = int.Parse(Console.ReadLine());
            int goshosDamage = int.Parse(Console.ReadLine());
            int peshosHealth = 100;
            int goshosHealth = 100;
            int turn = 0;
            while (peshosHealth>=1&&goshosHealth>=1)
            {
                turn++;
                if (turn % 2 == 0)
                {
                    peshosHealth = peshosHealth - goshosDamage;
                    if (peshosHealth >= 1)
                    {
                        Console.WriteLine($"Gosho used Thunderous fist and reduced Pesho to {peshosHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Gosho won in {turn}th round.");
                        return;
                    }
                }
                else
                {
                    goshosHealth = goshosHealth - peshosDamage;
                    if (goshosHealth >= 1)
                    {
                        Console.WriteLine($"Pesho used Roundhouse kick and reduced Gosho to {goshosHealth} health.");
                    }
                    else
                    {
                        Console.WriteLine($"Pesho won in {turn}th round.");
                        return;
                    }
                }
                if (turn % 3 == 0)
                {
                    peshosHealth += 10;
                    goshosHealth += 10;
                }
            }
        }
    }
}
