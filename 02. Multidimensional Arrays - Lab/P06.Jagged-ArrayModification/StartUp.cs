using System;
using System.Linq;

namespace P06.Jagged_ArrayModification
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int row = 0; row < matrix.Length; row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                matrix[row] = colElements;
            }

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                string[] command = input.Split();

                int indexRow = int.Parse(command[1]);
                int indexCol = int.Parse(command[2]);
                int value = int.Parse(command[3]);

                if (command[0] == "Add")
                {

                    if (indexRow < 0 || indexRow > size - 1 || indexCol < 0 || indexCol > size - 1)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }

                    matrix[indexRow][indexCol] += value;
                }
                else if (command[0] == "Subtract")
                {
                    if (indexRow < 0 || indexRow > size || indexCol < 0 || indexCol > size)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }

                    matrix[indexRow][indexCol] -= value;
                }
            }

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
