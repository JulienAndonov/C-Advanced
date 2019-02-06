﻿using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                this.age = value;
            }
        }

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }

        public Person(int newAge)
        {
            this.Age = newAge;
            this.Name = "No name";
        }

        public Person(string newName, int newAge)
        {
            this.Name = newName;
            this.Age = newAge;
        }



    }
}
