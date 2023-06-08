using System;
using System.Collections.Generic;
using System.Linq;

namespace _02_ReadFromConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //100
            //200
            //300
            //400

            int n = int.Parse(Console.ReadLine());
            List<int> numbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int number = int.Parse(Console.ReadLine());

                numbers.Add(number);
            }

            //100 200 300 400 500

            List<int> newNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            //....

        }
    }
}
