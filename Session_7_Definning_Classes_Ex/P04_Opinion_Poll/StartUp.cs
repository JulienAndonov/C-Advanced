using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int numOfPeople = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfPeople; i++)
            {
                var entries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = entries[0];
                var age = int.Parse(entries[1]);

                var currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }

            foreach (var person in people.Where(p => p.Age > 30).OrderBy(x => x.Name))
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
