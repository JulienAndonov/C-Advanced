using System;
using System.Linq;

namespace IteratorsAndComparators
{
    class StartUp
    {
        static void Main(string[] args)
        {
            CoolStack<int> coolstack = new CoolStack<int>();

            var input = Console.ReadLine();

            while (true)
            {
                if (input == "END")
                {
                    break;
                }

                var splittedInput = input.Split(" ", 2).ToArray();

                switch (splittedInput[0])
                {
                    case "Push":
                        var splittedNumbers = splittedInput[1].Split(", ").Select(int.Parse).ToArray();
                        coolstack.Push(splittedNumbers);
                        break;
                    case "Pop":
                        try
                        {
                            coolstack.Pop();
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                        break;
                }
                input = Console.ReadLine();
            }





            for (int i = 0; i < 2; i++)
            {
                foreach (var number in coolstack)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
