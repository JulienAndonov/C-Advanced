using System;
using System.Collections.Generic;
using System.Linq;

namespace P11_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> guests = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();

            List<string> commands = new List<string>();
            Predicate<string> predicate;

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Print")
                {
                    break;
                }

                var entries = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var firstCommand = entries[0].Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var currentCommand = entries[1] + ";" + entries[2];

                if (firstCommand[0] == "Remove")
                {
                    commands.Remove(currentCommand);
                }
                else
                {
                    commands.Add(currentCommand);
                }
            }

            foreach (var command in commands)
            {
                var entries = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var filter = entries[0];
                var criteria = entries[1];

                predicate = GetPredicate(filter, criteria);
                guests.RemoveAll(predicate);
            }

            Console.WriteLine(String.Join(" ",guests));
        }

        public static Predicate<string> GetPredicate(string filter, string criteria)
        {
            switch (filter)
            {
                case "Starts with":
                    return p => p.StartsWith(criteria);
                case "Ends with":
                    return p => p.EndsWith(criteria);
                case "Contains":
                    return p => p.Contains(criteria);
                case "Length":
                    return p => p.Length == int.Parse(criteria);
            }
            return null;
        }
    }
}
