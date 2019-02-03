using System;
using System.Collections.Generic;
using System.Linq;

namespace P13_Tri_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());


            Func<string, char[]> toCharArrFunc = x => x.ToCharArray();
            Func<char, int> parseFunc = x => (int)x;
            Func<string, bool> funalFunc = x => toCharArrFunc(x).Select(parseFunc).Sum() >= number;

            Console.WriteLine(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .FirstOrDefault(funalFunc));

        }
    }
}
