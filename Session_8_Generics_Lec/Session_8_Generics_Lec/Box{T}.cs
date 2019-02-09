using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BoxOfT
{
    public class Box<T>
    {
        public List<T> List { get; }

        public int Count { get; private set; }

        public T Remove()
        {
            var lastValueIndex = this.List.Count - 1;
            var lastValue = this.List[lastValueIndex];
            this.List.RemoveAt(lastValueIndex);
            this.Count--;
            return lastValue;
        }

        public void Add(T value)
        {
            this.List.Add(value);
            this.Count++;
        }

        public Box()
        {
            this.List = new List<T>();
        }
    }
}