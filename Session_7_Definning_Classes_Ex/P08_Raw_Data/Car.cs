using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private Cargo cargo;
        private List<Tire> tires = new List<Tire>(4);


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


        public Engine Engine
        {
            get
            {
                return this.engine;
            }
            set
            {
                this.engine = value;
            }
        }

        public Cargo Cargo
        {
            get
            {
                return this.cargo;
            }
            set
            {
                this.cargo = value;
            }
        }

        public List<Tire> Tires
        {
            get
            {
                return this.tires;
            }
            set
            {
                this.tires = value;
            }
        }

        public Car(string newModel, int newEnginePower, int newEngineSpeed, int newCargoWeight, string newCargoType, double newTire1Pressure, int newTire1Age, double newTire2Pressure, int newTire2Age, double newTire3Pressure, int newTire3Age, double newTire4Pressure, int newTire4Age)
        {
            this.Model = newModel;
            this.Engine = new Engine(newEngineSpeed, newEnginePower);
            this.Cargo = new Cargo(newCargoWeight, newCargoType);

            this.Tires = new List<Tire>()
            {
                new Tire(newTire1Pressure,newTire1Age),
                new Tire(newTire2Pressure,newTire2Age),
                new Tire(newTire3Pressure,newTire3Age),
                new Tire(newTire4Pressure,newTire4Age),
            };
        }
    }
}
