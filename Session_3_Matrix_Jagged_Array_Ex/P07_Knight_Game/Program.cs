using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Knight_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowsCols, rowsCols];
            int knightsRemoved = 0;

            for (int row = 0; row < rowsCols; row++)
            {

                var currentRow = Console.ReadLine().ToCharArray();
                for (int col = 0; col < rowsCols; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }


            while (true)
            {
                int knightRow = -1;
                int knightCol = -1;
                int maxAttacking = 0;

                for (int row = 0; row < rowsCols; row++)
                {
                    for (int col = 0; col < rowsCols; col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int tempAttack = getAttacked(matrix, row, col);

                            if (tempAttack > maxAttacking)
                            {
                                maxAttacking = tempAttack;
                                knightRow = row;
                                knightCol = col;
                            }

                        }
                    }
                }


                if (maxAttacking > 0)
                {
                    matrix[knightRow, knightCol] = '0';
                    knightsRemoved++;
                }
                else
                {
                    break;
                }
            }


            Console.WriteLine(knightsRemoved);


        }

        private static int getAttacked(char[,] matrix, int row, int col)
        {
            int attacks = 0;


            if (InMatrix(row + 1, col + 2, matrix.GetLength(0)) && matrix[row, col] == matrix[row + 1, col + 2])
            {
                attacks++;
            }

            if (InMatrix(row + 2, col + 1, matrix.GetLength(0)) && matrix[row, col] == matrix[row + 2, col + 1])
            {
                attacks++;
            }


            if (InMatrix(row - 1, col + 2, matrix.GetLength(0)) && matrix[row, col] == matrix[row - 1, col + 2])
            {
                attacks++;
            }


            if (InMatrix(row - 2, col + 1, matrix.GetLength(0)) && matrix[row, col] == matrix[row - 2, col + 1])
            {
                attacks++;
            }

            if (InMatrix(row + 1, col - 2, matrix.GetLength(0)) && matrix[row, col] == matrix[row + 1, col - 2])
            {
                attacks++;
            }

            if (InMatrix(row + 2, col - 1, matrix.GetLength(0)) && matrix[row, col] == matrix[row + 2, col - 1])
            {
                attacks++;
            }


            if (InMatrix(row - 2, col - 1, matrix.GetLength(0)) && matrix[row, col] == matrix[row - 2, col - 1])
            {
                attacks++;
            }


            if (InMatrix(row - 1, col - 2, matrix.GetLength(0)) && matrix[row, col] == matrix[row - 1, col - 2])
            {
                attacks++;
            }

            return attacks;

        }


        public static bool InMatrix(int row, int col, int length)
        {
            bool isInside = row < length && row >= 0 && col < length && col >= 0;
            return isInside;
        }
    }
}
