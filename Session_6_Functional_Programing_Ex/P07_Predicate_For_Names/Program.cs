using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int> parseInt = int.Parse;

            int checkNumber = parseInt(Console.ReadLine());
            var names = Console.ReadLine().Split(" ");


            Func<string, bool> checkName = (x) 
              =>
              {
                  return x.Count() <= checkNumber;
              };


            names.Where(checkName).ToList().ForEach(Console.WriteLine);


        }
    }
}
