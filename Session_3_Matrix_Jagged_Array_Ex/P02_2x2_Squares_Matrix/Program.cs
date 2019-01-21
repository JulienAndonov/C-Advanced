using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_2x2_Squares_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int equaMatrixesCount = 0;
            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {

                var currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(currentRow[col]);
                }
            }


            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row, col] == matrix[row + 1, col] && matrix[row, col] == matrix[row + 1, col + 1])
                    {
                        equaMatrixesCount++;
                    }
                }
            }

            Console.WriteLine(equaMatrixesCount);
        }
    }
}
