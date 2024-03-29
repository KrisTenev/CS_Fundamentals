﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P03_ListOfProducts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int totalProducts = int.Parse(Console.ReadLine());

            List<string> products = new List<string>();

            for (int i = 0; i < totalProducts; i++)
            {
                products.Add(Console.ReadLine());
            }

            products.Sort();

            for (int i = 0; i < totalProducts; i++)
            {
                Console.WriteLine($"{i + 1}. {products[i]}");
            }

        }
    }
}
