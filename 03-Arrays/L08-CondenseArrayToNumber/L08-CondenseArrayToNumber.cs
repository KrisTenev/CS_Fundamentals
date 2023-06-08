using System;
using System.Linq;

namespace L08_CondenseArrayToNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            while (numbers.Length > 1)
            {
                int[] condensed = new int[numbers.Length - 1];

                // sum elements and store in condensed[]
                for (int j = 0; j < numbers.Length - 1; j++)
                {
                    condensed[j] = numbers[j] + numbers[j + 1];
                }

                numbers = condensed; //new lenght -1
            }

            Console.WriteLine(string.Join(" ", numbers));


        }
    }
}
