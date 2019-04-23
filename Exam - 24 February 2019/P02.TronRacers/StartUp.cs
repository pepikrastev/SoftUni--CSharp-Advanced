using System;

namespace P02.TronRacers
{
    class StartUp
    {
        public static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            char[][] matrix = new char[number][];

            for (int i = 0; i < matrix.Length; i++)
            {
                matrix[i] = Console.ReadLine().ToCharArray();
            }

            int firstRow = -1;
            int firstCol = -1;
            int secondRow = -1;
            int secondCol = -1;

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (matrix[i][j] == 'f')
                    {
                        firstRow = i;
                        firstCol = j;
                    }

                    if (matrix[i][j] == 's')
                    {
                        secondRow = i;
                        secondCol = j;
                    }
                }
            }

            while (true)
            {
                string[] input = Console.ReadLine().Split();

                string firstCommand = input[0];
                string secondCommand = input[1];

                switch (firstCommand)
                {
                    case "up":
                        if (firstRow > 0)
                        {
                            firstRow--;
                        }
                        else
                        {
                            firstRow = number - 1;
                        }
                        break;
                    case "down":
                        if (firstRow < number - 1)
                        {
                            firstRow++;
                        }
                        else
                        {
                            firstRow = 0;
                        }
                        break;
                    case "left":
                        if (firstCol > 0)
                        {
                            firstCol--;
                        }
                        else
                        {
                            firstCol = matrix[0].Length - 1;
                        }
                        break;
                    case "right":
                        if (firstCol < matrix[0].Length - 1)
                        {
                            firstCol++;
                        }
                        else
                        {
                            firstCol = 0;
                        }
                        break;

                }

                if (matrix[firstRow][firstCol] == '*')
                {
                    matrix[firstRow][firstCol] = 'f';
                }
                else if (matrix[firstRow][firstCol] == 's')
                {
                    matrix[firstRow][firstCol] = 'x';
                    break;
                }

                switch (secondCommand)
                {
                    case "up":
                        if (secondRow > 0)
                        {
                            secondRow--;
                        }
                        else
                        {
                            secondRow = number - 1;
                        }
                        break;
                    case "down":
                        if (secondRow < number - 1)
                        {
                            secondRow++;
                        }
                        else
                        {
                            secondRow = 0;
                        }
                        break;
                    case "left":
                        if (secondCol > 0)
                        {
                            secondCol--;
                        }
                        else
                        {
                            secondCol = matrix[0].Length - 1;
                        }
                        break;
                    case "right":
                        if (secondCol < matrix[0].Length - 1)
                        {
                            secondCol++;
                        }
                        else
                        {
                            secondCol = 0;
                        }
                        break;

                }

                if (matrix[secondRow][secondCol] == '*')
                {
                    matrix[secondRow][secondCol] = 's';
                }
                else if (matrix[secondRow][secondCol] == 'f')
                {
                    matrix[secondRow][secondCol] = 'x';
                    break;
                }
            }

            for (int i = 0; i < matrix.Length; i++)
            {
                Console.WriteLine(string.Join("", matrix[i]));
            }
        }
    }
}
