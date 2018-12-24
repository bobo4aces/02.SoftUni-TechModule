using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14.Boat_Simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            char firstBoatChar = char.Parse(Console.ReadLine());
            char secondBoatChar = char.Parse(Console.ReadLine());
            int linesCount = int.Parse(Console.ReadLine());
            int firstBoatSpeed = 0;
            int secondBoatSpeed = 0;
            for (int i = 1; i <= linesCount; i++)
            {
                string tiles = Console.ReadLine();
                if (tiles == "UPGRADE")
                {
                    firstBoatChar += (char)3;
                    secondBoatChar += (char)3;
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        secondBoatSpeed += tiles.Length;
                    }
                    else
                    {
                        firstBoatSpeed += tiles.Length;
                    }
                }
                if (firstBoatSpeed>=50)
                {
                    Console.WriteLine(firstBoatChar);
                    return;
                }
                else if (secondBoatSpeed >= 50)
                {
                    Console.WriteLine(secondBoatChar);
                    return;
                }
            }
            if (firstBoatSpeed> secondBoatSpeed)
            {
                Console.WriteLine((char)firstBoatChar);
            }
            else
            {
                Console.WriteLine((char)secondBoatChar);
            }
        }
    }
}
