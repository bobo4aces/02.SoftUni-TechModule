using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Resurrection
{
    class Program
    {
        static void Main(string[] args)
        {
            int phoenixCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < phoenixCount; i++)
            {
                long totalBodyLength = long.Parse(Console.ReadLine());
                decimal totalBodyWidth = decimal.Parse(Console.ReadLine());
                int singleWingLenght = int.Parse(Console.ReadLine());
                decimal totalYearsOfReincarnationPerPhoenix = (totalBodyLength * totalBodyLength) * (totalBodyWidth + 2 * singleWingLenght);
                Console.WriteLine(totalYearsOfReincarnationPerPhoenix);
            } 
        }
    }
}
