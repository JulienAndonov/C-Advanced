using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DefiningClasses
{
    public class Car
    {
        private string model;
        private Engine engine;
        private int weight;
        private string color;



        public string Model
        {
            get { return this.model; }
            set { this.model = value; }
        }


        public Engine Engine
        {
            get { return this.engine; }
            set { this.engine = value; }
        }

        public int Weight
        {
            get { return this.weight; }
            set { this.weight = value; }
        }

        public string Color
        {
            get { return this.color; }
            set { this.color = value; }
        }


        public Car(string newModel, Engine newEngine, int newWeight, string newColor)
        {
            this.Model = newModel;
            this.Engine = newEngine;
            this.Weight = newWeight;
            this.Color = newColor;
        }


        public String toString()
        {
            StringBuilder displayCar = new StringBuilder();

            displayCar.AppendLine($"{this.Model}:");
            displayCar.AppendLine($"  {this.Engine.Model}:");
            displayCar.AppendLine($"    Power: {this.Engine.Power}");
            if (this.Engine.Displacement > 0)
            {
                displayCar.AppendLine($"    Displacement: {(this.Engine.Displacement)}");
            }
            else
            {
                displayCar.AppendLine($"    Displacement: n/a");
            }

            displayCar.AppendLine($"    Efficiency: {this.engine.Efficiency ?? "n/a"}");

            if (this.Weight != -1)
            {
                displayCar.AppendLine($"  Weight: {this.Weight}");
            }
            else
            {
                displayCar.AppendLine($"  Weight: n/a");
            }

            displayCar.AppendLine($"  Color: {this.Color ?? "n/a"}");

            return displayCar.ToString();
        }

    }
}
