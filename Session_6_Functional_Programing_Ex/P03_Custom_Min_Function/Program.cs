using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<string, int> parseInt = int.Parse;

            List<int> entryNums = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(parseInt).ToList();
            
            Func<List<int>, int> minValue = e
            =>
            {
                int currMin = int.MaxValue;

                for (int i = 0; i < e.Count; i++)
                {
                    if (e[i] < currMin)
                    {
                        currMin = e[i];
                    }
                }
                return currMin;
            };

            Action<int> printEntry = Console.WriteLine;
                       
            printEntry(minValue(entryNums));

        }
    }
}
