using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace IteratorsAndComparators
{
    public class CoolStack<T> : IEnumerable<T>
    {
        private List<T> data;
        
        public CoolStack()
        {
            this.data = new List<T>();
        }


        public void Push(params T[] values)
        {
            data.AddRange(values);
        }

        public T Pop()
        {
            if (this.data.Count == 0)
            {
                throw new ArgumentException("No elements");

            }

            T lastElement = data[data.Count - 1];
            data.RemoveAt(data.Count - 1);
            return lastElement;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = data.Count - 1; i >= 0; i--)
            {
                yield return data[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
