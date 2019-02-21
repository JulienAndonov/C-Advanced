using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Sneaking
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numOfFloors = int.Parse(Console.ReadLine());
            char[][] map = new char[numOfFloors][];
            int samRow = -1;
            int samCol = -1;
            int nikoRow = -1;
            int nikoCol = -1;

            for (int floor = 0; floor < numOfFloors; floor++)
            {
                map[floor] = Console.ReadLine().ToCharArray();

                if (map[floor].Where(x => x == 'S').Count() != 0)
                {
                    samRow = floor;
                    samCol = Array.IndexOf(map[floor], 'S', 0);
                }

                if (map[floor].Where(x => x == 'N').Count() != 0)
                {
                    nikoRow = floor;
                    nikoCol = Array.IndexOf(map[floor], 'N', 0);
                }
            }

            while (true)
            {
                var commands = char.Parse(Console.ReadLine());

                if(commands == 'Q')
                {
                    break;
                }
            
                for (int floor = 0; floor < numOfFloors; floor++)
                {
                    for (int col = 0; col < map[floor].Length; col++)
                    {
                        if (map[floor][col] == 'b')
                        {
                            if (col == map[floor].Length - 1)
                            {
                                map[floor][col] = 'd';
                                break;
                            }
                            else
                            {
                                map[floor][col + 1] = 'b';
                                map[floor][col] = '.';
                                break;
                            }
                        }

                        if (map[floor][col] == 'd')
                        {
                            if (col == 0)
                            {
                                map[floor][col] = 'b';
                                break;
                            }
                            else
                            {
                                map[floor][col - 1] = 'd';
                                map[floor][col] = '.';
                                break;
                            }

                        }
                    }
                }


                if (map[samRow].Contains('d') && samCol < Array.IndexOf(map[samRow], 'd'))
                {
                    map[samRow][samCol] = 'X';
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    printMap(map);
                    break;
                }

                if (map[samRow].Contains('b') && samCol > Array.IndexOf(map[samRow], 'b'))
                {
                    map[samRow][samCol] = 'X';
                    Console.WriteLine($"Sam died at {samRow}, {samCol}");
                    printMap(map);
                    break;
                }


                if (commands == 'U')
                {
                    map[samRow - 1][samCol] = 'S';
                    map[samRow][samCol] = '.';
                    samRow = samRow - 1;
                }
                else if (commands == 'D')
                {
                    map[samRow + 1][samCol] = 'S';
                    map[samRow][samCol] = '.';
                    samRow = samRow + 1;
                }
                else if (commands == 'L')
                {
                    map[samRow][samCol - 1] = 'S';
                    map[samRow][samCol] = '.';
                    samCol = samCol - 1;
                }
                else if (commands == 'R')
                {
                    map[samRow][samCol + 1] = 'S';
                    map[samRow][samCol] = '.';
                    samCol = samCol + 1;
                }


                if (samRow == nikoRow)
                {
                    map[nikoRow][nikoCol] = 'X';
                    Console.WriteLine($"Nikoladze killed!");
                    printMap(map);
                    break;
                }
                printMap(map);

            }
        }

        private static void printMap(char[][] map)
        {
            for (int floor = 0; floor < map.Length; floor++)
            {
                Console.WriteLine(string.Join("", map[floor]));
            }
        }
    }
}
