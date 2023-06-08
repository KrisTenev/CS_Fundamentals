using System;
using System.Collections.Generic;
using System.Linq;

namespace E01_CountCharsInAString
{
    internal class Program
    {
        static void Main()
        {

            string input = Console.ReadLine();

            var count = new Dictionary<char, int>();

            for (int i = 0; i < input.Length; i++)
            {
                char symbol = input[i];

                if (symbol != ' ')
                {
                    if (!count.ContainsKey(symbol))
                    {
                        count[symbol] = 0;
                    }

                    count[symbol]++;
                }
            }

            foreach (var kvp in count)
            {
                Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
            }
        }
    }
}
