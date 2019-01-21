using System;
using System.Collections.Generic;
using System.Linq;

namespace L06_Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            int nthRemove = int.Parse(Console.ReadLine());
            Queue<string> children = new Queue<string>(input);
            int counter = 1;


            while (true)
            {
                if (children.Count() == 1)
                {
                    Console.WriteLine($"Last is {children.Dequeue()}");
                    break;
                }
                var currentChild = children.Dequeue();

                if (counter % nthRemove != 0)
                {
                    children.Enqueue(currentChild);
                }
                else
                {
                    Console.WriteLine($"Removed {currentChild}");
                }
                counter++;
            }



        }
    }
}
