using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace E04_Orders
{
    internal class Program
    {
        static void Main()
        {
            string[] input = Console.ReadLine().Split(" ");

            Dictionary<string, List<double>> output = new Dictionary<string, List<double>>();

            while (input[0] != "buy")
            {
                string product = input[0];
                double price = double.Parse(input[1]);
                int quantity = int.Parse(input[2]);

                double total = price * quantity;

                if (!output.ContainsKey(product))
                {
                    output[product] = new List<double>() { price, quantity };
                }
                else
                {
                    output[product][0] = price;         //replace the price 
                    output[product][1] += quantity;     //increase the quantity 
                }

                input = Console.ReadLine().Split(" ");
            }

            foreach (var kvp in output)
            {
                Console.WriteLine($"{kvp.Key} -> {(kvp.Value[0] * kvp.Value[1]):F2}");
            }
        }
    }
}
