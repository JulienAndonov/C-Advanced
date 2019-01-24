using System;
using System.Collections.Generic;
using System.Linq;


namespace P05_Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> symbolCount = new Dictionary<char, int>();
            var entry = Console.ReadLine();


            for (int i = 0; i < entry.Length; i++)
            {
                if (!symbolCount.ContainsKey(entry[i]))
                {
                    symbolCount[entry[i]] = 0;
                }

                symbolCount[entry[i]]++;
            }

            foreach (var symbolKey in symbolCount.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{symbolKey.Key}: {symbolKey.Value} time/s");
            }
        }
    }
}
