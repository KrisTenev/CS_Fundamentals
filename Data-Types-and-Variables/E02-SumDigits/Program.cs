using System;

namespace E02_SumDigits
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* 
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number > 0)
            {
                int digit = number;

                sum += digit % 10;

                number /= 10;
            }
            Console.WriteLine(sum);
           */

            /*
            //Read number as string left-to-right
            string number = Console.ReadLine();

            int sum = 0;

            for (int i = 0; i < number.Length; i++)
            {
                int digit = int.Parse(number[i].ToString());
                sum += digit;
            }
            Console.WriteLine(sum);
            */

            //Read number as string right-to-left
            string number = Console.ReadLine();

            int sum = 0;

            for (int i = number.Length -1 ; i >= 0; i--)
            {
                int digit = int.Parse(number[i].ToString());
                sum += digit;
            }
            Console.WriteLine(sum);
        }
    }
}
