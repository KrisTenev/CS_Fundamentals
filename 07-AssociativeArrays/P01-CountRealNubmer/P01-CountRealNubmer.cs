﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace P01_CountRealNubmer
{
    internal class Program
    {
        static void Main()
        {
            var numbers = Console.ReadLine().Split().Select(double.Parse).ToArray();

            var count = new SortedDictionary<double, int>();

            foreach (var number in numbers)
            {
                //if (!count.ContainsKey(number))
                //{
                //    count[number] = 1;
                //}
                //else
                //{
                //    count[number]++;
                //}
                if (!count.ContainsKey(number))
                {
                    count[number] = 0;
                }

                count[number]++;
            }

            foreach (var item in count)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
