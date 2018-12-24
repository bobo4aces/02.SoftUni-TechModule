using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Sentence_the_Thief
{
    class Program
    {
        static void Main(string[] args)
        {
            string idNumeralType = Console.ReadLine();
            int idCount = int.Parse(Console.ReadLine());
            long id = 0;
            long thiefID= long.MinValue;
            for (int i = 0; i < idCount; i++)
            {
                id = long.Parse(Console.ReadLine());
                switch (idNumeralType)
                {
                    case "sbyte":
                        if (id<=sbyte.MaxValue&&thiefID<=id)
                        {
                            thiefID = id;
                        }
                        break;
                    case "int":
                        if (id <= int.MaxValue && thiefID <= id)
                        {
                            thiefID = id;
                        }
                        break;
                    case "long":
                        if (id <= long.MaxValue && thiefID <= id)
                        {
                            thiefID = id;
                        }
                        break;
                    default:
                        break;
                }
            }
            decimal thiefSentence = 0;
            if (thiefID>0)
            {
                thiefSentence = (decimal)thiefID / sbyte.MaxValue;
            }
            else
            {
                thiefSentence = Math.Abs((decimal)thiefID / sbyte.MinValue);
            }
            if (thiefSentence <=1)
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {Math.Ceiling(thiefSentence)} year");
            }
            else
            {
                Console.WriteLine($"Prisoner with id {thiefID} is sentenced to {Math.Ceiling(thiefSentence)} years");
            }
        }
    }
}
