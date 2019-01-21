using System;
using System.Collections.Generic;
using System.Linq;

namespace L07_Pascal_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            Int64[][] pascalArray = new Int64[rows][];



            for (int row = 0; row < rows; row++)
            {
                pascalArray[row] = new Int64[row + 1];
                for (int col = 0; col < pascalArray[row].Length; col++)
                {
                    if (col == 0 || col == pascalArray[row].Length - 1)
                    {
                        pascalArray[row][col] = 1;
                    }
                    else
                    {
                        pascalArray[row][col] = pascalArray[row - 1][col] + pascalArray[row - 1][col - 1];
                    }
                }

            }

            foreach (var row in pascalArray)
            {
                Console.WriteLine(String.Join(" ", row));
            }

        }
    }
}
