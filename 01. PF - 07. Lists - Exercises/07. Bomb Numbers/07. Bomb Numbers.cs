using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Bomb_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequenceOfNumber = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            List<int> bomb = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int bombLeft = 0;
            int bombRight = 0;
            for (int i = 0; i < sequenceOfNumber.Count; i++)
            {
                if (sequenceOfNumber[i] == bomb[0])
                {
                    bombLeft = bomb[1];
                    while (bombLeft > 0 && i >= 1)
                    {
                        sequenceOfNumber.Remove(sequenceOfNumber[i-1]);
                        bombLeft--;
                        i--;
                    }
                    sequenceOfNumber.Remove(sequenceOfNumber[i]);
                    
                    bombRight = bomb[1];
                    while (bombRight <= sequenceOfNumber.Count && i < sequenceOfNumber.Count && bombRight > 0)
                    {

                        sequenceOfNumber.Remove(sequenceOfNumber[i]);
                        bombRight--;
                        
                    }
                    if (bomb[1] == 0)
                    {
                        i--;
                    }
                }
            }
            Console.WriteLine(sequenceOfNumber.Sum());
        }
    }
}
