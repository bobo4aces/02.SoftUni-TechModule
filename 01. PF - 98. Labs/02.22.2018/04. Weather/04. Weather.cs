using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _04.Weather
{
    public class Weather
    {
        public double AverageTemperature { get; set; }
        public string WeatherType { get; set; }

        public Weather(double avgTemp, string weatherType)
        {
            AverageTemperature = avgTemp;
            WeatherType = weatherType;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //([A-Z]{2})(\d+\.\d+)([A-Za-z+])\|
            string pattern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            string input = Console.ReadLine();

            Dictionary<string, Weather> forecast = new Dictionary<string, Weather>();
            while (!input.Equals("end"))
            {
                var match = Regex.Match(input, pattern);
                if (Regex.IsMatch(input,pattern))
                {
                    string cityName = match.Groups[1].ToString();
                    double averageTemperature = double.Parse(match.Groups[2].ToString());
                    string weatherType = match.Groups[3].ToString();
                    Weather weather = new Weather(averageTemperature, weatherType);
                    forecast[cityName] = weather;
                }
                input = Console.ReadLine();
            }

            foreach (var weather in forecast.OrderBy(e=>e.Value.AverageTemperature))
            {
                Console.WriteLine($"{weather.Key} => {weather.Value.AverageTemperature:f2} => {weather.Value.WeatherType}");
            }
        }
    }
}
