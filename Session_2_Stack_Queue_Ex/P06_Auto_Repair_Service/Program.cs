using System;
using System.Collections.Generic;
using System.Linq;

namespace P06_Auto_Repair_Service
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> vehiclesToService = new Queue<string>(Console.ReadLine().Split());
            Stack<string> vehiclesServed = new Stack<string>();
            while (true)
            {
                string input = Console.ReadLine();

                if (input == "End")
                {
                    if (vehiclesToService.Any())
                    {
                        Console.Write("Vehicles for service: ");
                        Console.WriteLine(String.Join(", ", vehiclesToService));
                    }
                    Console.Write("Served vehicles: ");
                    Console.WriteLine(String.Join(", ", vehiclesServed));
                    break;
                }

                var tokens = input.Split('-');
                var command = tokens[0];


                switch (command)
                {
                    case "Service":
                        if (vehiclesToService.Count > 0)
                        {
                            string servedVehicle = vehiclesToService.Dequeue();
                            Console.WriteLine($"Vehicle {servedVehicle} got served.");
                            vehiclesServed.Push(servedVehicle);
                        }
                        break;

                    case "CarInfo":
                        var carToCheck = tokens[1];
                        if (vehiclesToService.Contains(carToCheck))
                        {
                            Console.WriteLine("Still waiting for service.");
                        }

                        if (vehiclesServed.Contains(carToCheck))
                        {
                            Console.WriteLine("Served.");
                        }
                        break;
                    case "History":
                        Console.WriteLine(String.Join(", ", vehiclesServed));
                        break;

                }

            }
        }
    }
}
