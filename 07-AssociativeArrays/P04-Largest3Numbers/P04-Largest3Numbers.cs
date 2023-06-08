using System;
using System.Linq;

namespace P04_Largest3Numbers
{
    internal class Program
    {
        static void Main()
        {
            Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .OrderByDescending(n => n)
                .Take(3)
                .ToList()
                .ForEach(Console.WriteLine);
        }
    }
}
