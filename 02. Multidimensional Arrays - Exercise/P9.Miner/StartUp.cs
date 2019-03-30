using System;
using System.Linq;

namespace P9.Miner
{
    class StartUp
    {
        public static void Main()
        {
            int size = int.Parse(Console.ReadLine());

            string[] command = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            char[,] matrix = new char[size, size];

            int minerRow = -1;
            int minerCol = -1;
            int countCoal = 0;

            for (int row = 0; row < size; row++)
            {
                char[] colElements = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(char.Parse)
                    .ToArray();

                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colElements[col];

                    if (matrix[row, col] == 's')
                    {
                        minerRow = row;
                        minerCol = col;
                        matrix[row, col] = '*';
                    }
                    else if (matrix[row, col] == 'c')
                    {
                        countCoal++;
                    }
                }
            }

            for (int i = 0; i < command.Length; i++)
            {
                switch (command[i])
                {
                    case "down":
                        if (minerRow + 1 < size)
                        {
                            minerRow += 1;
                        }
                        break;
                    case "up":
                        if (minerRow - 1 >= 0)
                        {
                            minerRow -= 1;
                        }
                        break;
                    case "left":
                        if (minerCol - 1 >= 0)
                        {
                            minerCol -= 1;
                        }
                        break;
                    case "right":
                        if (minerCol + 1 < size)
                        {
                            minerCol += 1;
                        }
                        break;
                }

                switch (matrix[minerRow, minerCol])
                {
                    case 'e':
                        Console.WriteLine($"Game over! ({minerRow}, {minerCol})");
                        return;
                    case 'c':
                        countCoal--;
                        matrix[minerRow, minerCol] = '*';
                        if (countCoal == 0)
                        {
                            Console.WriteLine($"You collected all coals! ({minerRow}, {minerCol})");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine($"{countCoal} coals left. ({minerRow}, {minerCol})");
        }
    }
}
