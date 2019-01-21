using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputNumbers = Console.ReadLine().Split().Select(x => int.Parse(x)).ToList();
            Stack<int> numbers = new Stack<int>(inputNumbers);

            var command = Console.ReadLine().ToLower();


            while (command != "end")
            {
                string[] tokens = command.Split();

                if (tokens[0] == "add")
                {
                    numbers.Push(int.Parse(tokens[1]));
                    numbers.Push(int.Parse(tokens[2]));
                }


                if (tokens[0] == "remove")
                {
                    var numbersToRemove = int.Parse(tokens[1]);
                    if (numbersToRemove <= numbers.Count())
                    {
                        for (int i = 0; i < numbersToRemove; i++)
                        {
                            numbers.Pop();
                        }
                    }
                }
                command = Console.ReadLine().ToLower();
            }
            Console.WriteLine($"Sum: {numbers.Sum()}");
        }
    }
}
