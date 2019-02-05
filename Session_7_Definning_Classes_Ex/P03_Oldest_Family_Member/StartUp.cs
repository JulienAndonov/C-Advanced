using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var numOfPeople = int.Parse(Console.ReadLine());
            Family family = new Family(new List<Person>());

            for (int i = 0; i < numOfPeople; i++)
            {
                var entries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                var name = entries[0];
                var age = int.Parse(entries[1]);

                var currentPerson = new Person(name,age);

                family.AddMember(currentPerson);
            }

            var oldestPerson = family.GetOldestMember();

            Console.WriteLine($"{oldestPerson.Name} {oldestPerson.Age}");

        }
    }
}
