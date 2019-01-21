using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());
            Queue<int> difference = new Queue<int>();
            int index = 0;


            for (int i = 0; i < pumps; i++)
            {
                int[] resources = Console.ReadLine().Split().Select(int.Parse).ToArray();
                difference.Enqueue(resources[0] - resources[1]);
            }



            while (true)
            {
                Queue<int> copydifference = new Queue<int>(difference);
                int fuel = -1;

                while (copydifference.Any())
                {
                    if (copydifference.Peek() > 0 && fuel == -1)
                    {
                        fuel = copydifference.Dequeue();
                        difference.Enqueue(difference.Dequeue());
                    }
                    else if (copydifference.Peek() < 0 && fuel == -1)
                    {
                        copydifference.Enqueue(copydifference.Dequeue());
                        difference.Enqueue(difference.Dequeue());
                        index++;
                    }
                    else
                    {
                        fuel += copydifference.Dequeue();
                        if (fuel < 0)
                        {
                            index++;
                            break;
                        }
                    }
                }

                if (fuel >= 0)
                {
                    Console.WriteLine(index);
                    return;
                }
                
            }
        }
    }
}
