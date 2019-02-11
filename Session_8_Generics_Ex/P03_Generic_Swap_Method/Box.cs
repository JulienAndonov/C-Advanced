using System;
using System.Collections.Generic;
using System.Text;

namespace P03_Generic_Swap_Method
{
    class Box<T>
    {
        private List<T> data;

        public Box()
        {
            this.data = new List<T>();
        }

        public void Add(T item) => this.data.Add(item);

        public List<T> Data => this.data;

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (var value in this.data)
            {
                stringBuilder.AppendLine($"{typeof(T)}: {value}");
            }
            return stringBuilder.ToString().TrimEnd();
        }
    }
}
