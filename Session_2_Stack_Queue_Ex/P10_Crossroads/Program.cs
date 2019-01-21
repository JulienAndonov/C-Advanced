using System;
using System.Collections.Generic;

namespace P10_Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLight = int.Parse(Console.ReadLine());
            int yellowLight = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var passedCars = 0;

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
                    int remainingSeconds = greenLight;

                    while (remainingSeconds > 0 && queue.Count > 0)
                    {
                        if (queue.Peek().Length <= remainingSeconds)
                        {
                            remainingSeconds -= queue.Dequeue().Length;
                            passedCars++;

                        }
                        else if (queue.Peek().Length <= remainingSeconds + yellowLight)
                        {
                            queue.Dequeue();
                            passedCars++;
                            remainingSeconds = 0;

                        }
                        else
                        {
                            var currentCar = queue.Dequeue();
                            var remainingTime = remainingSeconds + yellowLight;
                            for (int i = 0; i < currentCar.Length; i++)
                            {
                                remainingTime--;
                                if (remainingTime < 0)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{currentCar} was hit at {currentCar[i]}.");
                                    return;
                                }
                            }
                        }
                    }
                }
                else
                {
                    queue.Enqueue(input);
                }

            }

            
        }
    }
}
