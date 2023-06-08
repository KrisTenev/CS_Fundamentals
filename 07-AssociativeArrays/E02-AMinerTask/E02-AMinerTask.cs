using System;
using System.Collections.Generic;
using System.Drawing;

namespace E02_AMinerTask
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            var resources = new Dictionary<string, int>();

            while (input != "stop")
            { 
                int quantity = int.Parse(Console.ReadLine());

                if (!resources.ContainsKey(input))
                {
                    resources[input] = 0;
                }

                resources[input] += quantity;

                input = Console.ReadLine();
            }

            foreach (var kvp in resources)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
