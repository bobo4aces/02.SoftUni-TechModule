using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Snowmen
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sequence = Console.ReadLine().Split(new[] {' ' },StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            List<int> result = new List<int>();
            while (sequence.Count>1)
            {
                for (int i = 0; i < sequence.Count; i++)
                {
                    int attacker = i;
                    int target = sequence[i];
                    if (target > sequence.Count)
                    {
                        target %= sequence.Count;
                    }
                    int absoluteDifference = Math.Abs(Math.Abs(attacker) - Math.Abs(target));
                    if (attacker == target)
                    {
                        Console.WriteLine($"{attacker} performed harakiri");
                        sequence[attacker] = 1001;
                        
                    }
                    else if (absoluteDifference % 2 == 0)
                    {
                        Console.WriteLine($"{attacker} x {target} -> {attacker} wins");

                    }
                    else
                    {

                        //Console.WriteLine($"{attacker} x {target} -> {target} wins");
                        sequence[attacker] = 1001;
                    }
                }
                sequence=sequence.Where(e=>e!=1001).ToList();
            }
            
        }
    }
}
