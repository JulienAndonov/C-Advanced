using System;
using System.Linq;

namespace P04_Froggy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var inputStones = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();
            Lake lake = new Lake(inputStones);
            
            Console.WriteLine(string.Join(", ",lake));

        }
    }
}
