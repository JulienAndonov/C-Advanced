﻿using System;
using System.Linq;

namespace L03_Count_Upper_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Where(x => char.IsUpper(x[0])).ToList().ForEach(x => Console.WriteLine(x)); ;
        }
    }
}
