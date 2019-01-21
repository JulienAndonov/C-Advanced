using System;
using System.Collections.Generic;
using System.Linq;

namespace L05_Square_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {

            var dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];
            int maxSum = int.MinValue;
            int maxRowIndex = 0;
            int maxColIndex = 0;

            int[,] matrix = new int[rows, cols];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }


            for (int row = 0; row < rows; row++)
            {
                var currentSum = 0;
                for (int col = 0; col < cols; col++)
                {
                    if (row <= rows - 2 && col <= cols - 2)
                    {
                        currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1];
                        if (maxSum < currentSum)
                        {
                            maxSum = currentSum;
                            maxRowIndex = row;
                            maxColIndex = col;
                        }
                    }
                }
            }


            for (int row = maxRowIndex; row <= maxRowIndex + 1; row++)
            {
                for (int col = maxColIndex; col <= maxColIndex + 1; col++)
                {
                    Console.Write(matrix[row,col] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine(maxSum);

        }
    }
}
