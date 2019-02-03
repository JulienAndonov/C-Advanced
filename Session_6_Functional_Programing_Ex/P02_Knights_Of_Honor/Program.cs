using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Knights_Of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> knights = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> printKnight = k => Console.WriteLine($"Sir {k}");



            foreach(var knight in knights)
            {
                printKnight(knight);
            }

        }
    }
}
