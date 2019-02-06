using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Tire
    {
        private double tirePressure;
        private int tireAge;



        public double TirePressue
        {
            get
            {
                return this.tirePressure;
            }
            set
            {
                this.tirePressure = value;
            }
        }

        public int TireAge
        {
            get
            {
                return this.tireAge;
            }
            set
            {
                this.tireAge = value;
            }
        }


        public Tire(double newTirePressue, int newTireAge)
        {
            this.TirePressue = newTirePressue;
            this.TireAge = newTireAge;
        }
    }
}
