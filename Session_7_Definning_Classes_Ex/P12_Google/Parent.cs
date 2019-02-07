using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Parent

    {

        public Parent(string parentsName, string parentBirthday)

        {

            this.ParentsName = parentsName;

            this.ParentBirthday = parentBirthday;

        }



        public string ParentsName { get; set; }



        public string ParentBirthday { get; set; }

    }
}
