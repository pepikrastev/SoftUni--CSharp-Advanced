using System;
using System.Linq;

namespace P4.MatrixShuffling
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int[] size = Console.ReadLine()
                .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string[][] matrix = new string[size[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                string[] colElements = Console.ReadLine()
                    .Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                matrix[row] = colElements;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] commands = input.Split();

                if (commands[0] != "swap" || commands.Length != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int newRow = int.Parse(commands[3]);
                int newCol = int.Parse(commands[4]);

                if (row < 0 || row >= matrix.Length ||
                    col < 0 || col >= matrix[row].Length ||
                    newRow < 0 || newRow >= matrix.Length ||
                    newCol < 0 || newCol >= matrix[row].Length)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }

                string firstElement = matrix[row][col];
                string secondElement = matrix[newRow][newCol];

                matrix[row][col] = secondElement;
                matrix[newRow][newCol] = firstElement;

                PrintMatrix(matrix);
            }
        }

        private static void PrintMatrix(string[][] matrix)
        {
            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    Console.Write(matrix[row][col] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
