using System;
using System.Collections.Generic;
using System.Linq;

namespace P09_List_Predicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int endValue = int.Parse(Console.ReadLine());
            var dividers = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray(); ;
            var correctNumbers = new List<int>();

            Func<int, bool> divideFunc = x
                 =>
                 {
                     foreach (var divider in dividers)
                     {
                         if (x % divider != 0)
                         {
                             return false;
                         }
                     }
                     return true;
                 };

            for (int i = 1; i <= endValue; i++)
            {
                if (divideFunc(i))
                {
                    correctNumbers.Add(i);
                }
            }
            Console.WriteLine(String.Join(" ", correctNumbers));
        }
    }
}
