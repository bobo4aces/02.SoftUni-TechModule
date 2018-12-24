using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Population_Aggregation
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Dictionary<string, long>> countryByCityByPopulation = new Dictionary<string, Dictionary<string, long>>();
            int duplicatedCountries = 0;
            while (input!="stop")
            {
                string[] info = input
                    .Split(new char[] { '\\' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                string lettersPattern = @"[A-Za-z]+";
                string countryPattern = @"[A-Z]";
                Regex lettersRegex = new Regex(lettersPattern);
                Regex countryRegex = new Regex(countryPattern);
                
                string country = "";
                string city = "";
                if (countryRegex.IsMatch(info[0]))
                {
                    MatchCollection lettersMatches = lettersRegex.Matches(info[0]);
                    foreach (Match letters in lettersMatches)
                    {
                        country += letters;
                    }
                    lettersMatches = lettersRegex.Matches(info[1]);
                    foreach (Match letters in lettersMatches)
                    {
                        city += letters;
                    }
                }
                else
                {
                    MatchCollection lettersMatches = lettersRegex.Matches(info[1]);
                    foreach (Match letters in lettersMatches)
                    {
                        country += letters;
                    }
                    lettersMatches = lettersRegex.Matches(info[0]);
                    foreach (Match letters in lettersMatches)
                    {
                        city += letters;
                    }
                }
                long population = long.Parse(info.Last());
                if (!countryByCityByPopulation.ContainsKey(country))
                {
                    Dictionary<string, long> cityByPopulation = new Dictionary<string, long>();
                    cityByPopulation.Add(city, population);
                    countryByCityByPopulation.Add(country, cityByPopulation);
                }
                if (countryByCityByPopulation[country].ContainsKey(city))
                {
                    countryByCityByPopulation[country][city] = population;
                    duplicatedCountries++;
                }
                else
                {
                    countryByCityByPopulation[country].Add(city, population);
                }
                input = Console.ReadLine();
            }
            foreach (var country in countryByCityByPopulation.OrderBy(c=>c.Key))
            {
                Console.WriteLine($"{country.Key} -> {country.Value.Keys.Count}");
            }
            int counter = 0;
            foreach (var city in countryByCityByPopulation.Where(c=>c.Value.ContainsKey(c.ToString)
            {
                Console.WriteLine($"{countryByCityByPopulation.ContainsValue[city.Value]]} -> {city}");
            }
        }
    }
}
