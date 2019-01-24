using System;
using System.Collections.Generic;
using System.Linq;


namespace P02_Sets_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var entries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
            HashSet<int> firstSet = new HashSet<int>();
            HashSet<int> secondSet = new HashSet<int>();

            var firstSetCount = entries[0];
            var secondSetCount = entries[1];



            for (int i = 0; i < firstSetCount; i++)
            {
                firstSet.Add(int.Parse(Console.ReadLine()));
            }


            for (int i = 0; i < secondSetCount; i++)
            {
                secondSet.Add(int.Parse(Console.ReadLine()));
            }



            firstSet.IntersectWith(secondSet);



            Console.WriteLine(String.Join(' ', firstSet));
        }
    }
}
