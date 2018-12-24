using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_The_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            long picturesTaken = long.Parse(Console.ReadLine());
            long filterSeconds = long.Parse(Console.ReadLine());
            long filterFactor = long.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());
            long filteredPictures = (long)Math.Ceiling(picturesTaken * (filterFactor / 100.0));
            long totalSecondsForPictures = picturesTaken * filterSeconds;
            long totalSecondsForFiltering = filteredPictures * uploadTime;
            long totalTime = totalSecondsForPictures + totalSecondsForFiltering;
            long s = totalTime % 60;
            long m = (totalTime/60) % 60;
            long h = (totalTime/3600)%24;
            long d = totalTime/(3600 * 24);
            Console.WriteLine($"{d}:{h.ToString("00")}:{m.ToString("00")}:{s.ToString("00")}");
        }
    }
}
