using System;

namespace P08_Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var nameAddressTownEntries = Console.ReadLine().Split();
            var name = nameAddressTownEntries[0] +" " + nameAddressTownEntries[1];
            var address = nameAddressTownEntries[2];
            var town = nameAddressTownEntries[3];

            var nameAddressTownTuple = new Threeuple<string, string, string>(name,address,town);


            var nameBeerCountDrunk = Console.ReadLine().Split();
            var nameSecond = nameBeerCountDrunk[0];
            int littersOfBeer = int.Parse(nameBeerCountDrunk[1]);
            bool drunk = nameBeerCountDrunk[2] == "drunk" ? true : false;

            var nameBeerCountDrunkTuple = new Threeuple<string, int, bool>(nameSecond,littersOfBeer,drunk);

            var nameAccountBankEntries = Console.ReadLine().Split();
            var name3 = nameAccountBankEntries[0];
            var accountBalance = double.Parse(nameAccountBankEntries[1]);
            var bankName = nameAccountBankEntries[2];

            Threeuple<string,double,string> nameAccountBankTuple = new Threeuple<string, double, string>(name3,accountBalance,bankName);

            Console.WriteLine(nameAddressTownTuple);
            Console.WriteLine(nameBeerCountDrunkTuple);
            Console.WriteLine(nameAccountBankTuple);




        }
    }
}
