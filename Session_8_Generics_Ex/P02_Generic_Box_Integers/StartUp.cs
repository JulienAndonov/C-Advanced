using System;

namespace P02_Generic_Box_Integers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numOfEntries = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfEntries; i++)
            {
                var readLine = Console.ReadLine();
                var box = new Box<int>(int.Parse(readLine));
                Console.WriteLine(box.ToString());
            }
        }
    }
}
