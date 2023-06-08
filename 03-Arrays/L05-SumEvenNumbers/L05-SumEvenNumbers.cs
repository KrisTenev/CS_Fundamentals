using System;

namespace L05_SumEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();

            int result = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                int number = int.Parse(numbers[i]);

                if (number % 2 == 0)
                {
                    result += number;
                }
            }

            Console.WriteLine(result);

        }
    }
}
