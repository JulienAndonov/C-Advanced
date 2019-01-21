using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_3_Matrix_Jagged_Array_Lec
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            var rows = dimensions[0];
            var cols = dimensions[1];
            var currentSum = 0;

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
                

                for (int col = 0; col < cols; col++)
                {
                    currentSum += matrix[row, col];
                }
            }


            Console.WriteLine(rows);
            Console.WriteLine(cols);
            Console.WriteLine(currentSum);
        }
    }
}
