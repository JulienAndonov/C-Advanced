using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Bomb_Basement
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int[,] matrix = new int[rows, cols];

            var bombCoordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rowIndBlast = bombCoordinates[0];
            int colIndBlast = bombCoordinates[1];
            int radius = bombCoordinates[2];


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    double distance = Math.Sqrt(Math.Pow(row - rowIndBlast, 2) + Math.Pow(col - colIndBlast, 2));
                    if (distance <= radius)
                    {
                        matrix[row, col] = 1;
                    }
                }
            }


            int[][] secondMatrix = new int[cols][];


            for (int row = 0; row < cols; row++)
            {
                secondMatrix[row] = new int[rows];
                for (int col = 0; col < rows; col++)
                {
                    secondMatrix[row][col] = matrix[col, row];
                }
                secondMatrix[row] = secondMatrix[row].OrderByDescending(x => x).ToArray(); ;
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = secondMatrix[col][row];
                }
            }

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }


        }
    }
}

