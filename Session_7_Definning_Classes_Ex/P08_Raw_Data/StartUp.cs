using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

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
                var carEntries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var model = carEntries[0];
                var engineSpeed = int.Parse(carEntries[1]);
                var enginePower = int.Parse(carEntries[2]);
                var cargoWeight = int.Parse(carEntries[3]);
                var cargpType = carEntries[4];
                var tirePressure1 = double.Parse(carEntries[5]);
                var tireAge1 = int.Parse(carEntries[6]);

                var tirePressure2 = double.Parse(carEntries[7]);
                var tireAge2 = int.Parse(carEntries[8]);

                var tirePressure3 = double.Parse(carEntries[9]);
                var tireAge3 = int.Parse(carEntries[10]);

                var tirePressure4 = double.Parse(carEntries[11]);
                var tireAge4 = int.Parse(carEntries[12]);

                var currentCar = new Car(model, enginePower, engineSpeed, cargoWeight, cargpType, tirePressure1,
                    tireAge1, tirePressure2, tireAge2, tirePressure3, tireAge3, tirePressure4, tireAge4);

                cars.Add(currentCar);
            }

            var filter = Console.ReadLine();


            foreach (var car in cars)
            {
                var GetPredicate = FilterFunc(filter);
                if (GetPredicate(car))
                {
                    Console.WriteLine(car.Model);
                }
            }



        }


        public static Func<Car, bool> FilterFunc(string filterCommand)
        {
            if (filterCommand == "fragile")
            {
                return x => x.Cargo.CargoType == "fragile" && x.Tires.Any(t => t.TirePressue < 1);
            }
            else if (filterCommand == "flamable")
            {
                return x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250;
            }


            return null;
        }
    }
}
