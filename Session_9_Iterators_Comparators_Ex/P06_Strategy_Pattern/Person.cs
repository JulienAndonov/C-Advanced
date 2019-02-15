using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Strategy_Pattern
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string newname, int newAge)
        {
            this.Name = newname;
            this.Age = newAge;
        }


        public override string ToString()
        {
            return this.Name + " " + this.Age;
        }
    }
}
