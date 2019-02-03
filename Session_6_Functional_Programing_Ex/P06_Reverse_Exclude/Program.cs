using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Reverse_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseInt = int.Parse;
            var entryNumbers = Console.ReadLine().Split(" ").Select(parseInt);
            var numberToCompare = parseInt(Console.ReadLine());

            Func<int,int, bool> checkNumber = (n, c) =>
             {
                 return n % c != 0;
             };

            Console.WriteLine(String.Join(" ",entryNumbers.Where((x, y) => checkNumber(x, numberToCompare)).Reverse()));

        }
    }
}
