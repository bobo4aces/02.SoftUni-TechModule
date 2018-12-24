using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Tourist_Information
{
    class Program
    {
        static void Main(string[] args)
        {
            string imperialUnit = Console.ReadLine();
            decimal imperialValue = decimal.Parse(Console.ReadLine());
            switch (imperialUnit)
            {
                case "miles":
                    Console.WriteLine($"{imperialValue} {imperialUnit} = {(imperialValue*1.6M):f2} kilometers");
                    break;
                case "inches":
                    Console.WriteLine($"{imperialValue} {imperialUnit} = {(imperialValue * 2.54M):f2} centimeters");
                    break;
                case "feet":
                    Console.WriteLine($"{imperialValue} {imperialUnit} = {(imperialValue * 30M):f2} centimeters");
                    break;
                case "yards":
                    Console.WriteLine($"{imperialValue} {imperialUnit} = {(imperialValue * 0.91M):f2} meters");
                    break;
                case "gallons":
                    Console.WriteLine($"{imperialValue} {imperialUnit} = {(imperialValue * 3.8M):f2} liters");
                    break;
                default:
                    break;
            }
            
        }
    }
}
