using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person

    {

        public string Name { get; set; }



        public string Birthday { get; set; }



        public List<Parent> Parent { get; set; } = new List<Parent>();



        public List<Child> Children { get; set; } = new List<Child>();

    }
}
