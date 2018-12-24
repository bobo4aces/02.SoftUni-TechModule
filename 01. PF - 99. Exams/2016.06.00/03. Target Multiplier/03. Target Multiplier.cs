using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Target_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] rowsAndColumns = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            Dictionary<int, int[]> matrix = new Dictionary<int, int[]>();
            for (int i = 0; i < rowsAndColumns[0]; i++)
            {
                int[] columns = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
                matrix.Add(i, columns);
            }

            int[] targets = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();
            int rowTarget = targets[0];
            int columnTarget = targets[1];
            int cell = matrix[rowTarget][columnTarget];
            matrix = MultiplyTargets(matrix, rowTarget, columnTarget, cell);
            
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ",row.Value));
            }
        }

        static Dictionary<int, int[]> MultiplyTargets(Dictionary<int, int[]> matrix, int rowTarget, int columnTarget, int cell)
        {
            int sum = 0;
            foreach (var row in matrix)
            {
                for (int i = columnTarget-1; i <= columnTarget+1; i++)
                {
                    if (row.Key==rowTarget-1||row.Key==rowTarget+1)
                    {
                        sum+=row.Value[i];
                        row.Value[i] *= cell;
                    }
                    else if (row.Key == rowTarget)
                    {
                        if (row.Value[i]!=row.Value[columnTarget])
                        {
                            sum += row.Value[i];
                            row.Value[i] *= cell;
                        }
                    }
                }
            }
            matrix[rowTarget][columnTarget]=cell * sum;
            return matrix;
        }
    }
}
