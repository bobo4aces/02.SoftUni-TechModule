using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int pokePower = int.Parse(Console.ReadLine());
            int distanceToPokeTargets = int.Parse(Console.ReadLine());
            int exhaustionFactor = int.Parse(Console.ReadLine());
            int startPokePower = pokePower;
            int halfStartPokePower = pokePower/2;
            int pokedTargetsCount = 0;
            while (pokePower>= distanceToPokeTargets)
            {
                pokePower -= distanceToPokeTargets;
                pokedTargetsCount++;
                if (pokePower==halfStartPokePower&&exhaustionFactor>=1)
                {
                    pokePower /= exhaustionFactor;
                }
            }
            Console.WriteLine(pokePower);
            Console.WriteLine(pokedTargetsCount);
        }
    }
}
