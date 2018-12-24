using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static double GetCubeFaceDiagonal(double cubeSide)
        {
            double cubeFace = Math.Sqrt(2 * Math.Pow(cubeSide, 2));
            return cubeFace;
        }

        static double GetCubeSpaceDiagonal(double cubeSide)
        {
            double cubeSpace = Math.Sqrt(3 * Math.Pow(cubeSide, 2));
            return cubeSpace;
        }

        static double GetCubeVolume(double cubeSide)
        {
            double cubeVolume = Math.Pow(cubeSide, 3);
            return cubeVolume;
        }

        static double GetCubeSurfaceArea(double cubeSide)
        {
            double cubeArea = 6 * Math.Pow(cubeSide, 2);
            return cubeArea;
        }

        static void Main(string[] args)
        {
            double cubeSide = double.Parse(Console.ReadLine());
            string cubeParameter = Console.ReadLine();
            double result = 0;
            switch (cubeParameter)
            {
                case "face":
                    result = GetCubeFaceDiagonal(cubeSide);
                    break;
                case "space":
                    result = GetCubeSpaceDiagonal(cubeSide);
                    break;
                case "volume":
                    result = GetCubeVolume(cubeSide);
                    break;
                case "area":
                    result = GetCubeSurfaceArea(cubeSide);
                    break;
                default:
                    break;
            }
            Console.WriteLine($"{result:f2}");
        }
    }
}
