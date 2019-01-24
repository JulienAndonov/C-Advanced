using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_4_Sets_Multidiml_Dictionaries_Ex
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEntries = int.Parse(Console.ReadLine());
            HashSet<string> uniqueUsernames = new HashSet<string>();


            for (int i = 0; i < numOfEntries; i++)
            {
                uniqueUsernames.Add(Console.ReadLine());
            }


            Console.WriteLine(String.Join(System.Environment.NewLine,uniqueUsernames));




        }
    }
}
