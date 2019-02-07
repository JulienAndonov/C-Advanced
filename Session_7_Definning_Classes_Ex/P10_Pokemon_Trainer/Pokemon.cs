﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Pokemon
    {
        private string name;
        private string element;
        private int health;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Element
        {
            get { return this.element; }
            set { this.element = value; }
        }


        public int Health
        {
            get { return this.health; }
            set { this.health = value; }
        }


        public Pokemon(string newName, string newElement, int newHealth)
        {
            this.Name = newName;
            this.Element = newElement;
            this.Health = newHealth;
        }

    }
}
