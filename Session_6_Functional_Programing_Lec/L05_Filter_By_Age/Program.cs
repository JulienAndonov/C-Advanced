using System;
using System.Collections.Generic;
using System.Linq;


namespace L05_Filter_By_Age
{

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }



    }

    class Program
    {
        static void Main(string[] args)
        {
            int totalNumOfPeople = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();


            for (int i = 0; i < totalNumOfPeople; i++)
            {
                var currentPerson = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var currentName = currentPerson[0];
                var currentAge = int.Parse(currentPerson[1]);


                var person = new Person
                {
                    Name = currentName,
                    Age = currentAge
                };
                people.Add(person);
            }

            string condition = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());

            Func<Person, bool> filterPredicate;

            if (condition == "older")
            {
                filterPredicate = p => p.Age >= age;
            }
            else
            {
                filterPredicate = p => p.Age < age;
            }

            Func<Person, string> selectFunc;

            string format = Console.ReadLine();

            if (format == "name age")
            {
                selectFunc = p => $"{p.Name} - {p.Age}";
            }
            else
            {
                selectFunc = p => $"{p.Name}";
            }

            people
                .Where(filterPredicate)
                .Select(selectFunc)
                .ToList()
                .ForEach(Console.WriteLine);

        }
    }
}
