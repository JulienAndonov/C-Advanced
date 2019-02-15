using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace P06_Strategy_Pattern
{
    public class NameLengthComparator : IComparer<Person>
    {
        public Person CurrentPerson;

        public int Compare(Person first, Person second)
        {
            var compare =first.Name.Length.CompareTo(second.Name.Length);

            if (compare == 0)
            {
                compare = first.Name[0].ToString().ToUpper().CompareTo(second.Name[0].ToString().ToUpper());
            }
            return compare;
        }
    }
}
