using System;
using System.Collections.Generic;
using System.Linq;

namespace E07_AppendArrays
{
    internal class Program
    {
        static void Main()
        {
            List<string> input = Console.ReadLine().Split('|').Reverse().ToList();

            List<int> numbers = new List<int>();

            foreach (var element in input)
            {
                numbers.AddRange(element.Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList());
            }

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
