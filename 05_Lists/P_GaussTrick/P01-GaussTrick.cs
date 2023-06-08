using System;
using System.Collections.Generic;
using System.Linq;

namespace P_GaussTrick
{ 
    internal class P01_GaussTrick
    {
        static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            // Variant 1
            List<int> result = new List<int>();

            for (int i = 0; i < numbers.Count / 2; i++)
            {
                int next = numbers[i] + numbers[numbers.Count - i - 1];
                result.Add(next);
            }

            if (numbers.Count % 2 == 1)
            {
                result.Add(numbers[numbers.Count / 2]);
            }

            Console.Write(String.Join(" ", result));

            Console.WriteLine();
            
            //Variant 2
            int size = numbers.Count / 2;

            for (int i = 0; i < size; i++)
            {
                numbers[i] += numbers[numbers.Count - 1];

                numbers.RemoveAt(numbers.Count - 1);
            }

            Console.Write(String.Join(" ", numbers));


        }
    }
}
