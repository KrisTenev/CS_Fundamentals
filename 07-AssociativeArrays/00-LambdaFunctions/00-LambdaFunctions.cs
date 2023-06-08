using System;
using System.Collections.Generic;
using System.Linq;

namespace _00_LambdaFunctions
{
    internal class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int>()
            { 1 , 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            //var filteredDate = numbers.Where(Filter).ToList();

            var filteredDate = numbers
                .Where(number => number % 2 == 0)
                .AsEnumerable()
                .ToList();

        }


        static bool Filter(int number)
        {
            return number % 2 == 0;
        }
    }
}
