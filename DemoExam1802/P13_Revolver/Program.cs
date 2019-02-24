using System;
using System.Collections.Generic;
using System.Linq;

namespace P13_Revolver
{
    class Program
    {
        static void Main(string[] args)
        {
            int priceForBullet = int.Parse(Console.ReadLine());
            int sizeGunBarrel = int.Parse(Console.ReadLine());
            Stack<int> bullets = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> locks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            int intelligencePrice = int.Parse(Console.ReadLine());
            int firedBullets = 0;


            while (bullets.Any() && locks.Any())
            {
                var currentBullet = bullets.Pop();
                firedBullets++;

                if (currentBullet <= locks.Peek())
                {
                    Console.WriteLine("Bang!");
                    locks.Dequeue();
                }
                else
                {
                    Console.WriteLine("Ping!");
                }

                if (firedBullets % sizeGunBarrel == 0 && bullets.Any())
                {
                    Console.WriteLine("Reloading!");
                }
            }

            if (locks.Any())
            {
                Console.WriteLine($"Couldn't get through. Locks left: {locks.Count}");
            }
            else
            {

                var earnings = intelligencePrice - (firedBullets * priceForBullet);
                Console.WriteLine($"{bullets.Count} bullets left. Earned ${earnings}");

            }

        }
    }
}
