using System;
using System.Collections.Generic;
using System.Text;
using P06_Strategy_Pattern;

namespace P07_Equality_Logic
{
    public class EqualityComparer : IEqualityComparer<Person>
    {
        public bool Equals(Person first, Person second)
        {
            if (first.Name == second.Name && first.Age == second.Age)
            {
                return true;
            }
            return false;
        }

        public int GetHashCode(Person obj)
        {
            return obj.Name.GetHashCode() + obj.Age.GetHashCode();
        }
    }
}
