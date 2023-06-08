using System;
using System.Linq;

namespace L06_EvenAndOddSubtraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            //              Read line from comsole
            //              Split string to substrings
            //              Project each element
            //              Creates an array

            int odd = 0;
            int even = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    even += numbers[i];
                }
                else
                {
                    odd += numbers[i];
                }
            }

            Console.WriteLine(even - odd);
        }
    }
}
