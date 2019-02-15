using System;
using System.Collections.Generic;
using System.Text;
using P06_Strategy_Pattern;

namespace P07_Equality_Logic
{
    public class SortedComparer : IComparer<Person>
    {
        public int Compare(Person first, Person second)
        {
            var compareResult = first.Name.CompareTo(second.Name);

            if (compareResult == 0)
            {
                compareResult = first.Age.CompareTo(second.Age);
            }

            return compareResult;
        }
    }
}
