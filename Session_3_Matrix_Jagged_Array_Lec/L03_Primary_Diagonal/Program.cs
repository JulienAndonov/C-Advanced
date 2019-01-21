using System;
using System.Collections.Generic;
using System.Linq;

namespace L03_Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsCols = int.Parse(Console.ReadLine());

            int[,] matrix = new int[rowsCols, rowsCols];
            int sum = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console
                    .ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();


                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row,col] = currentRow[col];
                }
            }


            for (int row = 0; row < rowsCols; row++)
            {
                sum += matrix[row, row];
            }

            Console.WriteLine(sum);


        }
    }
}
