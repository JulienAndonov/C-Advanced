using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;


        public Parking(int capacity)
        {
            this.cars = new List<Car>();
            this.capacity = capacity;
        }

        public int Count => this.cars.Count;

        public string AddCar(Car car)
        {
            int index = this.cars
                .FindIndex(x => x.RegistrationNumber == car.RegistrationNumber);

            if (index != -1)
            {
                return "Car with that registration number, already exists!";

            }
            else if (this.cars.Count == this.capacity)
            {
                return "Parking is full!";
            }


            this.cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
        }

        public string RemoveCar(string registrationNumber)
        {

            int index = this.cars
                .FindIndex(x => x.RegistrationNumber == registrationNumber);

            if (index == -1)
            {
                return "Car with that registration number, doesn't exist!";
            }

            this.cars.RemoveAt(index);
            return $"Successfully removed {registrationNumber}";

        }

        public Car GetCar(string registrationNumber)
        {
            var index = this.cars
                .FindIndex(x => x.RegistrationNumber == registrationNumber);
            return this.cars[index];
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var registrationNumber in registrationNumbers)
            {
                RemoveCar(registrationNumber);
            }
        }

     
    }
}
