using System;
using System.Collections.Generic;
using System.Linq;

namespace P12_Inferno_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> gems = Console.ReadLine().Split(" ").Select(int.Parse).ToList();
            List<string> commands = new List<string>();
            Predicate<int> predicate;
            gems.Insert(0, 0);
            gems.Add(0);


            while (true)
            {
                var input = Console.ReadLine();


                if (input == "Forge")
                {
                    break;
                }


                var entries = input.Split(";", StringSplitOptions.RemoveEmptyEntries);
                var command = entries[0];
                var currentCommand = entries[1] + ";" + entries[2];

                if (command == "Reverse")
                {
                    commands.Remove(currentCommand);
                }
                else
                {
                    commands.Add(currentCommand);

                }
            }


            for (int i = 0; i < commands.Count; i++)
            {
                var entries = commands[i].Split(";", StringSplitOptions.RemoveEmptyEntries);
                var filter = entries[0];
                var criteria = int.Parse(entries[1]);
                predicate = GetPredicate(gems, filter, criteria);

                for (int j = 1; j < gems.Count - 1; j++)
                {
                    if (predicate(j))
                    {
                        gems.RemoveAt(j);
                    }
                }
            }

            gems.RemoveAt(gems.Count - 1);
            gems.RemoveAt(0);
            Console.WriteLine(String.Join(" ", gems));
        }


        public static Predicate<int> GetPredicate(List<int> gems, string filter, int criteria)
        {
            switch (filter)
            {
                case "Sum Left":
                    return i => gems[i - 1] + gems[i] == criteria;
                case "Sum Right":
                    return i => gems[i] + gems[i + 1] == criteria;
                case "Sum Left Right":
                    return i => gems[i - 1] + gems[i] + gems[i + 1] == criteria;
            }
            return null;
        }
    }
}
