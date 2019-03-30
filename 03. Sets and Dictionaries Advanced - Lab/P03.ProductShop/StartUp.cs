using System;
using System.Collections.Generic;
using System.Linq;

namespace P03.ProductShop
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> shops = new Dictionary<string, Dictionary<string, double>>();

            while (true)
            {
                string[] input = Console.ReadLine().Split(", ");

                if (input[0] == "Revision")
                {
                    break;
                }

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!shops.ContainsKey(shop))
                {
                    shops[shop] = new Dictionary<string, double>();
                }

                shops[shop].Add(product, price);
            }

            foreach (var kvp in shops.OrderBy(x => x.Key))
            {
                string name = kvp.Key;
                Dictionary<string, double> products = kvp.Value;

                Console.WriteLine($"{name}->");
                foreach (var product in products)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
