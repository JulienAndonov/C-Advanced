using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseInt = x => int.Parse(x);

            List<int> numbers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(parseInt).ToList();
            Func<int, string> printNumber = x => $"{x}";


            Action<List<int>, string> artihmetics = (elements, command)
                 =>
             {

                 if (command == "add")
                 {
                     for (int i = 0; i < elements.Count; i++)
                     {
                         elements[i] += 1;
                     }

                 }
                 else if (command == "subtract")
                 {
                     for (int i = 0; i < elements.Count; i++)
                     {
                         elements[i] -= 1;
                     }
                 }
                 else if (command == "multiply")
                 {
                     for (int i = 0; i < elements.Count; i++)
                     {
                         elements[i] *= 2;
                     }
                 }
                 else if (command == "print")
                 {
                     for (int i = 0; i < elements.Count; i++)
                     {
                         Console.Write(printNumber(elements[i]));
                         if(i != elements.Count - 1)
                         {
                             Console.Write(" ");
                         }
                     }
                     Console.WriteLine();
                 }
             };

            while (true)
            {
                var command = Console.ReadLine();

                if (command == "end")
                {

                    break;
                }

                artihmetics(numbers, command);
            }
        }
    }
}
