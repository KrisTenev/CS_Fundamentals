using System;

namespace E09_PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                bool result = IsPalindromeIntegers(input);

                Console.WriteLine(result);

                input = Console.ReadLine();
            }            
        }
        static bool IsPalindromeIntegers(int number)
        {
            int temp = number;
            int sumDigit = 0;

            while (temp > 0)
            {
                int lastDigit = temp % 10;
                sumDigit = (sumDigit * 10) + lastDigit;

                temp = temp / 10;
            }
            if (number == sumDigit)
            {
                return true;
            }

            return false;
        }

        static bool IsPalindromeIntegers(string number)
        {
            string temp = String.Empty;

            for (int i = number.Length -1; i >= 0; i--)
            {
                temp += number[i];
            }
            if (temp == number)
            {
                return true;
            }

            return false;
        }
    }
}
