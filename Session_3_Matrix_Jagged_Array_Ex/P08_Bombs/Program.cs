using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rowsCols, rowsCols];
            int aliveCells = 0;
            int sumAlivecells = 0;

            for (int row = 0; row < rowsCols; row++)
            {

                var currentRow = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < rowsCols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }



            string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).ToArray();


            foreach (var command in commands)
            {

                var coordinates = command.Split(',', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                int bombRow = coordinates[0];
                int bombCol = coordinates[1];

                for (int row = 0; row < rowsCols; row++)
                {
                    for (int col = 0; col < rowsCols; col++)
                    {
                        var distance = Math.Pow(Math.Abs(row - bombRow), 2) + Math.Pow(Math.Abs(col - bombCol), 2);

                        if(matrix[bombRow,bombCol] > 0)
                        {
                            if (distance <= 2 && distance != 0 && matrix[row,col] > 0)
                            {
                                matrix[row, col] -= matrix[bombRow, bombCol];
                            }
                        }
                        
                    }
                }

                matrix[bombRow, bombCol] = 0;

           
            }

            for (int row = 0; row < rowsCols; row++)
            {
                for (int col = 0; col < rowsCols; col++)
                {

                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sumAlivecells += matrix[row, col];

                    }

                }
            }


            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumAlivecells}");


            for (int row = 0; row < rowsCols; row++)
            {
                for (int col = 0; col < rowsCols; col++)
                {
                    Console.Write(matrix[row,col] + " ");

                }
                Console.WriteLine();
            }
        }
    }
}
