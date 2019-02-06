using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<Employee>> companyRoster = new Dictionary<string, List<Employee>>();
            int numOfEmployees = int.Parse(Console.ReadLine());
            decimal currentAvarage = decimal.MinValue;
            decimal maxAvarage = decimal.MinValue;
            string teamWithHighestAvarage = "";


            for (int i = 0; i < numOfEmployees; i++)
            {
                var name = "";
                decimal salary = 0;
                var position = "";
                var department = "";
                var email = "";
                var age = 0;

                var employeesEntries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);


                if (employeesEntries.Length == 4)
                {
                    name = employeesEntries[0];
                    salary = decimal.Parse(employeesEntries[1]);
                    position = employeesEntries[2];
                    department = employeesEntries[3];

                }
                else if (employeesEntries.Length == 5)
                {
                    if (employeesEntries[4].Contains('@'))
                    {
                        name = employeesEntries[0];
                        salary = decimal.Parse(employeesEntries[1]);
                        position = employeesEntries[2];
                        department = employeesEntries[3];
                        email = employeesEntries[4];
                    }
                    else
                    {
                        name = employeesEntries[0];
                        salary = decimal.Parse(employeesEntries[1]);
                        position = employeesEntries[2];
                        department = employeesEntries[3];
                        age = int.Parse(employeesEntries[4]);
                    }
                }
                else if(employeesEntries.Length == 6)
                {
                    name = employeesEntries[0];
                    salary = decimal.Parse(employeesEntries[1]);
                    position = employeesEntries[2];
                    department = employeesEntries[3];
                    email = employeesEntries[4];
                    age = int.Parse(employeesEntries[5]);
                }


                var currentEmployee = new Employee(name, salary, position, department, email, age);

                if (!companyRoster.ContainsKey(department))
                {
                    companyRoster[department] = new List<Employee>();
                }

                companyRoster[department].Add(currentEmployee);
            }

            foreach (var department in companyRoster.Keys)
            {
                currentAvarage = companyRoster[department].Average(x => x.Salary);
                if (currentAvarage > maxAvarage)
                {
                    maxAvarage = currentAvarage;
                    teamWithHighestAvarage = department;
                }
            }

            Console.WriteLine($"Highest Average Salary: {teamWithHighestAvarage}");

            foreach (var employee in companyRoster[teamWithHighestAvarage].OrderByDescending(x => x.Salary))
            {
                var email = employee.Email;
                var age = employee.Age;

                if(employee.Email == "")
                {
                    email = "n/a";
                }

                if(age == 0)
                {
                    age = -1;
                }

                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {email} {age}");
            }

        }
    }
}
