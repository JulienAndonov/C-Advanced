using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Pet_Clinic
{
    public class Pet
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Kind { get; set; }



        public Pet(string newName, int newAge, string newKind)
        {
            this.Name = newName;
            this.Age = newAge;
            this.Kind = newKind;
        }

        public override string ToString()
        {
            return $"{Name} {Age} {Kind}";
        }
    }
}
