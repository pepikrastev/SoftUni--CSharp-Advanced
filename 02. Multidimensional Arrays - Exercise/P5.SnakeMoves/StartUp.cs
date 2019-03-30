using System;
using System.Collections.Generic;
using System.Linq;

namespace P5.SnakeMoves
{
    class StartUp
    {
        public static void Main()
        {
            int[] size = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            char[] snake = Console.ReadLine().ToCharArray();

            int count = 0;

            char[][] matrix = new char[size[0]][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = new char[size[1]];

                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (count > snake.Length - 1)
                    {
                        count = 0;
                    }
                    matrix[row][col] = snake[count++];
                }
            }

            foreach (var item in matrix)
            {
                Console.WriteLine(string.Join("", item));
            }
        }
    }
}
