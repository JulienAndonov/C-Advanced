using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Threeuple
{
    public class Threeuple<T, K, V>
    {
        private T item1;
        private K item2;
        private V item3;



        public Threeuple(T newItemT, K newItemK, V newItemV)
        {
            this.item1 = newItemT;
            this.item2 = newItemK;
            this.item3 = newItemV;
        }
        

        public override string ToString()
        {
            return $"{this.item1} -> {this.item2} -> {this.item3}";
        }
    }
}
