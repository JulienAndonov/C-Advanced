using System;
using System.Collections.Generic;
using System.Linq;


namespace P03_Periodic_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> uniqueElemnents = new HashSet<string>();
            int numOfEntries = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfEntries; i++)
            {
                var command = Console.ReadLine();
                var elements = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                foreach (var element in elements)
                {
                    uniqueElemnents.Add(element);
                }
            }


            Console.WriteLine(String.Join(' ',uniqueElemnents.OrderBy(x => x)));



        }
    }
}
