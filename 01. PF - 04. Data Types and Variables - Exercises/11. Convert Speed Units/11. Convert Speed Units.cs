using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Convert_Speed_Units
{
    class Program
    {
        static void Main(string[] args)
        {
            int distance = int.Parse(Console.ReadLine());
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());
            int seconds = int.Parse(Console.ReadLine());
            int totalSeconds = hours * 3600 + minutes * 60 + seconds;
            float totalHours = (float)totalSeconds / 3600;
            Console.WriteLine($"{((float)distance /totalSeconds)}");
            Console.WriteLine($"{(((float)distance/1000)/totalHours)}");
            Console.WriteLine($"{(((float)distance / 1609) / totalHours)}");
        }
    }
}
