using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace DefiningClasses
{
    class Employee
    {
        private string name;
        private decimal salary;
        private string position;
        private string department;
        private string email;
        private int age;


        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public decimal Salary
        {
            get { return this.salary; }
            set { this.salary = value; }
        }

        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }

        public string Department
        {
            get { return this.department; }
            set { this.department = value; }
        }

        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public int Age
        {
            get { return this.age; }
            set { this.age = value; }
        }

        public Employee(string empName, decimal empSalary, string empPosition, string empDepartment)
        {
            this.Name = empName;
            this.Salary = empSalary;
            this.Position = empPosition;
            this.Department = empDepartment;
        }

        public Employee(string empName, decimal empSalary, string empPosition, string empDepartment, string empEmail) : this(empName, empSalary, empPosition, empDepartment)
        {
            this.Email = empEmail;
        }

        public Employee(string empName, decimal empSalary, string empPosition, string empDepartment,int empAge) : this(empName, empSalary, empPosition, empDepartment)
        {
            this.Age = empAge;
        }

        public Employee(string empName, decimal empSalary, string empPosition, string empDepartment, string empEmail, int empAge) : this(empName, empSalary, empPosition, empDepartment)
        {
            this.Email = empEmail;
            this.Age = empAge;
        }
    }
}
