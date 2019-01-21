using System;
using System.Collections.Generic;
using System.Linq;

namespace L06_Jagged_Arrays_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());

            int[][] jaggedArray = new int[rows][];


            for (int row = 0; row < jaggedArray.Length; row++)
            {
                var currentRow = Console
                    .ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                jaggedArray[row] = currentRow;
            }

            while (true)
            {
                var tokens = Console.ReadLine().Split().ToArray();

                var command = tokens[0];

                if (command == "END")
                {
                    foreach (var row in jaggedArray)
                    {
                        Console.WriteLine(String.Join(" ", row));
                    }
                    return;
                }
                else
                {
                    var rowIndex = int.Parse(tokens[1]);
                    var colIndex = int.Parse(tokens[2]);
                    var value = int.Parse(tokens[3]);


                    if (rowIndex < 0
                        || rowIndex > rows - 1
                        || colIndex < 0
                        || colIndex > jaggedArray.Length - 1)
                    {
                        Console.WriteLine("Invalid coordinates");
                        continue;
                    }
                    else
                    {
                        switch (command)
                        {
                            case "Add":
                                jaggedArray[rowIndex][colIndex] += value;
                                break;
                            case "Subtract":
                                jaggedArray[rowIndex][colIndex] -= value;
                                break;
                        }
                    }
                }
            }
        }
    }
}