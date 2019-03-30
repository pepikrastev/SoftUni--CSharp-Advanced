using System;
using System.Linq;

namespace P6.BombTheBasement
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int rows = size[0];
            int cols = size[1];

            int[][] matrix = new int[rows][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new int[cols];
            }


            int[] cordinates = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int bombRow = cordinates[0];
            int bombCol = cordinates[1];
            int radius = cordinates[2];

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - bombRow, 2) + Math.Pow(col - bombCol, 2));

                    if (radius >= distance)
                    {
                        matrix[row][col] = 1;
                    }
                }
            }

            int[][] secondMatrix = new int[cols][];

            for (int row = 0; row < secondMatrix.Length; row++)
            {
                secondMatrix[row] = new int[rows];

                for (int col = 0; col < secondMatrix[row].Length; col++)
                {
                    secondMatrix[row][col] = matrix[col][row];
                }

                secondMatrix[row] = secondMatrix[row]
                    .OrderByDescending(x => x)
                    .ToArray();
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row][col] = secondMatrix[col][row];
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[][] matrix)
        {
            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }
        }
    }
}
