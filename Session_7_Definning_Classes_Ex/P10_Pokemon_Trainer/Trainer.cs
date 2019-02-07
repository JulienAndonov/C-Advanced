using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Trainer
    {
        private string name;
        private int numOfBadges;
        private List<Pokemon> pokemons;

        public string Name
        {
            get => name;
            set => name = value;
        }

        public int NumOfBadges
        {
            get => numOfBadges;
            set => numOfBadges = value;
        }

        public List<Pokemon> Pokemons
        {
            get => pokemons;
            set => pokemons = value;
        }

        public Trainer(string newName, int newBadges, List<Pokemon> newPokemons)
        {
            Name = newName;
            NumOfBadges = newBadges;
            Pokemons = newPokemons;
        }


    }
}
