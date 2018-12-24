using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Photo_Gallery
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int year = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int sizeInBytes = int.Parse(Console.ReadLine());
            int widthInPixels = int.Parse(Console.ReadLine());
            int heightInPixels = int.Parse(Console.ReadLine());
            string size = "";
            string orientation = "";
            if (sizeInBytes<=999)
            {
                size = sizeInBytes + "B";
            }
            else if (1000<=sizeInBytes&&sizeInBytes<=999999)
            {
                size = Math.Round((sizeInBytes / 1000.0), 1) + "KB";
            }
            else if (1000000 <= sizeInBytes)
            {
                size = Math.Round((sizeInBytes / 1000000.0),1) + "MB";
            }
            if (widthInPixels==heightInPixels)
            {
                orientation = "square";
            }
            else if (widthInPixels > heightInPixels)
            {
                orientation = "landscape";
            }
            else if (widthInPixels < heightInPixels)
            {
                orientation = "portrait";
            }
            Console.WriteLine($"Name: DSC_{number:d4}.jpg");
            Console.WriteLine($"Date Taken: {day:d2}/{month:d2}/{year} {hour:d2}:{minute:d2}");
            Console.WriteLine($"Size: {size}");
            Console.WriteLine($"Resolution: {widthInPixels}x{heightInPixels} ({orientation})");
        }
    }
}
