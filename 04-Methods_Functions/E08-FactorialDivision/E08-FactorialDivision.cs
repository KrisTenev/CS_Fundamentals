using System;

namespace E08_FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double divResult = DivFacuriels(number1, number2);

            Console.WriteLine($"{divResult:F2}");
        }
        static double DivFacuriels(int number1, int number2)
        {
            double f1 = FindFactoriel(number1);
            double f2 = FindFactoriel(number2);

            double result = f1 / f2;

            return result;
        }
        static int FindFactoriel(int number)
        {
            int result = 1;

            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;
        }

    }
}
