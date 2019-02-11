using System;
using System.Collections.Generic;
using System.Text;

namespace P02_Generic_Box_Integers
{
    class Box<T>
    {
        public T value { get; set; }

        public Box(T newValue)
        {
            this.value = newValue;
        }

        public override string ToString()
        {
            var returnType = this.value.GetType();
            var returnString = $"{returnType}: {this.value}";

            return returnString;
        }
    }
}
