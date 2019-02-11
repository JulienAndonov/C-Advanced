using System;

namespace Session_8_Generics_Ex
{
    class StartUp
    {
        static void Main(string[] args)
        {
            
            int numOfEntries = int.Parse(Console.ReadLine());


            for (int i = 0; i < numOfEntries; i++)
            {
                var readLine = Console.ReadLine();
                var box = new Box<string>(readLine);
                Console.WriteLine(box.ToString());
            }

        }
    }
}
