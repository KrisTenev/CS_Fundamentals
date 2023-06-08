using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int endRange = int.Parse(Console.ReadLine());
            PrintTopNumber(endRange);
        }

        static bool CheckIsDevisibleByEight(int number)
        {
            if (number % 8 == 0)
            {
                return true;
            }
            return false;
        }

        static bool CheckForOneOddDigit(int number)
        {
            if (number % 2 == 1)
            {
                return true;
            }
            return false;
        }

        static void PrintTopNumber(int endRange)
        {
            int sum = 0;
            bool haveOddDigit = false;

            for (int i = 1; i <= endRange; i++)
            {
                string tmp = i.ToString();

                for (int j = 0; j < tmp.Length; j++)
                {
                    int digit = int.Parse(tmp[j].ToString());
                    sum += digit;

                    haveOddDigit = CheckForOneOddDigit(digit);
                }

                if (CheckIsDevisibleByEight(sum) && haveOddDigit)
                {
                    Console.WriteLine(i);
                }

                sum = 0;
                haveOddDigit = false;
            }
        }
    }
}
