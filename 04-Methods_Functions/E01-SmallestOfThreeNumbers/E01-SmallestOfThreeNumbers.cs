using System;

namespace E01_SmallestOfThreeNumbers
{
    internal class Program
    {
        static void Main()
        {
            int result = int.MaxValue;

            for (int i = 1; i <= 3; i++)
            {
                int number = int.Parse(Console.ReadLine());

                result = SmallestNumber(number, result);


            }
            Console.WriteLine(result);
        }

        static int SmallestNumber(int firstNumber,int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return secondNumber;
            }

            return firstNumber;
        }
    }
}
