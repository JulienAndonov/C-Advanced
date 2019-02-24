using System;
using System.Collections.Generic;
using System.Linq;


namespace P17_Bombs
{
    class Program
    {
        static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            var matrix = new int[dimensions][];
            var activeCells = 0;
            var sumOfActiveSeels = 0;


            for (int row = 0; row < dimensions; row++)
            {
                matrix[row] = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            }


            List<string> bombCoordinates = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            foreach (var bomb in bombCoordinates)
            {
                var splittedCoordinates =
                    bomb.Split(",", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                var rowCoordinate = splittedCoordinates[0];
                var colCoordinate = splittedCoordinates[1];
                var bombValue = matrix[rowCoordinate][colCoordinate];

                if (matrix[rowCoordinate][colCoordinate] > 0)
                {

                    for (int row = 0; row < dimensions; row++)
                    {
                        for (int col = 0; col < dimensions; col++)
                        {

                            var distance = Math.Pow(Math.Abs(rowCoordinate - row), 2) +
                                           Math.Pow(Math.Abs(colCoordinate - col), 2);

                            if (distance <= 2 && distance != 0 && matrix[row][col] > 0)
                            {
                                matrix[row][col] -= bombValue;
                            }
                        }
                    }

                    matrix[rowCoordinate][colCoordinate] = 0;
                }

            }

            for (int row = 0; row < dimensions; row++)
            {
                for (int col = 0; col < dimensions; col++)
                {
                    if (matrix[row][col] > 0)
                    {
                        activeCells++;
                        sumOfActiveSeels += matrix[row][col];
                    }
                }
            }


            Console.WriteLine($"Alive cells: {activeCells}");
            Console.WriteLine($"Sum: {sumOfActiveSeels}");


            for (int row = 0; row < dimensions; row++)
            {
                Console.WriteLine(string.Join(" ", matrix[row]));
            }



        }
    }
}
