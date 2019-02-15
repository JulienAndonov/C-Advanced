using System;
using System.Collections.Generic;
using System.Text;

namespace P06_Strategy_Pattern
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            var compare = first.Age.CompareTo(second.Age);

            return compare;
        }
    }
}
