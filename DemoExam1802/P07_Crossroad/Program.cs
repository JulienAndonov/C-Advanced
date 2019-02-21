using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Crossroad
{
    class Program
    {
        public static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int yellowLightDuration = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            int passedCars = 0;

            while (true)
            {
                var input = Console.ReadLine();


                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{passedCars} total cars passed the crossroads.");
                    break;
                }

                else if (input == "green")
                {
                    if (cars.Any())
                    {
                        var greenWindow = greenLightDuration;
                        while (cars.Count > 0 && greenWindow > 0)
                        {
                            var currentCar = cars.Dequeue();

                            if (currentCar.Length <= greenWindow)
                            {
                                greenWindow -= currentCar.Length;
                                passedCars++;
                            }
                            else if (greenWindow + yellowLightDuration >= currentCar.Length)
                            {
                                passedCars++;
                                break;
                            }
                            else
                            {
                                var index = greenWindow + yellowLightDuration;
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{currentCar} was hit at {currentCar[index]}.");
                                return;

                            }
                        }

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
