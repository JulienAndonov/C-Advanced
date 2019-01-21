using System;
using System.Collections.Generic;
using System.Linq;


namespace P05_Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];
            int index = 0;
            string filling = Console.ReadLine();

            char[,] matrix = new char[rows, cols];

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = filling[index % filling.Length];
                    index++;
                }
            }


            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write(matrix[row, col] );
                }
                Console.WriteLine();
            }


        }
    }
}
