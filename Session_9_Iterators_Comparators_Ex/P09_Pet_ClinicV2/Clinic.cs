using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P09_Pet_ClinicV2
{
    public class Clinic
    {
        public string Name { get; set; }
        private Room[] rooms;
        private int MidIndex;


        public Clinic(string name, int capacity)
        {

            if (capacity % 2 == 0)
            {
                throw new InvalidOperationException("Invalid Operation!");
            }

            this.Name = name;
            this.rooms = new Room[capacity];
            this.MidIndex = this.rooms.Length / 2;
        }
        
        public bool Add(Pet pet)
        {
            for (int i = 0; i < MidIndex; i++)
            {
                if (rooms[MidIndex - i] == null)
                {
                    rooms[MidIndex].pet = pet;
                    return true;
                }

                if (rooms[MidIndex + i] == null)
                {
                    rooms[MidIndex + i].pet = pet;
                    return true;
                }
            }
            return false;
        }

        public bool Release()
        {
            for (int i = MidIndex; i < this.rooms.Length; i++)
            {
                if (rooms[i].pet != null)
                {
                    rooms[i].pet = null;
                    return true;
                }

                if (rooms[this.rooms.Length - i - 1].pet != null)
                {
                    rooms[this.rooms.Length - i - 1].pet = null;
                    return true;
                }
            }
            return false;
        }

        public void Print()
        {
            foreach (var room in this.rooms)
            {
                if (room.pet == null)
                {
                    Console.WriteLine("Room Empty");
                }
                else
                {
                    Console.WriteLine(room.pet);
                }

            }
        }

        public void PrintRoomInfo(int index)
        {
            if (this.rooms[index].pet == null)
            {
                Console.WriteLine("Room Empty");
                return;
            }
            Console.WriteLine(this.rooms[index].pet.ToString());
        }

        public bool HasEmptyRooms()
        {
            return this.rooms.Any(x => x.pet == null);
        }

    }
}
