using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_3_Matrix_Jagged_Array_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowsCols, rowsCols];
            int sum = 0;
            int primary = 0;
            int secondary = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            for (int row = 0; row < rowsCols; row++)
            {
                primary += matrix[row, row];
                secondary += matrix[row, matrix.GetLength(1) - row - 1];
            }


            sum = Math.Abs(primary - secondary);

            Console.WriteLine(sum);

        }
    }
}
