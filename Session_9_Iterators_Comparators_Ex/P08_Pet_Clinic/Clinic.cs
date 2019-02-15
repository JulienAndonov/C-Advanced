using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace P08_Pet_Clinic
{
    public class Clinic
    {
        public string Name { get; set; }
        private Pet[] Rooms;
        private int midIndex;


        public Clinic(string name, int rooms)
        {
            if (rooms % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            this.Name = name;
            this.Rooms = new Pet[rooms];
            this.midIndex = this.Rooms.Length / 2;
        }


        public bool Add(Pet pet)
        {
            for (int i = 0; i <= midIndex; i++)
            {
                if (this.Rooms[midIndex - i] == null)
                {
                    this.Rooms[midIndex - i] = pet;
                    return true;
                }

                if (this.Rooms[midIndex + i] == null)
                {
                    this.Rooms[midIndex + i] = pet;
                    return true;

                }

            }
            return false;
        }

        public bool Release()
        {
            for (int i = midIndex; i < this.Rooms.Length; i++)
            {
                if (this.Rooms[i] != null)
                {
                    this.Rooms[i] = null;
                    return true;
                }

                if (this.Rooms[this.Rooms.Length - i - 1] != null)
                {
                    this.Rooms[this.Rooms.Length - i - 1] = null;
                    return true;
                }
            }
            return false;
        }

        public bool HasEmptyRooms()
        {
            return this.Rooms.Any(r => r == null);
        }


        public void Print()
        {
            foreach (var pet in this.Rooms)
            {
                if (pet == null)
                {
                    Console.WriteLine("Room empty");
                }
                else
                {
                    Console.WriteLine(pet);
                }
            }
        }

        public void PrintRoomInfo(int index)
        {
            Pet pet = this.Rooms[index];
            if (pet == null)
            {
                Console.WriteLine("Room empty");
            }
            else
            {
                Console.WriteLine(pet);
            }
        }
    }
}
