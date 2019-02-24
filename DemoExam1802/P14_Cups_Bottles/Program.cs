using System;
using System.Collections.Generic;
using System.Linq;

namespace P14_Cups_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cupsToFill = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> bottlesWithWater = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int totalWastedWater = 0;

            while (cupsToFill.Any() && bottlesWithWater.Any())
            {
                var currentCup = cupsToFill.Dequeue();

                while (currentCup > 0)
                {
                    if (bottlesWithWater.Peek() >= currentCup)
                    {
                        var currentBottle = bottlesWithWater.Pop();
                        totalWastedWater += (currentBottle - currentCup);
                        currentCup -= currentBottle;
                    }
                    else
                    {
                        currentCup -= bottlesWithWater.Pop();
                    }
                }


            }


            Console.WriteLine(bottlesWithWater.Count > 0 ? "Bottles: " + string.Join(" ", bottlesWithWater) : "Cups: " + string.Join(" ", cupsToFill));
            Console.WriteLine($"Wasted litters of water: {totalWastedWater}");
        }
    }
}
