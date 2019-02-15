using System;
using System.Collections.Generic;
using P06_Strategy_Pattern;

namespace P07_Equality_Logic
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            int numOfPeople = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfPeople; i++)
            {
                var inputVariables = Console.ReadLine().Split(" ");
                var name = inputVariables[0];
                var Age = int.Parse(inputVariables[1]);

                var currentPerson = new Person(name, Age);

                people.Add(currentPerson);
            }


            SortedSet<Person> sortedPeople = new SortedSet<Person>(people, new SortedComparer());
            HashSet<Person> hashedPeople = new HashSet<Person>(people, new EqualityComparer());

            Console.WriteLine(sortedPeople.Count);
            Console.WriteLine(hashedPeople.Count);
        }
    }
}
