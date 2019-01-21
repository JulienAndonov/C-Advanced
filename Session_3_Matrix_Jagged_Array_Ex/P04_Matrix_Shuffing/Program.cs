using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Matrix_Shuffing
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            int rows = dimensions[0];
            int cols = dimensions[1];

            string[,] matrix = new string[rows, cols];


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var currentRow = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            while (true)
            {
                var commands = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();

                var operation = commands[0];

                if(operation == "END")
                {
                    break;
                }

                if (operation != "swap" || commands.Count() != 5)
                {
                    Console.WriteLine("Invalid input!");
                    continue;
                }
                else
                {
                    int srcRowIndex = int.Parse(commands[1]);
                    int srcColIndex = int.Parse(commands[2]);

                    int dstRowIndex = int.Parse(commands[3]);
                    int dstColIndex = int.Parse(commands[4]);

                    if (srcRowIndex < 0
                        || srcRowIndex >= matrix.GetLength(0)
                        || srcColIndex < 0
                        || srcColIndex >= matrix.GetLength(1)
                        || dstRowIndex < 0
                        || dstRowIndex >= matrix.GetLength(0)
                        || dstColIndex < 0
                        || dstRowIndex >= matrix.GetLength(1))
                    {
                        Console.WriteLine("Invalid input!");
                        continue;
                    }
                    else
                    {
                        string temp = matrix[srcRowIndex, srcColIndex];
                        matrix[srcRowIndex, srcColIndex] = matrix[dstRowIndex, dstColIndex];
                        matrix[dstRowIndex, dstColIndex] = temp;

                        for (int row = 0; row < rows; row++)
                        {
                            for (int col = 0; col < cols; col++)
                            {
                                Console.Write(matrix[row, col] + " ");
                            }
                            Console.WriteLine();
                        }

                    }
                }
                
            }


        }
    }
}
