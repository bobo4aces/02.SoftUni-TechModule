using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Entertrain
{
    class Program
    {
        static void Main(string[] args)
        {
            int locomotivePower = int.Parse(Console.ReadLine());
            string weightAsText = Console.ReadLine();
            List<int> wagons = new List<int>();
            while (weightAsText != "All ofboard!")
            {
                int weight = int.Parse(weightAsText);
                wagons.Add(weight);
                if (wagons.Sum()> locomotivePower)
                {
                    int average = wagons.Sum()/ wagons.Count;
                    int minDifference = int.MaxValue;
                    int index = 0;
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        int currentDifference = Math.Abs(wagons[i] - average);
                        if (currentDifference<= minDifference)
                        {
                            minDifference = currentDifference;
                            index = i;
                        }
                    }
                    wagons.RemoveAt(index);
                }

                weightAsText = Console.ReadLine();
            }
            List<int> reversedList = new List<int>();

            for (int i = wagons.Count-1; i >=0; i--)
            {
                reversedList.Add(wagons[i]);
            }
            reversedList.Add(locomotivePower);
            Console.WriteLine(string.Join(" ", reversedList));
        }
    }
}
