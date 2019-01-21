using System;
using System.Collections.Generic;
using System.Linq;

namespace P02_Basic_Queue_Operation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tokens = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            int stackCount = tokens[0];
            int elementsToRemove = tokens[1];
            int elementToFind = tokens[2];

            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();

            Queue<int> numbers = new Queue<int>(input);


            for (int i = 0; i < elementsToRemove; i++)
            {
                numbers.Dequeue();
            }

            if (numbers.Contains(elementToFind))
            {
                Console.WriteLine("true");
            }
            else if (numbers.Count() > 0)
            {
                Console.WriteLine(numbers.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
