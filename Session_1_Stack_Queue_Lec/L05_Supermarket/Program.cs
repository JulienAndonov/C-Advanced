﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace L05_Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            Queue<string> customers = new Queue<string>();

            while (input != "End")
            {
                if (input == "Paid")
                {
                    int count = customers.Count();
                    for (int i = 0; i < count; i++)
                    {
                        Console.WriteLine(customers.Dequeue());
                    }
                }
                else
                {
                    customers.Enqueue(input);
                }
                input = Console.ReadLine();
            }
                Console.WriteLine($"{customers.Count()} people remaining.");
        }
    }
}
