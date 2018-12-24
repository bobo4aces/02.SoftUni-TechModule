using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Rectangle_Position
{
    public class Rectangle
    {
        public int Top { get; set; }
        public int Left { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Right { get { return Left + Width; } }
        public int Bottom { get { return Top + Height; } }

        public bool IsInside(Rectangle r)
        {
            bool isInLeft = Left >= r.Left;
            bool isInRight = Right <= r.Right;
            bool isInsideHorizontal = isInLeft && isInRight;
            bool isInTop = Top >= r.Top;
            bool isInBottom = Bottom <= r.Bottom;
            bool isInsideVertical = isInTop && isInBottom;
            return isInsideHorizontal && isInsideVertical;
        }
    }

    class Program
    {
        public static Rectangle ReadRectange()
        {
            int[] rectangleInfo = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Rectangle rectangle = new Rectangle()
            {
                Left = rectangleInfo.First(),
                Top = rectangleInfo.Skip(1).First(),
                Width = rectangleInfo.Skip(2).First(),
                Height = rectangleInfo.Skip(3).First()
            };
            return rectangle;
        }
        static void Main(string[] args)
        {
            Rectangle firstRectange = ReadRectange();
            Rectangle secondRectange = ReadRectange();
            Console.WriteLine(firstRectange.IsInside(secondRectange) ? "Inside" : "Not inside");
        }
    }
}
