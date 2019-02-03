using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_6_Functional_Programing_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            var entries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            Action<string> printAction = e => Console.WriteLine(e); ;

            foreach (var entry in entries)
            {
                printAction(entry);
            }
        }
    }
}
