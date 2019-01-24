 using System;
using System.Collections.Generic;
using System.Linq;

namespace Session_4_Sets_Multidiml_Dictionaries_Lec
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<double, int> numbers = new Dictionary<double, int>();


            List<double> entryNumbers = Console.ReadLine().Split(" ").Select(double.Parse).ToList();


            foreach(var number in entryNumbers)
            {

                if (!numbers.ContainsKey(number))
                {
                    numbers[number] = 0;
                }

                numbers[number]++;
            }


            foreach(var kvpNumber in numbers)
            {
                Console.WriteLine($"{kvpNumber.Key} - {kvpNumber.Value} times");
            }



        }
    }
}
