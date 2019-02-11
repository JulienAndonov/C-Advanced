using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Generic_Method_Count
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int numOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfEntries; i++)
            {
                var currentLine = Console.ReadLine();
                box.Add(currentLine);
            }

            var elementToSearch = Console.ReadLine();


            int count = GetCount(box.Data, elementToSearch);
            Console.WriteLine(count);
        }


        public static int GetCount<T>(List<T> elements, T elementToSearch) where T : IComparable
        {
            int counter = 0;
            foreach (var element in elements)
            {
                if (element.CompareTo(elementToSearch) > 0)
                {
                    counter++;
                }
            }

            return counter;
        }
    }
}

