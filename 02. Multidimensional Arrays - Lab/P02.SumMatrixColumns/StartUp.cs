using System;
using System.Linq;

namespace P02.SumMatrixColumns
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int[][] matrix = new int[size[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }

            for (int col = 0; col < size[1]; col++)
            {
                int sum = 0;

                for (int row = 0; row < matrix.Length; row++)
                {
                    sum += matrix[row][col];
                }
                Console.WriteLine(sum);
            }
        }
    }
}
