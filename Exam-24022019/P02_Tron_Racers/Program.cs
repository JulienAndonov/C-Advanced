using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;


namespace P02_Tron_Racers
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int dimensions = int.Parse(Console.ReadLine());
            char[][] map = new char[dimensions][];
            int firstRow = -1;
            int firstCol = -1;

            int secondRow = -1;
            int secondCol = -1;

            int currRow = -1;
            int currCol = -1;

            char player = ' ';

            bool crashed = false;

            for (int row = 0; row < dimensions; row++)
            {
                map[row] = Console.ReadLine().ToCharArray();
            }


            for (int row = 0; row < dimensions; row++)
            {
                for (int col = 0; col < dimensions; col++)
                {
                    if (map[row][col] == 'f')
                    {
                        firstRow = row;
                        firstCol = col;
                    }

                    if (map[row][col] == 's')
                    {
                        secondRow = row;
                        secondCol = col;
                    }
                }
                if (secondRow != -1 && secondCol != -1 && firstRow != -1 && firstCol != -1)
                {
                    break;
                }
            }

            while (true)
            {
                var inputCommands = Console.ReadLine().Split(" ");
                var turn = 1;

                foreach (var command in inputCommands)
                {
                    if (turn % 2 != 0)
                    {
                        player = 'f';
                        currRow = firstRow;
                        currCol = firstCol;
                    }
                    else
                    {
                        player = 's';
                        currRow = secondRow;
                        currCol = secondCol;
                    }


                    switch (command)
                    {
                        case "up":
                            currRow = currRow - 1;
                            if (currRow < 0)
                            {
                                currRow = 0;
                            }

                            if (map[currRow][currCol] != '*')
                            {
                                map[currRow][currCol] = 'x';
                                crashed = true;
                                break;
                            }
                            else
                            {
                                map[currRow][currCol] = player;
                            }
                            break;
                        case "down":
                            currRow = currRow + 1;
                            if (currRow >= dimensions)
                            {
                                currRow = 0;
                            }

                            if (map[currRow][currCol] != '*')
                            {
                                map[currRow][currCol] = 'x';
                                crashed = true;
                                break;
                            }
                            else
                            {
                                map[currRow][currCol] = player;
                            }
                            break;

                        case "left":
                            currCol = currCol - 1;
                            if (currCol < 0)
                            {
                                currCol = dimensions - 1;
                            }

                            if (map[currRow][currCol] != '*')
                            {
                                map[currRow][currCol] = 'x';
                                crashed = true;
                                break;
                            }
                            else
                            {
                                map[currRow][currCol] = player;
                            }
                            break;
                        case "right":
                            currCol = currCol + 1;
                            if (currCol >= dimensions)
                            {
                                currCol = 0;
                            }

                            if (map[currRow][currCol] != '*')
                            {
                                map[currRow][currCol] = 'x';
                                crashed = true;
                                break;
                            }
                            else
                            {
                                map[currRow][currCol] = player;
                            }
                            break;
                    }

                    if (turn % 2 != 0)
                    {
                        firstRow = currRow;
                        firstCol = currCol;
                    }
                    else
                    {
                        secondRow = currRow;
                        secondCol = currCol;
                    }

                    turn++;

                    if (crashed)
                    {
                        break;
                    }

                }
                if (crashed)
                {
                    break;
                }
            }



            for (int row = 0; row < dimensions; row++)
            {
                Console.WriteLine(string.Join("",map[row]));
            }
        }

    }
}
