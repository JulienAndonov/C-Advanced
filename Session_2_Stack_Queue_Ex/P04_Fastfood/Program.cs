using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Fastfood
{
    class Program
    {
        static void Main(string[] args)
        {
            int preparedFood = int.Parse(Console.ReadLine());
            var input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            Queue<int> orders = new Queue<int>(input);
            Console.WriteLine(orders.Max());

            while (orders.Any())
            {
                if (orders.Peek() <= preparedFood)
                {
                    int order = orders.Dequeue();
                    preparedFood -= order;
                }
                else
                {
                    Console.WriteLine($"Orders left: {String.Join(' ', orders)}");
                    break;
                }
            }

            if (orders.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
