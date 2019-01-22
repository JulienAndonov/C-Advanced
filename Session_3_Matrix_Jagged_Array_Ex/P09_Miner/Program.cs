using System;
using System.Collections.Generic;
using System.Linq;


namespace P09_Miner
{
    class Program
    {
        static void Main(string[] args)
        {
            int rowsCols = int.Parse(Console.ReadLine());
            char[,] matrix = new char[rowsCols, rowsCols];
            int coalAmount = 0;
            int coalGathered = 0;
            int startRow = -1;
            int starCol = -1;


            string[] commands = Console.ReadLine().Split(" ").ToArray();

            for (int row = 0; row < rowsCols; row++)
            {

                var currentRow = Console.ReadLine().Split().Select(char.Parse).ToArray();
                for (int col = 0; col < rowsCols; col++)
                {
                    matrix[row, col] = currentRow[col];
                    if (matrix[row, col] == 'c')
                    {
                        coalAmount++;
                    }

                    if (matrix[row, col] == 's')
                    {
                        startRow = row;
                        starCol = col;
                    }

                }
            }



            
            var currRow = startRow;
            var currCol = starCol;


            foreach (var command in commands)
            {
                switch (command)
                {
                    case "up":
                        currRow--;

                        if (matrix[currRow, currCol] == 'c')
                        {
                            coalGathered++;

                            if(coalGathered == coalAmount)
                            {
                                Console.WriteLine($"You collected all coals! ({currRow},{currCol})");
                                return;
                            }

                        }
                        else if (matrix[currRow, currCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currRow},{currCol})");
                        }
                        break;

                    case "down":
                        currRow++;

                        if (matrix[currRow, currCol] == 'c')
                        {
                            coalGathered++;
                            if (coalGathered == coalAmount)
                            {
                                Console.WriteLine($"You collected all coals! ({currRow},{currCol})");
                                return;
                            }
                        }
                        else if (matrix[currRow, currCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currRow},{currCol})");
                        }
                        break;

                    case "right":
                        currCol++;

                        if (currCol < rowsCols)
                        {
                            if (matrix[currRow, currCol] == 'c')
                            {
                                coalGathered++;
                                if (coalGathered == coalAmount)
                                {
                                    Console.WriteLine($"You collected all coals! ({currRow},{currCol})");
                                    return;
                                }
                            }
                            else if (matrix[currRow, currCol] == 'e')
                            {
                                Console.WriteLine($"Game over! ({currRow},{currCol})");
                            }
                        }
                        else
                        {
                            currCol--;
                        }
                

                break;

                    case "left":
                        currCol--;

                        if (matrix[currRow, currCol] == 'c')
                        {
                            coalGathered++;
                            if (coalGathered == coalAmount)
                            {
                                Console.WriteLine($"You collected all coals! ({currRow},{currCol})");
                                return;
                            }
                        }
                        else if (matrix[currRow, currCol] == 'e')
                        {
                            Console.WriteLine($"Game over! ({currRow},{currCol})");
                        }
                        break;
                }

            }



            if (coalGathered < coalAmount)
            {
                Console.WriteLine($"{coalAmount - coalGathered} coals left ({currRow},{currCol})");
            }




        }
    }
}
