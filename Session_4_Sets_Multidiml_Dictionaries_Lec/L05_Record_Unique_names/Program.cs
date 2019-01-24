using System;
using System.Collections.Generic;
using System.Linq;

namespace L05_Record_Unique_names
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfEntries = int.Parse(Console.ReadLine());
            HashSet<string> names = new HashSet<string>();



            for (int i = 0; i < numOfEntries; i++)
            {
                names.Add(Console.ReadLine());
            }



            Console.WriteLine(String.Join(System.Environment.NewLine,names));
        }
    }
}
