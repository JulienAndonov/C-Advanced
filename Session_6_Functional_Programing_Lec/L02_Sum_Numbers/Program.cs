using System;
using System.Linq;

namespace L02_Sum_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var entryNumbers = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse);
            Console.WriteLine(entryNumbers.Count());
            Console.WriteLine(entryNumbers.Sum());
        }
    }
}

