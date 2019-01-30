using System;
using System.Linq;
using System.Collections.Generic;

namespace Session_6_Functional_Programing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(String.Join(", ", (Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).Where(x => x % 2 == 0).OrderBy(x => x))));
        }
    }
}
