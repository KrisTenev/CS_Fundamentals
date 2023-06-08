using System;

namespace _04_Methods_Functions
{
    internal class Program
    {
        static void Main()
        {
           Print();
           PrintNumber(2);
            Console.WriteLine(ReturnSum(1, 2));


        }

        static void Print()
        {
            Console.WriteLine("Hello World!");
        
        }
        static void PrintNumber(int number)
        {
            Console.WriteLine(number);
        }

        static int ReturnSum(int number1, int number2)
        { 
            int sum = number1 + number2;

            return sum;
        }



    }
}
