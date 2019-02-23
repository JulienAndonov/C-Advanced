using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Pet_ClinicV2
{
    public class Car
    {
        public string Name { get; set; }
        public int Year { get; set; }


        public Car(string name, int year)
        {
            this.Name = name;
            this.Year = year;
        }
    }
}
