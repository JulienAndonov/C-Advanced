using System;
using System.Collections.Generic;
using System.Linq;

namespace P18_Kitchen
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> knives = new Stack<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            Queue<int> forks = new Queue<int>(Console.ReadLine().Split(" ").Select(int.Parse));
            List<int> sets = new List<int>();


            while (knives.Any() && forks.Any())
            {
                var currentKnife = knives.Pop();
                if (currentKnife > forks.Peek())
                {
                    sets.Add(currentKnife + forks.Dequeue());
                }
                else if (currentKnife < forks.Peek())
                {
                    continue;
                }
                else
                {
                    forks.Dequeue();
                    knives.Push(currentKnife + 1);
                }
            }


            Console.WriteLine($"The biggest set is: {sets.Max()}");
            Console.WriteLine(string.Join(" ",sets));
        }
    }
}
