using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace P09_Pet_ClinicV2
{
    public class Room
    {
        public Pet[] pets;
        public int capacity;

        public Room()
        {
            this.pets = new Pet[capacity];
        }


        public bool HasFreeSpace()
        {
            if (pets.Where(x => x.Name != null).Count() != this.capacity)
            {
                return true;
            }

            return false;
        }


    }
}
