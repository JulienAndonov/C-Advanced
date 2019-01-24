using System;
using System.Collections.Generic;
using System.Linq;


namespace L04_Cities_By_Continent_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, List<string>>> countriesCities = new Dictionary<string, Dictionary<string, List<string>>>();

            int numOfEntries = int.Parse(Console.ReadLine());



            for (int i = 0; i < numOfEntries; i++)
            {
                var entries = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                var continent = entries[0];
                var country = entries[1];
                var city = entries[2];

                if (!countriesCities.ContainsKey(continent))
                {
                    countriesCities[continent] = new Dictionary<string, List<string>>();
                }

                if (!countriesCities[continent].ContainsKey(country))
                {
                    countriesCities[continent][country] = new List<string>();
                }
                countriesCities[continent][country].Add(city);
            }


            foreach(var continentKVP in countriesCities)
            {
                var continent = continentKVP.Key;
                var countries = continentKVP.Value;

                Console.WriteLine($"{continent}:");
                foreach( var countryKVP in countries)
                {
                    Console.WriteLine($"  {countryKVP.Key} -> {String.Join(", ",countryKVP.Value)}");
                }


            }



        }
    }
}
