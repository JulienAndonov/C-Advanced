using System;
using System.Collections.Generic;
using System.Text;

namespace P07_Tuple
{
    public class Tuple<T,K>
    {
        private T item1;
        private K item2;

        public Tuple(T Item1, K Item2)
        {
            this.item1 = Item1;
            this.item2 = Item2;
        }

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2}";
        }
    }
}
