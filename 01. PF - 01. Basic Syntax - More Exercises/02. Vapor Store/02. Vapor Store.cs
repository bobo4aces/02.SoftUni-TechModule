using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vapor_Store
{
    class Program
    {
        static void Main(string[] args)
        {
            double currentBalance = double.Parse(Console.ReadLine());
            string game = Console.ReadLine();
            double spentMoney = 0;
            while (game != "Game Time")
            {
                
                if (game== "OutFall 4"&&currentBalance>= 39.99)
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= 39.99;
                    spentMoney += 39.99;
                }
                else if (game == "CS: OG" && currentBalance >= 15.99)
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= 15.99;
                    spentMoney += 15.99;
                }
                else if (game == "Zplinter Zell" && currentBalance >= 19.99)
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= 19.99;
                    spentMoney += 19.99;
                }
                else if (game == "Honored 2" && currentBalance >= 59.99)
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= 59.99;
                    spentMoney += 59.99;
                }
                else if (game == "RoverWatch" && currentBalance >= 29.99)
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= 29.99;
                    spentMoney += 29.99;
                }
                else if (game == "RoverWatch Origins Edition" && currentBalance >= 39.99)
                {
                    Console.WriteLine($"Bought {game}");
                    currentBalance -= 39.99;
                    spentMoney += 39.99;
                }
                else if (game != "OutFall 4" && game != "CS: OG"&& game != "Zplinter Zell" && game!= "Honored 2" && game != "RoverWatch" && game != "RoverWatch Origins Edition")
                {
                    Console.WriteLine("Not Found");
                }
                else
                {
                    Console.WriteLine("Too Expensive");
                }
                if (currentBalance==0)
                {
                    Console.WriteLine("Out of money!");
                    return;
                }
                game = Console.ReadLine();
            }
            Console.WriteLine($"Total spent: ${spentMoney:f2}. Remaining: ${currentBalance:f2}");
        }
    }
}
