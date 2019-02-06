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

        public Car(string newModel, int newEnginePower, int newEngineSpeed) : base()
        {
            this.Model = newModel;
        }


    }
}
