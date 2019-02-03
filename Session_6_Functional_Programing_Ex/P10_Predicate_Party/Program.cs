using System;
using System.Collections.Generic;
using System.Linq;

namespace P10_Predicate_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();



            while (true)
            {
                var entries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (entries[0] == "Party!")
                {
                    Console.WriteLine(guests.Any() ? $"{String.Join(", ", guests)} are going to the party!" : "Nobody is going to the party!");
                    break;
                }

                var command = entries[0];
                var filterCommand = entries[1];
                var criteria = entries[2];

                Func<string, string, bool> predicate = GetFunc(filterCommand);

                switch (command)
                {
                    case "Double":

                        List<string> guestsToAdd = guests.Where(x => predicate(x, criteria)).ToList();

                        foreach (var name in guestsToAdd)
                        {
                            var index = guests.IndexOf(name);
                            guests.Insert(index + 1, name);
                        }

                        break;

                    case "Remove":

                        guests = guests.Where(x => !predicate(x, criteria)).ToList();

                        break;
                }
            }
        }

        public static Func<string, string, bool> GetFunc(string filterCommand)
        {
            if (filterCommand == "StartsWith")
            {
                return (x, c) => x.StartsWith(c);
            }
            else if (filterCommand == "EndsWith")
            {
                return (x, c) => x.EndsWith(c);
            }
            else if (filterCommand == "Length")
            {
                return (x, c) => x.Length == int.Parse(c);
            }
            return null;
        }

    }
}
