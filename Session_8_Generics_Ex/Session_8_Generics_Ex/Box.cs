using System;
using System.Collections.Generic;
using System.Text;

namespace Session_8_Generics_Ex
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
