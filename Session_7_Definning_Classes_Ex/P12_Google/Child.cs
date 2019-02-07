using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Child

    {

        public Child(string childName, string childBirthday)

        {

            this.ChildName = childName;

            this.ChildBirthday = childBirthday;

        }



        public string ChildName { get; set; }



        public string ChildBirthday { get; set; }

    }
}
