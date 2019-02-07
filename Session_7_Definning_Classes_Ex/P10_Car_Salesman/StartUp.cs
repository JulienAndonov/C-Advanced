using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfEngines = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            List<Engine> engines = new List<Engine>();


            for (int i = 0; i < numOfEngines; i++)
            {
                var input = Console.ReadLine().Split(" ");
                var engineModel = input[0];
                var enginePower = int.Parse(input[1]);
                string engineEfficiency = null;
                var engineDisplacement = 0;

                if (input.Length == 3)
                {
                    if (int.TryParse(input[2], out int newDisplacement))
                    {
                        engineDisplacement = newDisplacement;
                    }
                    else
                    {
                        engineEfficiency = input[2];
                    }

                }
                else if (input.Length == 4)
                {
                    engineDisplacement = int.Parse(input[2]);
                    engineEfficiency = input[3];
                }

                var currentEngine = new Engine(engineModel, enginePower, engineDisplacement, engineEfficiency);
                engines.Add(currentEngine);
            }


            int numOfCars = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfCars; i++)
            {
                var carInputEntries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var carModel = carInputEntries[0];
                var carEngine = carInputEntries[1];
                int carWeight = -1;
                string carColor = null;


                if (carInputEntries.Length == 3)
                {
                    if (int.TryParse(carInputEntries[2], out int newWeight))
                    {
                        carWeight = newWeight;
                    }
                    else
                    {
                        carColor = carInputEntries[2];
                    }
                }
                else if (carInputEntries.Length == 4)
                {
                    carWeight = int.Parse(carInputEntries[2]);
                    carColor = carInputEntries[3];
                }

                var engineIndex = engines.FindIndex(x => x.Model == carEngine);
                var currentCar = new Car(carModel, engines[engineIndex], carWeight, carColor);

                cars.Add(currentCar);
            }


            foreach (var car in cars)
            {
                Console.Write(car.toString());
            }

           // cars.ForEach(Console.WriteLine();



        }
    }
}
