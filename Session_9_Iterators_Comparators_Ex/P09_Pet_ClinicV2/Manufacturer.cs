using System;
using System.Collections.Generic;
using System.Text;

namespace P08_Pet_ClinicV2
{
    public class Manufacturer
    {
        public string Name { get; set; }
        public string HeadQuarters { get; set; }


        public Manufacturer(string name, string headQuarters)
        {
            this.Name = name;
            this.HeadQuarters = headQuarters;
        }
    }
}
