﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon

    {

        public Pokemon(string pokemonName, string pokemonType)

        {

            this.PokemonName = pokemonName;

            this.PokemonType = pokemonType;

        }



        public string PokemonName { get; set; }



        public string PokemonType { get; set; }

    }
}
