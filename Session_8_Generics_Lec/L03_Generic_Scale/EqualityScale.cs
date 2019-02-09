using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using Microsoft.VisualBasic.CompilerServices;

namespace GenericScale
{
    public class EqualityScale<T>
    {
        public T Left { get; private set; }
        public T Right { get; private set; }

        public bool isEqual { get; private set; }

        public EqualityScale(T left, T right)
        {
            this.Left = left;
            this.Right = right;
        }


        public bool AreEqual()
        {
            if (this.Left.Equals(this.Right))
            {
                this.isEqual = true;
                return true;
            }

            this.isEqual = false;
            return false;
        }

    }
}
