using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<double> numbers = new HashSet<double>();
            double numOfEntries = double.Parse(Console.ReadLine());


            for (int i = 0; i < numOfEntries; i++)
            {
                var entryNumber = double.Parse((Console.ReadLine()));
                if (numbers.Contains(entryNumber))
                {
                    Console.WriteLine(entryNumber);
                    break;
                }
                numbers.Add(entryNumber);
            }
        }
    }
}
