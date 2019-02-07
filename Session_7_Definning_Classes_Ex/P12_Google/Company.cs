using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Company

    {

        public Company(string companyName, string department, double salary)

        {

            this.CompanyName = companyName;

            this.Department = department;

            this.Salary = salary;

        }



        public string CompanyName { get; set; }



        public string Department { get; set; }



        public double Salary { get; set; }

    }
}
