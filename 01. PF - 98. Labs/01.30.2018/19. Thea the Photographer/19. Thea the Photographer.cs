using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19.Thea_the_Photographer
{
    class Program
    {
        static void Main(string[] args)
        {
            int pictures = int.Parse(Console.ReadLine());
            int filteredTime = int.Parse(Console.ReadLine());
            int filteredFactor = int.Parse(Console.ReadLine());
            int timeToUpload = int.Parse(Console.ReadLine());

            int filteredPictures = (int)Math.Ceiling(pictures - (double)(pictures * filteredFactor) / 100);
            int totalPicturesTime = pictures * filteredTime;
            int uploadTime = filteredTime * timeToUpload;
            int totalTime = uploadTime + totalPicturesTime;

            TimeSpan timeResult = TimeSpan.FromSeconds(totalTime);

            string formatResult = @"d\:hh\:mm\:ss";

            Console.WriteLine(timeResult.ToString(formatResult));
        }
    }
}
