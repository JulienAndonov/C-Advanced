using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int numOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();



            for (int i = 0; i < numOfCars; i++)
            {
                var inputCarEntries = Console.ReadLine().Split(" ");
                var model = inputCarEntries[0];
                var fuelCapacity = int.Parse(inputCarEntries[1]);
                var fuelConsumpation = decimal.Parse(inputCarEntries[2]);
                var currentCar = new Car(model, fuelCapacity, fuelConsumpation, 0);
                cars.Add(currentCar);
            }

            while (true)
            {
                var inputEntries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (inputEntries[0] == "End")
                {
                    break;
                }

                var model = inputEntries[1];
                var kmToDrive = int.Parse(inputEntries[2]);
                var currentCar = cars.Where(x => x.Model == model).First();

                var isSuccessFull = Car.Drive(currentCar, kmToDrive);

                if (!isSuccessFull)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
            }


            foreach (var car in cars)
            {
                Console.WriteLine($"{car.Model} {car.FuelCapacity:F2} {car.Distance}");
            }


        }
    }
}
