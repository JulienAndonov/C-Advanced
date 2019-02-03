using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Find_Even_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseInt = int.Parse;

            var entries = Console.ReadLine().Split(" ").Select(parseInt).ToList();
            var begining = entries[0];
            var end = entries[entries.Count - 1];
            List<int> numbers = new List<int>();

            var state = Console.ReadLine();

            for (int i = begining; i <= end; i++)
            {
                numbers.Add(i);
            }


            Func<int, bool> checkEven = n => n % 2 == 0;
            Func<int, bool> checkOdd = n => n % 2 != 0;


            if (state == "odd")
            {
                Console.WriteLine(String.Join(" ", numbers.Where(checkOdd)));
            }
            else
            {
                Console.WriteLine(String.Join(" ", numbers.Where(checkEven)));
            }





        }
    }
}
