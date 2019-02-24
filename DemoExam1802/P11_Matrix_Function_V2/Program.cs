using System;
using System.Linq;

namespace P11_Matrix_Function_V2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfRows = int.Parse(Console.ReadLine());
            var matrix = new string[numOfRows][];



            for (int row = 0; row < numOfRows; row++)
            {
                matrix[row] = Console.ReadLine().Split(", ");
            }

            var splittedInput = Console.ReadLine().Split(" ");
            var command = splittedInput[0];
            var headerName = splittedInput[1];

            //var headRowIndex = 0;
            var headColIndex = Array.FindIndex(matrix[0], v => v == headerName);


            if (command == "hide")
            {
                for (int row = 0; row < numOfRows; row++)
                {
                    var tempArray = new string[matrix[row].Length - 1];
                    int index = 0;
                    for (int col = 0; col < matrix[row].Length; col++)
                    {
                        if (col == headColIndex)
                        {
                            continue;
                        }

                        tempArray[index] = matrix[row][col];
                        index++;
                    }
                    matrix[row] = tempArray;
                }

                foreach (var row in matrix)
                {
                    Console.WriteLine(string.Join(" | ", row));
                }
            }
            else if (command == "filter")
            {
                var valueToFilter = splittedInput[2];

                Console.WriteLine(string.Join(" | ", matrix[0]));

                for (int row = 1; row < matrix.Length; row++)
                {
                    if (matrix[row][headColIndex] == valueToFilter)
                    {
                        Console.WriteLine(string.Join(" | ", matrix[row]));
                    }
                }

            }
            else
            {
                var sortedMatrix = matrix.Skip(1).OrderBy(x => x[headColIndex]).ToArray();

                Console.WriteLine(string.Join(" | ", matrix[0]));

                foreach (var row in sortedMatrix)
                {
                    Console.WriteLine(string.Join(" | ", row));
                }

            }


        }
    }
}
