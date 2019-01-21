using System;
using System.Collections.Generic;
using System.Linq;

namespace L07_Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            var carsPassing = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            var passedCars = 0;

            while (true)
            {
                string input = Console.ReadLine();


                if (input == "end")
                {
                    Console.WriteLine($"{passedCars} cars passed the crossroads.");
                    break;
                }

                if (input == "green")
                {
                    var passingCars = Math.Min(cars.Count, carsPassing);
                    for (int i = 0; i < passingCars; i++)
                    {
                        Console.WriteLine($"{cars.Dequeue()} passed!");
                        passedCars++;
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }


        }
    }
}
