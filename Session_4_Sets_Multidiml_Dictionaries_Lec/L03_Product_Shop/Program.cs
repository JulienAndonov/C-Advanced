using System;
using System.Collections.Generic;
using System.Linq;

namespace L03_Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> productStores = new Dictionary<string, Dictionary<string, double>>();


            while (true)
            {

                var input = Console.ReadLine();


                if (input == "Revision")
                {
                    break;
                }

                var entries = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                var shop = entries[0];
                var product = entries[1];
                double price = double.Parse(entries[2]);


                if (!productStores.ContainsKey(shop))
                {
                    productStores[shop] = new Dictionary<string, double>();
                }

                if (!productStores[shop].ContainsKey(product))
                {
                    productStores[shop][product] = 0;
                }

                productStores[shop][product] = price;
            }



            foreach (var shopKVP in productStores.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{shopKVP.Key}->");
                foreach (var product in shopKVP.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }



            }

        }



    }
}
