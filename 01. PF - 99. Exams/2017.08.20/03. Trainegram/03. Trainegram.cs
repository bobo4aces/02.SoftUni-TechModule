using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03.Trainegram
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<string> trains = new List<string>();
            while (input!= "Traincode!")
            {
                string locomotivePattern = @"(?<locomotive><\[[^A-Za-z0-9]+?\]?\.)";
                string wagonPattern = @"(?<wagon>\.\[[A-Za-z0-9]*\]\.)";
                Regex locomotiveRegex = new Regex(locomotivePattern);
                Regex wagonRegex = new Regex(wagonPattern);
                string locoPattern = @"(?<locomotive><\[[^A-Za-z0-9]+?\]?\.)|(?<wagon>\.\[[A-Za-z0-9]*\]\.)";
                Regex locoRegex = new Regex(locoPattern);

                string train = "";
                MatchCollection matches = wagonRegex.Matches(input);
                if (locoRegex.IsMatch(input,0))
                {
                    train += locoRegex.Match(input, 0, input.Length - 1).Value;
                    
                    trains.Add(train);
                }

                    
                
                input = Console.ReadLine();
            }
            foreach (var train in trains)
            {
                Console.WriteLine(train);
            }
        }
    }
}
