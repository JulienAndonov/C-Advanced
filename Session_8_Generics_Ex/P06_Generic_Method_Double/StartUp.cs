using System;
using System.Collections.Generic;
using System.Linq;


namespace P06_Generic_Method_Double
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Box<double> box = new Box<double>();
            int numOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfEntries; i++)
            {
                var currentLine = double.Parse(Console.ReadLine());
                box.Add(currentLine);
            }

            var elementToSearch = double.Parse(Console.ReadLine());
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
