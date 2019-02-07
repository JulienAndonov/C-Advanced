using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Trainer> trainers = new List<Trainer>();


            while (true)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input[0] == "Tournament")
                {
                    break;
                }

                var trainerName = input[0];
                var pokemonName = input[1];
                var pokemonElement = input[2];
                var pokemonHealth = int.Parse(input[3]);
                var currentPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

                if (trainers.FindIndex(t => t.Name == trainerName) == -1)
                {
                    trainers.Add(new Trainer(trainerName, 0, new List<Pokemon>()));
                }

                var index = trainers.FindIndex(t => t.Name == trainerName);
                trainers[index].Pokemons.Add(currentPokemon);
            }

            while (true)
            {

                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }

                Func<Trainer, bool> getPredicate = GetFunc(input);
                foreach (var trainer in trainers)
                {
                    if (getPredicate(trainer))
                    {
                        trainer.NumOfBadges++;
                    }
                    else
                    {
                        foreach (var pokemon in trainer.Pokemons)
                        {
                            pokemon.Health -= 10;
                        }
                        
                        trainer.Pokemons.RemoveAll(t => t.Health <= 0);
                        
                    }
                }
            }


            foreach (var trainer in trainers.OrderByDescending(t => t.NumOfBadges))
            {
                Console.WriteLine($"{trainer.Name} {trainer.NumOfBadges} {trainer.Pokemons.Count()}");
            }

        }


        public static Func<Trainer, bool> GetFunc(string type)
        {

            return x => x.Pokemons.Any(t => t.Element == type);

        }
    }
}
