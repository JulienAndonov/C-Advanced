using System;
using System.Collections.Generic;
using System.Linq;


namespace P08_Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int> compareFunc = (a, b) => a.CompareTo(b);
            var nums = Console.ReadLine().Split(" ").Select(int.Parse);
            var evenNumbers = nums.Where(x => x % 2 == 0).ToArray();
            var oddNumbers = nums.Where(x => x % 2 != 0).ToArray();

            Array.Sort(evenNumbers, new Comparison<int>(compareFunc));
            Array.Sort(oddNumbers, new Comparison<int>(compareFunc));

            var allNums = evenNumbers.ToList();

            allNums.AddRange(oddNumbers);

            Console.WriteLine(String.Join(" ", allNums));
        }
    }
}
