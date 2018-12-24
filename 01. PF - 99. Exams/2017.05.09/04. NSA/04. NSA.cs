using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NSA
{
    public class Spy
    {
        public string CountryName { get; set; }
        public Dictionary<string,long> SpyNameAndDaysInService { get; set; }
        public long DaysInService { get; set; }

        public Spy(string countryName,string spyName,long daysInService)
        {
            CountryName = countryName;
            SpyNameAndDaysInService = new Dictionary<string, long>();
            SpyNameAndDaysInService.Add(spyName, daysInService);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<Spy>> countryNameBySpy = new Dictionary<string, List<Spy>>();
            while (input != "quit")
            {
                string[] info = input
                    .Split(new[] { ' ', '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();
                Spy spy = new Spy(info[0], info[1], long.Parse(info[2]));
                if (!countryNameBySpy.ContainsKey(info[0]))
                {
                    countryNameBySpy.Add(info[0], new List<Spy>());
                    countryNameBySpy[info[0]].Add(spy);
                }
                else
                {
                    if (countryNameBySpy)
                    {

                    }
                    foreach (var country in countryNameBySpy)
                    {
                        if (true)
                        {

                        }
                    }
                }
                if (!countryNameBySpy.ContainsValue.spy.SpyNameAndDaysInService)
                {
                    countryNameBySpy[info[0]] = spy;
                }
                countryNameBySpy[info[0]].DaysInService=spy.DaysInService;

                input = Console.ReadLine();
            }
            foreach (var country in countryNameBySpy.OrderByDescending(s=>s.Value.SpyName.Count()))
            {
                Console.WriteLine($"Country: {country.Key}");
                foreach (var spy in countryNameBySpy.Where(c=>c.Key==country.Key).OrderByDescending(x=>x.Value.DaysInService))
                {
                    Console.WriteLine($"**{spy.Value.SpyName} : {spy.Value.DaysInService}");
                }
            }
        }
    }
}
