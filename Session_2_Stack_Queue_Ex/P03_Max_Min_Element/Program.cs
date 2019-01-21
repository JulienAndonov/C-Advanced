using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Max_Min_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            var numOfQueries = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();



            for (int i = 0; i < numOfQueries; i++)
            {
                var tokens = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
                int command = tokens[0];


                switch (command)
                {
                    case 1:
                        numbers.Push(tokens[1]);
                        break;
                    case 2:
                        if (numbers.Count > 0)
                        {
                            numbers.Pop();
                        }
                        break;
                    case 3:
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Max());
                        }
                        
                        break;
                    case 4:
                        if (numbers.Count > 0)
                        {
                            Console.WriteLine(numbers.Min());
                        }
                        
                        break;
                }
            }

            if(numbers.Count() > 0)
            {
                Console.WriteLine(String.Join(", ", numbers));
            }
            




        }
    }
}
