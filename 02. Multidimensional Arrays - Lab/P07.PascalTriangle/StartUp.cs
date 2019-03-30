using System;

namespace P07.PascalTriangle
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            long[][] matrix = new long[size][];

            for (int i = 1; i <= matrix.Length; i++)
            {
                matrix[i - 1] = new long[i];
                matrix[i - 1][0] = 1;
                matrix[i - 1][matrix[i - 1].Length - 1] = 1;
            }

            for (int i = 2; i < size; i++)
            {
                for (int j = 1; j < matrix[i].Length - 1; j++)
                {
                    matrix[i][j] = matrix[i - 1][j - 1] + matrix[i - 1][j];
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }

        }
    }
}
