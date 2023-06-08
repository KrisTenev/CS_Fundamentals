using System;

namespace E06_StrongNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int copyNimber = number;
            int sum = 0;

            //take each number and calculate facurels
            while (copyNimber != 0)
            {
                int currentDigit = copyNimber % 10;

                int currentFactorial = 1;

                for (int i = 1; i <= currentDigit; i++)
                {
                    currentFactorial *= i;
                }

                sum += currentFactorial;

                copyNimber /= 10;

            }
            
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
