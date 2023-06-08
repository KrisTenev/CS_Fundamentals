using System;
using System.Collections.Generic;
using System.Linq;

namespace P04_RemoveNegativeAndReverce
{
    internal class RemoveNegativeAndReverse
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            //Variant 1
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] >= 0)
                {
                    result.Add(numbers[i]);
                }
            }

            if (result.Count > 0)
            {
                result.Reverse();
                Console.WriteLine(String.Join(" ", numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }

            //Variant 2
            for (int i = 0; i < numbers.Count; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers.Remove(i--);
                }
            }

            numbers.Reverse();

            if (numbers.Count == 0)
            {
                Console.WriteLine("empty");
            }
            else
            {
                Console.WriteLine(String.Join(" ", numbers));
            }
        }
    }
}
