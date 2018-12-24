using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.House_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPrice = int.Parse(Console.ReadLine());
            int secondPrice = int.Parse(Console.ReadLine());
            int sbytePrice = 0;
            int intPrice = 0;
            if (firstPrice<secondPrice)
            {
                sbytePrice = firstPrice;
                intPrice = secondPrice;
            }
            else
            {
                sbytePrice = secondPrice;
                intPrice = firstPrice;
            }
            long sbyteMaterialsCost = sbytePrice * 4;
            long intMaterialsCost = (long)intPrice * 10;
            Console.WriteLine(sbyteMaterialsCost + intMaterialsCost);
        }
    }
}
