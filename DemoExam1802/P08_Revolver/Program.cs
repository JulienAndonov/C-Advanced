using System;
using System.Collections.Generic;
using System.Linq;

namespace P08_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceForBullet = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse).ToArray());
            int valueOfIntelligence = int.Parse(Console.ReadLine());
            int firedBullets = 0;

            while(locks.Any() && bullets.Any())
            {
                var currentBullet = bullets.Pop();

                if(currentBullet > locks.Peek())
                {
                    Console.WriteLine("Ping!");
                }
                else
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }

                firedBullets++;

                if(firedBullets % sizeGunBarrel == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Count() > 0)
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {
                var totalCost = firedBullets * priceForBullet;
                var totalEarned = valueOfIntelligence - totalCost;
                Console.WriteLine($"{bullets.Count()} bullets left. Earned ${totalEarned}");
            }
        }
    }
}
