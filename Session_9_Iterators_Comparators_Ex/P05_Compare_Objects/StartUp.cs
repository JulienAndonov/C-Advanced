using System;
using System.Collections.Generic;
using System.Linq;

namespace P05_Compare_Objects
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();


            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var splittedEntries = input.Split(" ").ToArray();
                var currentUser = new Person(splittedEntries);
                people.Add(currentUser);
            }

            var personToCompare = int.Parse(Console.ReadLine()) - 1;

            var numOfEqual = people.Count(p => p.CompareTo(people[personToCompare]) == 0);
            var numNotEqual = people.Count(p => p.CompareTo(people[personToCompare]) != 0);
            var numTotal = people.Count();

            if (numOfEqual > 1)
            {
                Console.WriteLine($"{numOfEqual} {numNotEqual} {numTotal}");
            }
            else
            {
                Console.WriteLine("No matches");
            }
            



        }
    }
}
