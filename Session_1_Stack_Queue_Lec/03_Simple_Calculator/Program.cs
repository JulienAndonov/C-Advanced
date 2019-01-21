using System;
using System.Collections.Generic;
using System.Linq;

namespace _03_Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            Stack<string> numbers = new Stack<string>(input.Reverse());
            int total = int.Parse(numbers.Pop());

            while (numbers.Any())
            {
                string operation = numbers.Pop();
                switch (operation)
                {
                    case "+":
                        total += int.Parse(numbers.Pop());
                        break;
                    case "-":
                        total -= int.Parse(numbers.Pop());
                        break;
                }
            }


            Console.WriteLine(total);
        }
    }
}
