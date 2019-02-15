using System;
using System.Collections;
using System.Collections.Generic;

namespace IteratorsAndComparators
{
    public class ListyIterator<T> : IEnumerable<T>
    {
        private List<T> list;
        public int currentIndex;
        
        public ListyIterator(List<T> newList)
        {
            this.list = newList;
            this.currentIndex = 0;
        }

        public bool Move()
        {
            if (currentIndex + 1 < this.list.Count)
            {
                this.currentIndex++;
                return true;
            }
            return false;
        }

        public bool HasNext()
        {
            if (this.currentIndex + 1 < this.list.Count)
            {
                return true;
            }
            return false;
        }

        public string Print()
        {
            if (this.list.Count == 0)
            {
                return "Invalid Operation!";
            }
            return this.list[currentIndex].ToString();
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < this.list.Count; i++)
            {
                yield return this.list[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public string PrintAll()
        {
            return string.Join(" ", this.list);
        }

    }

}
