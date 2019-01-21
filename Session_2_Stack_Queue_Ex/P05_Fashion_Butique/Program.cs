using System;
using System.Collections.Generic;
using System.Linq;


namespace P05_Fashion_Butique
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> clothes = new Stack<int>(Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray());
            int capacity = int.Parse(Console.ReadLine());
            int originalCapacity = capacity;
            int numOfRacks = 1;

            while (clothes.Any())
            {
                if (clothes.Peek() <= capacity)
                {
                    capacity -= clothes.Pop();
                }
                else
                {
                    numOfRacks++;
                    capacity = originalCapacity;
                }

            }
            Console.WriteLine(numOfRacks);
        }
    }
}
