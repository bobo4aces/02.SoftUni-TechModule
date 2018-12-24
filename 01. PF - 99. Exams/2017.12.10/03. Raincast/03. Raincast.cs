using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Raincast
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> raincasts = new List<string>();
            string typePattern = @"^Type: (Normal|Warning|Danger)$";
            string sourcePattern = @"^Source: ([a-zA-Z0-9]+)$";
            string forecastPattern = @"^Forecast: ([^!.,?]+)$";
            string inputLine = "";
            string currentLine = "type";
            string currentRaincast = "";
            while (inputLine != "Davai Emo")
            {
                inputLine = Console.ReadLine();
                if (currentLine == "type")
                {
                    if (Regex.IsMatch(inputLine, typePattern))
                    {
                        currentRaincast = $"({Regex.Match(inputLine, typePattern).Groups[1]})";
                        currentLine = "source";
                    }
                }
                else if (currentLine == "source")
                {
                    if (Regex.IsMatch(inputLine, sourcePattern))
                    {
                        currentRaincast += " " + "***" + " ~ " + $"{Regex.Match(inputLine, sourcePattern).Groups[1]}";
                        currentLine = "forecast";
                    }
                }
                else if (currentLine == "forecast")
                {
                    if (Regex.IsMatch(inputLine, forecastPattern))
                    {
                        currentRaincast = currentRaincast.Replace("***", Regex.Match(inputLine, forecastPattern).Groups[1].Value);
                        raincasts.Add(currentRaincast);
                        currentLine = "type";
                    }
                }
            }
            foreach (var raincast in raincasts)
            {
                Console.WriteLine(raincast);
            }
        }
    }
}
