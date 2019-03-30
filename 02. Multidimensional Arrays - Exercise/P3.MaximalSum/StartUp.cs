using System;
using System.Linq;

namespace P3.MaximalSum
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[][] matrix = new int[size[0]][];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                matrix[row] = colElements;
            }

            int maxSum = int.MinValue;
            int indexRow = 0;
            int indexCol = 0;

            for (int row = 0; row < size[0] - 2; row++)
            {
                for (int col = 0; col < size[1] - 2; col++)
                {
                    int currSum = matrix[row][col] + matrix[row][col + 1] + matrix[row][col + 2] +
                                  matrix[row + 1][col] + matrix[row + 1][col + 1] + matrix[row + 1][col + 2] +
                                  matrix[row + 2][col] + matrix[row + 2][col + 1] + matrix[row + 2][col + 2];

                    if (currSum > maxSum)
                    {
                        maxSum = currSum;
                        indexRow = row;
                        indexCol = col;
                    }
                }
            }

            Console.WriteLine($"Sum = {maxSum}");

            for (int row = indexRow; row < indexRow + 3; row++)
            {
                for (int col = indexCol; col < indexCol + 3; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
