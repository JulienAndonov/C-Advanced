using System;
using System.Collections.Generic;
using System.Linq;

namespace L06_Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parkingLot = new HashSet<string>();
            while (true)
            {
                var command = Console.ReadLine();
                if (command == "END")
                {
                    if(parkingLot.Count() == 0)
                    {
                        Console.WriteLine("Parking Lot is Empty");
                    }
                    else
                    {
                        Console.WriteLine(String.Join(System.Environment.NewLine,parkingLot));
                    }
                    break;
                }


                var entries = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var direction = entries[0];
                var carPlate = entries[1];

                if (direction == "IN")
                {
                    parkingLot.Add(carPlate);
                }
                else
                {
                    parkingLot.Remove(carPlate);
                }
            }
        }
    }
}