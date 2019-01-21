using System;
using System.Collections.Generic;
using System.Linq;


namespace L04_Symbol_In_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var rowsCols = int.Parse(Console.ReadLine());

            char[,] matrix = new char[rowsCols, rowsCols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine().ToCharArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }


            var symbol = char.Parse(Console.ReadLine());

            for (int row = 0; row < rowsCols; row++)
            {
                for (int col = 0; col < rowsCols; col++)
                {
                    if (matrix[row, col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }

            Console.WriteLine($"{symbol} does not occur in the matrix");
        }
    }
}
