using System;
using System.Collections.Generic;
using System.Linq;


namespace P09_Cups_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> cups = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Stack<int> bottles = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int wastedWater = 0;

            while (cups.Any() && bottles.Any())
            {
                var currentCup = cups.Dequeue();

                while (currentCup > 0)
                {
                    var currentBottle = bottles.Pop();

                    if (currentCup <= currentBottle)
                    {
                        wastedWater += currentBottle - currentCup;
                        currentCup = 0;
                    }
                    else
                    {
                        currentCup -= currentBottle;
                    }


                }

            }


            Console.WriteLine(cups.Count > 0 ? $"Cups: {string.Join(" ", cups) } " : $"Bottles: {string.Join(" ", bottles)}");
            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
