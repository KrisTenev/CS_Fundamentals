using System;

namespace E05_AddAndSubtract
{
    internal class Program
    {
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            int resultSum = Sum(a, b);
            int resultSub = Substract(resultSum, c);

            Console.WriteLine(resultSub);

        }

        static int Sum(int number1, int number2)
        {
            int sum = number1 + number2;

            return sum;
        }

        static int Substract(int number1, int number2)
        { 
            int sub = number1 - number2;

            return sub;
        }
    }
}
