using System;
using System.Collections.Generic;
using System.Linq;

namespace P07_Tuple
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var nameAdressEntries = Console.ReadLine().Split();
            var name = nameAdressEntries[0] + " " + nameAdressEntries[1];
            var address = nameAdressEntries[2];

            var nameAddressTuple = new Tuple<string, string>(name, address);

            var nameBeerCount = Console.ReadLine().Split().ToList();
            var secondName = nameBeerCount[0];
            var beerCount = int.Parse(nameBeerCount[1]);

            Tuple<string, int> nameBeerCountTuple = new Tuple<string, int>(secondName, beerCount);

            var integerDouble = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToList();
            var integer = int.Parse(integerDouble[0]);
            var doubleValue = double.Parse(integerDouble[1]);

            Tuple<int,double> intDoubleTuple = new Tuple<int, double>(integer,doubleValue);
            

            Console.WriteLine(nameAddressTuple);
            Console.WriteLine(nameBeerCountTuple);
            Console.WriteLine(intDoubleTuple);



        }
    }
}
