using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_2_Stack_Queue_Ex
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

            Stack<int> numbers = new Stack<int>(input);


            for (int i = 0; i < elementsToRemove; i++)
            {
                numbers.Pop();
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
