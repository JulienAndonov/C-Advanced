using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_Generic_Swap_Method
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Box<string> box = new Box<string>();
            int numOfEntries = int.Parse(Console.ReadLine());

            for (int i = 0; i < numOfEntries; i++)
            {
                var currentLine = Console.ReadLine();
                box.Add(currentLine);
            }

            var swapEntries = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var indOne = swapEntries[0];
            var indTwo = swapEntries[1];

            Swap(box.Data, indOne, indTwo);

            Console.WriteLine(box);
        }


        public static void Swap<T>(List<T> box, int indOne, int indTwo)
        {
            var temp = box[indOne];
            box[indOne] = box[indTwo];
            box[indTwo] = temp;
        }
    }
}
