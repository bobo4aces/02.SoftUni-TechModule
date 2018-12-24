using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = double.Parse(Console.ReadLine());
            var currencyIn = Console.ReadLine();
            var currencyOut = Console.ReadLine();
            var bgn = 1;
            var usd = 1.79549;
            var eur = 1.95583;
            var gbp = 2.53405;
            var currencyIn1 = 1.000;
            var currencyOut1 = 1.000;
            switch (currencyIn)
            {
                case "BGN":
                    currencyIn1 = bgn;
                    break;
                case "USD":
                    currencyIn1 = usd;
                    break;
                case "EUR":
                    currencyIn1 = eur;
                    break;
                case "GBP":
                    currencyIn1 = gbp;
                    break;
            }
            switch (currencyOut)
            {
                case "BGN":
                    currencyOut1 = bgn;
                    break;
                case "USD":
                    currencyOut1 = usd;
                    break;
                case "EUR":
                    currencyOut1 = eur;
                    break;
                case "GBP":
                    currencyOut1 = gbp;
                    break;
            }
            var converter = number * currencyIn1 / currencyOut1;
            Console.WriteLine(Math.Round(converter,2)+" "+currencyOut);
        }
    }
}
