using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.RainAir
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<int>> customersAndFlights = new Dictionary<string, List<int>>();
            while (input!= "I believe I can fly!")
            {
                
                if (input.Contains("="))
                {
                    string[] info = input
                        .Split(new[] { '='}, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string customerName = info[0].Trim();
                    string secondCustomerName = info[1].Trim();
                    customersAndFlights[customerName] = new List<int>(customersAndFlights[secondCustomerName]);
                }
                else
                {
                    string[] info = input
                        .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                        .ToArray();
                    string customerName = info[0];
                    List<int> flights = new List<int>();
                    flights.AddRange(info.Skip(1).Select(int.Parse).ToList());
                    if (!customersAndFlights.ContainsKey(customerName))
                    {
                        customersAndFlights.Add(customerName, flights);
                    }
                    else
                    {
                        customersAndFlights[customerName].AddRange(flights);
                    }    
                }
                input = Console.ReadLine();
            }
            foreach (var customer in customersAndFlights.OrderByDescending(c=>c.Value.Count).ThenBy(n=>n.Key))
            {
                Console.WriteLine($"#{customer.Key} ::: {string.Join(", ", customer.Value.OrderBy(n=>n))}");
            }
        }
    }
}
