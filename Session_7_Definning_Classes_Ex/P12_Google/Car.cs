using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car

    {

        public Car(string carModel, double carSpeed)

        {

            this.CarModel = carModel;

            this.CarSpeed = carSpeed;

        }



        public string CarModel { get; set; }



        public double CarSpeed { get; set; }

    }
}
