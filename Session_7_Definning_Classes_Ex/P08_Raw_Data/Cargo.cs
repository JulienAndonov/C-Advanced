using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        private int cargoWeight;
        private string cargoType;

        public int CargoWeight
        {
            get
            {
                return this.cargoWeight;
            }
            set
            {
                this.cargoWeight = value;
            }
        }


        public string CargoType
        {
            get
            {
                return this.cargoType;
            }
            set
            {
                this.cargoType = value;
            }
        }


        public Cargo(int newCargoWeight,string newCargoType)
        {
            this.CargoWeight = newCargoWeight;
            this.CargoType = newCargoType;
        }

    }
}
