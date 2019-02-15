using System;
using System.Collections.Generic;

namespace P06_Strategy_Pattern
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();


            for (int i = 0; i < numOfPeople; i++)
            {
                var input = Console.ReadLine().Split(" ");

                var name = input[0];
                var age = int.Parse(input[1]);

                var currentPerson = new Person(name, age);
                people.Add(currentPerson);
            }


            SortedSet<Person> sortedByNameLength = new SortedSet<Person>(people, new NameLengthComparator());

            SortedSet<Person> sortedByAge = new SortedSet<Person>(people, new AgeComparator());


            foreach (var person in sortedByNameLength)
            {
                Console.WriteLine(person);
            }

            foreach (var person in sortedByAge)
            {
                Console.WriteLine(person);
            }
        }
    }
}
