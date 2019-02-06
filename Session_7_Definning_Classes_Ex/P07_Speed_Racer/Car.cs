using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private decimal fuelCapacity;
        private decimal fuelConsumptionPerKilometer;
        private decimal distance;


        public string Model
        {
            get
            {
                return this.model;
            }
            set
            {
                this.model = value;
            }
        }


        public decimal FuelCapacity
        {
            get
            {
                return this.fuelCapacity;
            }
            set
            {
                this.fuelCapacity = value;
            }
        }

        public decimal FuelConsumptionPerKilometer
        {
            get
            {
                return this.fuelConsumptionPerKilometer;
            }
            set
            {
                this.fuelConsumptionPerKilometer = value;
            }
        }

        public decimal Distance
        {
            get
            {
                return this.distance;
            }
            set
            {
                this.distance = value;
            }
        }

        public Car(string newModel, int newCapacity, decimal newFuelConsumption, decimal newDistance)
        {
            this.Model = newModel;
            this.FuelCapacity = newCapacity;
            this.FuelConsumptionPerKilometer = newFuelConsumption;
            this.Distance = newDistance;
        }


        public static bool Drive(Car car, int kmToDrive)
        {
            if (car.FuelCapacity >= car.FuelConsumptionPerKilometer * kmToDrive)
            {
                car.FuelCapacity -= car.FuelConsumptionPerKilometer * kmToDrive;
                car.distance += kmToDrive;
                return true;
            }
            return false;
        }
    }
}
