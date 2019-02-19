using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
            this.MidIndex = rooms.Length / 2;
        }

        public bool Add(Pet pet)
        {

            for (int i = 0; i <= MidIndex; i++)
            {
                if (this.rooms[MidIndex - i].HasFreeSpace())
                {
                    var index = Array.FindIndex(this.rooms[MidIndex - i].pets, 0, x => x.Name != null);
                    rooms[MidIndex - i].pets[index] = pet;
                    return true;
                }

                if (this.rooms[MidIndex + i].HasFreeSpace())
                {
                    var index = Array.FindIndex(this.rooms[MidIndex - i].pets, 0, x => x.Name != null);
                    rooms[MidIndex - i].pets[index] = pet;
                    return true;
                }
            }
            return false;
        }

        public bool Release(string petName)
        {
            foreach (var room in rooms)
            {
                if (room.pets.Where(x => x.Name == petName).FirstOrDefault() != null)
                {
                    var indexOfThePet = Array.FindIndex(room.pets, 0, x => x.Name == petName);
                    room.pets[indexOfThePet] = null;
                    return true;
                }
            }
            return false;
        }

        public void Print()
        {
            for (int i = 0; i < this.rooms.Length; i++)
            {
                Console.WriteLine(string.Join("\n", this.rooms[i].pets.ToString()));
            }
        }

        public void PrintRoomInfo(int index)
        {
            if (this.rooms[index].pets.Length == 0)
            {
                Console.WriteLine("Room Empty");
                return;
            }
            Console.WriteLine(System.Environment.NewLine, this.rooms[index].pets.ToString());
        }

        public bool HasEmptyRooms()
        {
            return this.rooms.Any(x => x.pets == null);
        }



    }
}
