﻿using System;
using System.Linq;

namespace P1.DiagonalDifference
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int[][] matrix = new int[size][];

            for (int row = 0; row < matrix.Length; row++)
            {
                matrix[row] = Console.ReadLine()
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();
            }

            int primarySum = 0;
            int secondarySum = 0;

            for (int row = 0; row < matrix.Length; row++)
            {
                primarySum += matrix[row][row];
                secondarySum += matrix[row][matrix.Length - 1 - row];
            }

            int resutl = Math.Abs(primarySum - secondarySum);
            Console.WriteLine(resutl);
        }
    }
}
