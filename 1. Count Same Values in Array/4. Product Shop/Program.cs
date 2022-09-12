using System;
using System.Collections.Generic;
using System.Linq;

namespace _4._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Dictionary<string, double>> productShop = new Dictionary<string, Dictionary<string, double>>();
            string[] input = Console.ReadLine().Split(", ") ;

            while (input[0] != "Revision") 
            {
                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);
                
                if (!productShop.ContainsKey(shop))
                {
                    productShop.Add(shop, new Dictionary<string, double>());
                }

                if (!productShop[shop].ContainsKey(product))
                {
                    productShop[shop].Add(product, 0);
                }

                productShop[shop][product] = price;
                input = Console.ReadLine().Split(", ");
            }
            foreach (var (shop, product ) in productShop.OrderBy(x=>x.Key))
            {
                Console.WriteLine($"{shop}-> ");
                foreach (var currProduct in product) 
                {
                    Console.WriteLine($"Product: {currProduct.Key}, Price: {currProduct.Value} ");
                }
                
            }
        }
    }
}
