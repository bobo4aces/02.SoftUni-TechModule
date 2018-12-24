using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Pokemon_Evolution
{
    class Pokemon
    {
        public string PokemonName { get; set; }
        public Dictionary<string, List<int>> EvolutionTypeAndIndex { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            List<Pokemon> pokemons = new List<Pokemon>();
            Dictionary<string, List<int>> evolutionTypeAndIndex = new Dictionary<string, List<int>>();
            while (input[0] != "wubbalubbadubdub")
            {
                string pokemonName = input[0];
                if (input.Length <= 1)
                {
                    foreach (var poke in pokemons)
                    {
                        if (poke.PokemonName == pokemonName)
                        {
                            Console.WriteLine($"# {pokemonName}");
                            foreach (var type in poke.EvolutionTypeAndIndex)
                            {
                                foreach (var index in type.Value)
                                {
                                    Console.WriteLine($"{type.Key} <-> {index}");
                                }
                                
                            }
                        }
                    }
                    break;
                }

                string evolutionType = input[1];
                int evolutionIndex = int.Parse(input[2]);

                Pokemon pokemon = new Pokemon()
                {
                    PokemonName = pokemonName,
                    EvolutionTypeAndIndex = new Dictionary<string, List<int>>()
                };

                if (!pokemons.Contains(pokemon))
                {
                    pokemons.Add(pokemon);
                }
                if (!pokemon.EvolutionTypeAndIndex.ContainsKey(evolutionType))
                {
                    List<int> evolutionList = new List<int>();
                    evolutionList.Add(evolutionIndex);
                    pokemon.EvolutionTypeAndIndex.Add(evolutionType, evolutionList);
                }
                else
                {
                    pokemon.EvolutionTypeAndIndex[evolutionType].Add(evolutionIndex);
                }

                input = Console.ReadLine()
                .Split(new char[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            }
        }
    }
}
