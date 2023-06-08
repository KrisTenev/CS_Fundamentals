using System;
using System.Linq;

namespace E07_EqualArrays
{
    internal class Program
    {
        static void Main()
        {
            int[] input1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] input2 = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int indexCounter = 0;
            bool isIndentical = true;

            int sumIndentical = 0;

            for (int i = 0; i < input1.Length; i++)
            {
                bool isEqual = input1[i] == input2[i];

                indexCounter++;

                if (!isEqual)
                {
                    Console.Write($"Arrays are not identical. Found difference at {i} index");
                    isIndentical = false;
                    break;
                }
                else
                {
                    sumIndentical += input1[i];
                }

            }

            if (isIndentical)
            {
                Console.WriteLine($"Arrays are identical. Sum: {sumIndentical}");
            }
        }
    }
}
