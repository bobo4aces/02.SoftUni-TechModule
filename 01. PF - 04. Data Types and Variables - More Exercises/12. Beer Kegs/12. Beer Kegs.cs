using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Beer_Kegs
{
    class Program
    {
        static void Main(string[] args)
        {
            int linesCount = int.Parse(Console.ReadLine());
            double biggestKegVolume = double.MinValue;
            string biggestKegModel = "";
            for (int i = 0; i < linesCount; i++)
            {
                string modelKeg = Console.ReadLine();
                double radiusKeg = double.Parse(Console.ReadLine());
                int heightKeg = int.Parse(Console.ReadLine());
                double volumeKeg = Math.PI * Math.Pow(radiusKeg, 2) * heightKeg;
                if (volumeKeg>=biggestKegVolume)
                {
                    biggestKegVolume = volumeKeg;
                    biggestKegModel = modelKeg;
                }
            }
            Console.WriteLine($"{biggestKegModel}");
            
        }
    }
}
