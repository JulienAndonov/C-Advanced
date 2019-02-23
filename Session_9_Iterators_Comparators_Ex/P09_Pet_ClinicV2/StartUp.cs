using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using System.Net.Sockets;
using P08_Pet_ClinicV2;

namespace P09_Pet_ClinicV2
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var cars = new List<Car>();

            cars.Add(new Car("Opel", 2018));
            cars.Add(new Car("VW", 2010));
            cars.Add(new Car("Astra", 2013));
            cars.Add(new Car("Opel", 2018));
            cars.Add(new Car("Astra", 2018));


            var manufecturers = new List<Manufacturer>();


            manufecturers.Add(new Manufacturer("Opel", "US"));
            manufecturers.Add(new Manufacturer("VW", "Germany"));
            manufecturers.Add(new Manufacturer("Skoda", "Czech Republic"));


            var query =
                from car in cars
                join manufacturer in manufecturers
                    on car.Name equals manufacturer.Name
                orderby car.Year descending, car.Year
                select new
                {
                    car.Name,
                    car.Year,
                    manufacturer.HeadQuarters
                };

            var query2 =
                from car in cars
                group car by car.Year into CarGroup
                select
            {
                
            }
                
        
                


            foreach (var car in query)
            {
                Console.WriteLine($"{car.Name} {car.HeadQuarters} {car.Year}");
            }
        }
    }
}
