using System;
using System.Collections.Generic;
using System.Text;

namespace P05_Compare_Objects
{
    public class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }


        public int CompareTo(Person other)
        {
            var compare = this.Name.CompareTo(other.Name);
            if (compare == 0)
            {
                compare = this.Age.CompareTo(other.Age);
                if (compare == 0)
                {
                    compare = this.Town.CompareTo(other.Town);
                }
            }

            return compare;
        }

        public Person(params string[] valueStrings)
        {
            this.Name=  valueStrings[0];
            this.Age = int.Parse(valueStrings[1]);
            this.Town = valueStrings[2];
        }
    }
}
