using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;


namespace P06_Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, int>> wardrobe = new Dictionary<string, Dictionary<string, int>>();
            int numOfEntries = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfEntries; i++)
            {
                var entries = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
                var colour = entries[0];
                var cloths = entries[1].Split(",", StringSplitOptions.RemoveEmptyEntries).ToList();

                if (!wardrobe.ContainsKey(colour))
                {
                    wardrobe[colour] = new Dictionary<string, int>();
                }


                foreach (var cloth in cloths)
                {
                    if (!wardrobe[colour].ContainsKey(cloth))
                    {
                        wardrobe[colour][cloth] = 0;
                    }
                    wardrobe[colour][cloth]++;
                }
            }


            var entryToSearch = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var colourToSearch = entryToSearch[0];
            var clothToSearch = entryToSearch[1];


            foreach (var colour in wardrobe)
            {
                Console.WriteLine($"{colour.Key} clothes:");
                foreach (var cloth in colour.Value)
                {
                    Console.Write($"* {cloth.Key} - {cloth.Value}");
                    if (colour.Key == colourToSearch && cloth.Key == clothToSearch)
                    {
                        Console.WriteLine($" (found!)");
                    }
                    else
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}
