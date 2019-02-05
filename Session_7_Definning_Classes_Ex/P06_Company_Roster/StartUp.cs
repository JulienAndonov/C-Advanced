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
                var employeesEntries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var name = employeesEntries[0];
                var salary = decimal.Parse(employeesEntries[1]);
                var position = employeesEntries[2];
                var department = employeesEntries[3];
                var email = (employeesEntries.Length >= 5 ? employeesEntries[4] : "n/a");
                var age = int.Parse(employeesEntries.Length >= 6 ? employeesEntries[5] : "-1") ;

                if (!companyRoster.ContainsKey(department))
                {
                    companyRoster[department] = new List<Employee>();
                }
                var currentEmployee = new Employee(name, salary, position, department, email, age);
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
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }

        }
    }
}
