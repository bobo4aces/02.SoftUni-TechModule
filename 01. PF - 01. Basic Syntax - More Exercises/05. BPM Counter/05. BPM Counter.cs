using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BPM_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            int brm = int.Parse(Console.ReadLine());
            int numberOfBeats = int.Parse(Console.ReadLine());
            double length=(60.0/brm)*numberOfBeats;
            double minutes = 0;
            double seconds = 0;
            if (length<=59)
            {
                seconds=length;
            }
            else if (length>=60)
            {
                minutes = length / 60;
                seconds = length % 60;
            }
            double bars = Math.Round((numberOfBeats / 4.0),1);
            Console.WriteLine($"{bars} bars - {Math.Floor(minutes)}m {Math.Floor(seconds)}s");
        }
    }
}
