using System;
using System.ComponentModel;
using System.Linq;

namespace P02_Matrix_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            string[][] matrix = new string[numOfRows][];

            for (int i = 0; i < numOfRows; i++)
            {
                matrix[i] = Console.ReadLine().Split(", ").ToArray();
            }

            var commandEntries = Console.ReadLine().Split(" ");

            var header = commandEntries[1];
            var columnIndex = -1;

            for (int row = 0; row < 1; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    if (matrix[row][col] == header)
                    {
                        columnIndex = col;
                        break;
                    }
                }
            }

            if (commandEntries[0] == "hide")
            {


                for (int row = 0; row < matrix.Length; row++)
                {
                    var tempArray = new string[matrix[row].Length - 1];
                    int index = 0;
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (col == columnIndex)
                        {
                            continue;
                        }

                        tempArray[index] = matrix[row][col];
                        index++;
                    }

                    matrix[row] = tempArray;
                }

                Console.WriteLine(string.Join(" | ", matrix[0]));
                for (int row = 1; row < matrix.Length; row++)
                {
                    Console.WriteLine(string.Join(" | ", matrix[row]));
                }
            }
            else if (commandEntries[0] == "filter")
            {
                var valueToFilter = commandEntries[2];

                Console.WriteLine(string.Join(" | ", matrix[0]));

                for (int row = 0; row < matrix.Length; row++)
                {
                    if (matrix[row][columnIndex] == valueToFilter)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row]));
                    }

                }
            }
            else if (commandEntries[0] == "sort")
            {
                var orderedMatrix = matrix.Skip(1).OrderBy(x => x[columnIndex]).ToArray();


                Console.WriteLine(string.Join(" | ", matrix[0]));

                for (int row = 0; row < orderedMatrix.Length; row++)
                {
                    Console.WriteLine(string.Join(" | ", orderedMatrix[row]));
                }



            }




        }
    }
}
