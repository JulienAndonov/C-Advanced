using System;
using System.Linq;


namespace IteratorsAndComparators
{
    class StartUp
    {
        static void Main(string[] args)
        {
            ListyIterator<string> listy = null;

            while (true)
            {
                var splitedInput = Console.ReadLine().Split(" ");

                if (splitedInput[0] == "END")
                {
                    break;
                }

                switch (splitedInput[0])
                {
                    case "Create":
                        listy = new ListyIterator<string>(splitedInput.Skip(1).ToList());
                        break;
                    case "Move":
                        Console.WriteLine(listy.Move());
                        break;
                    case "Print":
                        Console.WriteLine(listy.Print());
                        break;
                    case "HasNext":
                        Console.WriteLine(listy.HasNext());
                        break;
                    case "PrintAll":
                        Console.WriteLine(listy.PrintAll());
                        break;
                }
            }


        }
    }
}
